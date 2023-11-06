using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
	public partial class DodajPlacanjeForma : Form
	{
		public DodajPlacanjeForma()
		{
			InitializeComponent();
		}

		private void chbOstvareniProtok_CheckedChanged(object sender, EventArgs e)
		{
			if(chbOstvareniProtok.Checked)
			{
				chbFlatRate.Checked = false;
				grbStaticka1.Enabled = false;
			}
		}

		private void chbFlatRate_CheckedChanged(object sender, EventArgs e)
		{
			if (chbFlatRate.Checked)
			{
				chbOstvareniProtok.Checked = false;
				grbStaticka1.Enabled = true;
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
				grbStaticka2.Enabled=false;
			}
		}

		private void btnDodaj_Click(object sender, EventArgs e)
		{
			if (chbOstvareniProtok.Checked)
			{
				OstavreniProtokBasic placanje = new OstavreniProtokBasic();
				placanje.TipPlacanja = "Ostvareni protok";
				placanje.KolicinaOstavrenogProtoka = 0;
				DTOManager.SacuvajOstvareniProtok(placanje);
				this.Close();
			}
			else if (chbFlatRate.Checked)
			{
				FlatRateBasic placanje = new FlatRateBasic();
				placanje.TipPlacanja = "Flat rate";
				StatickaAdresaBasic adresa = new StatickaAdresaBasic();
				if (txbStaticka1.Text != "")
				{
					adresa.Staticka_Adresa = txbStaticka1.Text;
					adresa.FlataRate = placanje;
					placanje.StatickeAdrese.Add(adresa);
					if (chbDozvoliDruguAdresu.Checked)
					{
						if (txbStaticka2.Text != "")
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
					DTOManager.SacuvajFlatRate(placanje);
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
	}
}
