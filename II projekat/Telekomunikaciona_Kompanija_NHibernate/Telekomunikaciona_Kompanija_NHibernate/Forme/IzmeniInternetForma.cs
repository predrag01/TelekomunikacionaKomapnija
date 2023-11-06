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
	public partial class IzmeniInternetForma : Form
	{
		InternetBasic internet;
		public IzmeniInternetForma()
		{
			InitializeComponent();
		}

        public IzmeniInternetForma(InternetBasic net)
        {
			InitializeComponent();
			internet = net;
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void IzmeniInternetForma_Load(object sender, EventArgs e)
		{
			PopuniPodacima();
		}

		public void PopuniPodacima()
		{
			if(internet.FlagPrepaid)
			{ 
				chbPrepaid.Checked = true;
				dateUplata.Value = internet.DatumPoslednjeUplate;
				numStanjeRacuna.Value = internet.StanjeRacuna;
			}
			else
			{
				chbPostpaid.Checked = true;
			}
			
		}

		private void chbPrepaid_CheckedChanged(object sender, EventArgs e)
		{
			if(chbPrepaid.Checked)
			{
				chbPostpaid.Checked = false;
				grbInternet.Enabled = true;
			}
		}

		private void chbPostpaid_CheckedChanged(object sender, EventArgs e)
		{
			if(chbPostpaid.Checked)
			{
				chbPrepaid.Checked = false;
				grbInternet.Enabled = false;
			}
		}

		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			if(chbPostpaid.Checked)
			{
				if(internet.FlagPrepaid)
				{
					internet.TipInterneta = "Postpaid";
					internet.FlagPrepaid = false;
					internet.DatumPoslednjeUplate = DateTime.MinValue;
					internet.StanjeRacuna = int.MinValue;
				}
			}
			else
			{
				if (!internet.FlagPrepaid)
				{
					internet.TipInterneta = "Prepaid";
					internet.FlagPrepaid = true;
					internet.DatumPoslednjeUplate = DateTime.Now;
					internet.StanjeRacuna = 0;
				}
				else
				{
					internet.DatumPoslednjeUplate = dateUplata.Value;
					internet.StanjeRacuna = (int)numStanjeRacuna.Value;
				}
				
			}
			DTOManager.IzmeniInternet(internet);
			this.Close();
		}
	}
}
