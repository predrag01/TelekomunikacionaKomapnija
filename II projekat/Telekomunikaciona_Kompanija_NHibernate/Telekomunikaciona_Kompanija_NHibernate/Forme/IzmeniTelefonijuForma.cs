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
    public partial class IzmeniTelefonijuForma : Form
    {
        TelefonijaBasic telefonija;
        public IzmeniTelefonijuForma()
        {
            InitializeComponent();
        }
        public IzmeniTelefonijuForma(TelefonijaBasic t)
        {
            InitializeComponent();
            telefonija = t;
        }

        private void IzmeniTelefonijuForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        
        public void PopuniPodacima()
        {
            txbBrTel1.Text = telefonija.Brojevi_Telefona[0].Broj.ToString();
            PotroseniMin1.Value = telefonija.Brojevi_Telefona[0].Potroseni_minuti;
            if(telefonija.Brojevi_Telefona.Count==2 )
            {
                chbDrugiBr.Checked = true;
                txbBrTel2.Text = telefonija.Brojevi_Telefona[1].Broj.ToString();
                PotroseniMin2.Value = telefonija.Brojevi_Telefona[1].Potroseni_minuti;
            }
            else if(telefonija.Brojevi_Telefona.Count == 3)
            {
                grbOstaliBr.Enabled = true;

				chbDrugiBr.Checked = true;
				txbBrTel2.Text = telefonija.Brojevi_Telefona[1].Broj.ToString();
				PotroseniMin2.Value = telefonija.Brojevi_Telefona[1].Potroseni_minuti;

				chbTreciBr.Checked = true;
				txbBrTel3.Text = telefonija.Brojevi_Telefona[2].Broj.ToString();
				numMinuti3.Value = telefonija.Brojevi_Telefona[2].Potroseni_minuti;
			}
            else if (telefonija.Brojevi_Telefona.Count == 4)
			{
				grbOstaliBr.Enabled = true; 

				chbDrugiBr.Checked = true;
				txbBrTel2.Text = telefonija.Brojevi_Telefona[1].Broj.ToString();
				PotroseniMin2.Value = telefonija.Brojevi_Telefona[1].Potroseni_minuti;

				chbTreciBr.Checked = true;
				txbBrTel3.Text = telefonija.Brojevi_Telefona[2].Broj.ToString();
				numMinuti3.Value = telefonija.Brojevi_Telefona[2].Potroseni_minuti;

				chbCetvrtiBr.Checked = true;
				txbBrTel4.Text = telefonija.Brojevi_Telefona[3].Broj.ToString();
				numMinuti4.Value = telefonija.Brojevi_Telefona[3].Potroseni_minuti;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chbDrugiBr_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDrugiBr.Checked)
            {
                txbBrTel2.Enabled = true;
                PotroseniMin2.Enabled = true;
                //grbOstaliBr.Enabled = true;
            }
            else
            {
                txbBrTel2.Enabled = false;
                PotroseniMin2.Enabled = false;
				grbOstaliBr.Enabled = false;
			}
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            telefonija.Brojevi_Telefona[0].Broj=Int32.Parse(txbBrTel1.Text);
            telefonija.Brojevi_Telefona[0].Potroseni_minuti =(int)PotroseniMin1.Value;
			
			if (chbCetvrtiBr.Checked)
			{
				if (telefonija.Brojevi_Telefona.Count == 3)
				{
					BrojTelefonaBasic br2 = new BrojTelefonaBasic();
					br2.Potroseni_minuti = (int)numMinuti4.Value;
					br2.Broj = Int32.Parse(txbBrTel4.Text);
					br2.PripadaTelefoniji = telefonija;
					telefonija.Brojevi_Telefona.Add(br2);
				}
				else
				{
					telefonija.Brojevi_Telefona[3].Broj = Int32.Parse(txbBrTel4.Text);
					telefonija.Brojevi_Telefona[3].Potroseni_minuti = (int)numMinuti4.Value;
				}


			}
			else
			{
				if (telefonija.Brojevi_Telefona.Count > 3)
				{
					telefonija.Brojevi_Telefona.RemoveAt(3);
				}
			}

			if (chbTreciBr.Checked)
			{
				if (telefonija.Brojevi_Telefona.Count == 2)
				{
					BrojTelefonaBasic br1 = new BrojTelefonaBasic();
					br1.Potroseni_minuti = (int)numMinuti3.Value;
					br1.Broj = Int32.Parse(txbBrTel3.Text);
					br1.PripadaTelefoniji = telefonija;
					telefonija.Brojevi_Telefona.Add(br1);
				}
				else
				{
					telefonija.Brojevi_Telefona[2].Broj = Int32.Parse(txbBrTel3.Text);
					telefonija.Brojevi_Telefona[2].Potroseni_minuti = (int)numMinuti3.Value;
				}

			}
			else
			{
				if (telefonija.Brojevi_Telefona.Count > 2)
				{
					telefonija.Brojevi_Telefona.RemoveAt(2);
				}
			}

			if (chbDrugiBr.Checked)
			{
				if (telefonija.Brojevi_Telefona.Count == 1)
				{
					BrojTelefonaBasic br = new BrojTelefonaBasic();
					br.Potroseni_minuti = (int)PotroseniMin2.Value;
					br.Broj = Int32.Parse(txbBrTel2.Text);
					br.PripadaTelefoniji = telefonija;
					telefonija.Brojevi_Telefona.Add(br);
				}
				else
				{
					telefonija.Brojevi_Telefona[1].Broj = Int32.Parse(txbBrTel2.Text);
					telefonija.Brojevi_Telefona[1].Potroseni_minuti = (int)PotroseniMin2.Value;
				}
			}
			else
			{
				if (telefonija.Brojevi_Telefona.Count > 1)
				{
					telefonija.Brojevi_Telefona.RemoveAt(1);
				}
			}
			DTOManager.IzmeniTelefoniju(telefonija);
            this.Close();
        }

		private void chbTreciBr_CheckedChanged(object sender, EventArgs e)
		{
            if(chbTreciBr.Checked)
            {
                txbBrTel3.Enabled= true;
                numMinuti3.Enabled= true;
            }
            else
            {
                txbBrTel3.Enabled= false;
                numMinuti3.Enabled= false;
			}
		}

		private void chbCetvrtiBr_CheckedChanged(object sender, EventArgs e)
		{
			if (chbCetvrtiBr.Checked)
			{
				txbBrTel4.Enabled = true;
				numMinuti4.Enabled = true;
			}
			else
			{
				txbBrTel4.Enabled = false;
				numMinuti4.Enabled = false;
			}
		}
	}
}
