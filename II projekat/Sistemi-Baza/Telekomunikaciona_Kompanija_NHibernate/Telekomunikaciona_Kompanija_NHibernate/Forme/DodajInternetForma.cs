using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telekomunikaciona_Kompanija_NHibernate.Entiteti;

namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    public partial class DodajInternetForma : Form
    {
        public DodajInternetForma()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chbPrepaid.Checked)
            {
                chbPostpaid.Checked = false;
            }
        }

        private void chbPostpaid_CheckedChanged(object sender, EventArgs e)
        {
            if(chbPostpaid.Checked)
            {
                chbPrepaid.Checked = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            InternetBasic net=new InternetBasic();
            net.TipIUsluge = "Internet";
            if (chbPrepaid.Checked)
            {
                net.TipInterneta = "Prepaid";
                net.FlagPrepaid = true;
                net.StanjeRacuna = 0;
                net.DatumPoslednjeUplate=DateTime.Now;
            }
            else if(chbPostpaid.Checked)
            {
                net.TipInterneta = "Postpaid";
                net.FlagPrepaid = false;
			}
            else
            {
				MessageBox.Show("Neopohodno je da izaberete tip interneta!");
			}
            if(chbOstvareniProtok.Checked)
            {
				OstavreniProtokBasic placanje =new OstavreniProtokBasic();
				placanje.TipPlacanja = "Ostvareni protok";
                placanje.KolicinaOstavrenogProtoka = 0;
                net.Placanje= placanje;
				DTOManager.SacuvajInternet(net, placanje, null);
				this.Close();
			}
            else if(chbFlatRate.Checked)
            {
                FlatRateBasic placanje=new FlatRateBasic();
                placanje.TipPlacanja = "Flat rate";
				StatickaAdresaBasic adresa = new StatickaAdresaBasic();
				if (txbStaticka1.Text != "")
				{
					adresa.Staticka_Adresa = txbStaticka1.Text;
                    adresa.FlataRate = placanje;
                    placanje.StatickeAdrese.Add(adresa);
                    if(chbDozvoliDruguAdresu.Checked)
                    {
                        if(txbStaticka2.Text!="")
                        {
							StatickaAdresaBasic adresa1 = new StatickaAdresaBasic();
							adresa1.Staticka_Adresa = txbStaticka2.Text;
							adresa1.FlataRate = placanje;
							placanje.StatickeAdrese.Add(adresa1);
						}
						else
						{
							MessageBox.Show("Neopohodno je da unesete staticku adresu!");
						}
					}
					net.Placanje = placanje;
					DTOManager.SacuvajInternet(net, null, placanje);
					MessageBox.Show("Uspesno ste dodali novi internet!");
					this.Close();
				}
				else
				{
					MessageBox.Show("Neopohodno je da unesete staticku adresu!");
				}
            }
            else
            {
                MessageBox.Show("Neopohodno je da izaberete tip placanja!");
            }
        }

		private void groupBox4_Enter(object sender, EventArgs e)
		{

		}

		private void chbOstvareniProtok_CheckedChanged(object sender, EventArgs e)
		{
            if(chbOstvareniProtok.Checked)
            {
                chbFlatRate.Checked = false;
            }
		}

		private void chbFlatRate_CheckedChanged(object sender, EventArgs e)
		{
			if (chbFlatRate.Checked)
			{
				chbOstvareniProtok.Checked = false;
                grbStaticka1.Enabled = true;
			}
            else
            {
                grbStaticka1.Enabled=false;
            }
		}

		private void chbDozvoliDruguAdresu_CheckedChanged(object sender, EventArgs e)
		{
            if(chbDozvoliDruguAdresu.Checked)
            {
                grbStaticka2.Enabled = true;
            }
            else
            {
				grbStaticka2.Enabled = false;
			}
		}
	}
}
