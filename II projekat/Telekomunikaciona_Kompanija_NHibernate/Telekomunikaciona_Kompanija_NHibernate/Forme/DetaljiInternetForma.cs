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
	public partial class DetaljiInternetForma : Form
	{
		InternetBasic internet;
		public DetaljiInternetForma()
		{
			InitializeComponent();
		}
		public DetaljiInternetForma(InternetBasic net)
		{
			InitializeComponent();
			internet=net;
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void DetaljiInternetForma_Load(object sender, EventArgs e)
		{
			PopuniPodacima();
		}
		public void PopuniPodacima()
		{
			lblId.Text=internet.Id.ToString();
			lblTip.Text = internet.TipInterneta;
			if(internet.FlagPrepaid)
			{
				lblDatum.Text=internet.DatumPoslednjeUplate.ToShortDateString().ToString();
				lblStanje.Text=internet.StanjeRacuna.ToString();
			}
			else
			{
				datum.Hide();
				stanje.Hide();
			}
		}
	}
}
