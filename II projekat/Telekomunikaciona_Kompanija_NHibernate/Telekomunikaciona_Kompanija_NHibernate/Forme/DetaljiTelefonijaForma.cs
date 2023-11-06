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
	public partial class DetaljiTelefonijaForma : Form
	{
		TelefonijaBasic telefonija;
		public DetaljiTelefonijaForma()
		{
			InitializeComponent();
		}
		public DetaljiTelefonijaForma(TelefonijaBasic tel)
		{
			InitializeComponent();
			telefonija = tel;
		}

		private void DetaljiTelefonijaForma_Load(object sender, EventArgs e)
		{
			PopuniPodacima();
		}
		public void PopuniPodacima()
		{
			lblId.Text=telefonija.Id.ToString();
			if(telefonija.Brojevi_Telefona.Count>0)
			{
				lblId1.Text = telefonija.Brojevi_Telefona[0].Id.ToString();
				lblBroj1.Text= telefonija.Brojevi_Telefona[0].Broj.ToString();
				lblMinuti1.Text=telefonija.Brojevi_Telefona[0].Potroseni_minuti.ToString();

				if (telefonija.Brojevi_Telefona.Count > 1)
				{
					lblId2.Text = telefonija.Brojevi_Telefona[1].Id.ToString();
					lblBroj2.Text = telefonija.Brojevi_Telefona[1].Broj.ToString();
					lblMinuti2.Text = telefonija.Brojevi_Telefona[1].Potroseni_minuti.ToString();

					if (telefonija.Brojevi_Telefona.Count > 2)
					{
						lblId3.Text = telefonija.Brojevi_Telefona[2].Id.ToString();
						lblBroj3.Text = telefonija.Brojevi_Telefona[2].Broj.ToString();
						lblMinuti3.Text = telefonija.Brojevi_Telefona[2].Potroseni_minuti.ToString();

						if (telefonija.Brojevi_Telefona.Count > 3)
						{
							lblId4.Text = telefonija.Brojevi_Telefona[3].Id.ToString();
							lblBroj4.Text = telefonija.Brojevi_Telefona[3].Broj.ToString();
							lblMinuti4.Text = telefonija.Brojevi_Telefona[3].Potroseni_minuti.ToString();
						}
					}
				}
			}
		}
	}
}
