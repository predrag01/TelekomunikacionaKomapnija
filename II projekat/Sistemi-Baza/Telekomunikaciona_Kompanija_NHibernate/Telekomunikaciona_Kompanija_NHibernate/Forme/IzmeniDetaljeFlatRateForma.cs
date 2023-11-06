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
	public partial class IzmeniDetaljeFlatRateForma : Form
	{
		FlatRateBasic placanje;
		public IzmeniDetaljeFlatRateForma()
		{
			InitializeComponent();
		}
		public IzmeniDetaljeFlatRateForma(FlatRateBasic pl)
		{
			InitializeComponent();
			placanje = pl;
		}

		private void IzmeniDetaljeFlatRateForma_Load(object sender, EventArgs e)
		{
			PopuniPodacima();
		}

		public void PopuniPodacima()
		{
			if(placanje.StatickeAdrese.Count>0)
			{
				txbStaticka1.Text = placanje.StatickeAdrese[0].Staticka_Adresa;
				if (placanje.StatickeAdrese.Count > 1)
				{
					chbOmoguciStaticku2.Checked = true;
					txbStaticka2.Text = placanje.StatickeAdrese[1].Staticka_Adresa;
				}
			}
		}

		private void chbOmoguciStaticku2_CheckedChanged(object sender, EventArgs e)
		{
			if(chbOmoguciStaticku2.Checked)
			{
				grbStaticka2.Enabled= true;
			}
			else
			{
				grbStaticka2.Enabled= false;
			}
		}

		private void btnIzmeni_Click(object sender, EventArgs e)
		{
			if(placanje.StatickeAdrese.Count==0)
			{
				StatickaAdresaBasic ad1 = new StatickaAdresaBasic();
				ad1.FlataRate = placanje;
				ad1.Staticka_Adresa = txbStaticka1.Text;
				placanje.StatickeAdrese.Add(ad1);
			}
			else
			{
				placanje.StatickeAdrese[0].Staticka_Adresa = txbStaticka1.Text;
			}
			if(chbOmoguciStaticku2.Checked)
			{
				if(placanje.StatickeAdrese.Count > 1)
				{
					placanje.StatickeAdrese[1].Staticka_Adresa= txbStaticka2.Text;
				}
				else
				{
					StatickaAdresaBasic ad=new StatickaAdresaBasic();
					ad.FlataRate = placanje;
					ad.Staticka_Adresa = txbStaticka2.Text;
					placanje.StatickeAdrese.Add(ad);
				}
			}
			else
			{
				if (placanje.StatickeAdrese.Count > 1)
				{
					placanje.StatickeAdrese.RemoveAt(1);
				}
			}
			DTOManager.IzmeniFlatRate(placanje);
			Close();
		}
	}
}
