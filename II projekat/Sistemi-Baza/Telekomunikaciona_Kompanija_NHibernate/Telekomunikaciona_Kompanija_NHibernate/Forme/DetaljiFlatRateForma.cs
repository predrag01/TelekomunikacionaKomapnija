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
	public partial class DetaljiFlatRateForma : Form
	{
		FlatRateBasic placanje;
		public DetaljiFlatRateForma()
		{
			InitializeComponent();
		}
		public DetaljiFlatRateForma(FlatRateBasic pl)
		{
			InitializeComponent();
			placanje = pl;
		}

		private void DetaljiFlatRateForma_Load(object sender, EventArgs e)
		{
			PopuniPodacima();
		}

		public void PopuniPodacima()
		{
			if(placanje.StatickeAdrese.Count> 0)
			{
				lblStaticka1.Text = placanje.StatickeAdrese[0].Staticka_Adresa;
			}
			else
			{
				lblStaticka1.Text = "";
			}
			if(placanje.StatickeAdrese.Count>1)
			{
				lblStaticka2.Text = placanje.StatickeAdrese[1].Staticka_Adresa;
			}
			else
			{
				lblStaticka2.Text = "";
			}
		}

		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			IzmeniDetaljeFlatRateForma forma = new IzmeniDetaljeFlatRateForma(placanje);
			forma.ShowDialog();
			PopuniPodacima();
		}
	}
}
