using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    public partial class DodajTelefonijuForma : Form
    {
        public DodajTelefonijuForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            TelefonijaBasic tel=new TelefonijaBasic();
            tel.TipIUsluge = "Telefonija";
            if(txbBrTel1!=null && txbBrTel1.Text!="")
            {
                BrojTelefonaBasic br=new BrojTelefonaBasic();
                br.Potroseni_minuti = 0;
                br.Broj=Int32.Parse(txbBrTel1.Text);
                br.PripadaTelefoniji = tel;
                tel.Brojevi_Telefona.Add(br);
            }
            if (chbDrugiBr.Checked)
            {
                BrojTelefonaBasic br = new BrojTelefonaBasic();
                br.Potroseni_minuti = 0;
                br.Broj = Int32.Parse(txbBrTel2.Text);
                br.PripadaTelefoniji = tel;
                tel.Brojevi_Telefona.Add(br);
            }
            if(chbTreciBroj.Checked)
            {
				BrojTelefonaBasic br1 = new BrojTelefonaBasic();
				br1.Potroseni_minuti = 0;
				br1.Broj = Int32.Parse(txtBr3.Text);
				br1.PripadaTelefoniji = tel;
				tel.Brojevi_Telefona.Add(br1);
			}
			if (chbCetvrtiBroj.Checked)
			{
				BrojTelefonaBasic br2 = new BrojTelefonaBasic();
				br2.Potroseni_minuti = 0;
				br2.Broj = Int32.Parse(txbBr4.Text);
				br2.PripadaTelefoniji = tel;
				tel.Brojevi_Telefona.Add(br2);
			}
			DTOManager.SacuvajTelefoniju(tel);
            this.Close();
        }

        private void chbDrugiBr_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDrugiBr.Checked)
            {
                txbBrTel2.Enabled = true;
                grbOstaliBrojevi.Enabled = true;
            }
            else
            {
                txbBrTel2.Enabled = false;
				grbOstaliBrojevi.Enabled = false;
			}
        }

		private void txtBr3_TextChanged(object sender, EventArgs e)
		{

		}

		private void chbTreciBroj_CheckedChanged(object sender, EventArgs e)
		{
            if(chbTreciBroj.Checked)
            {
                txtBr3.Enabled=true;
            }
            else
            {
                txtBr3.Enabled=false;
            }
		}

		private void chbCetvrtiBroj_CheckedChanged(object sender, EventArgs e)
		{
			if (chbCetvrtiBroj.Checked)
			{
				txbBr4.Enabled = true;
			}
			else
			{
				txbBr4.Enabled = false;
			}
		}
	}
}
