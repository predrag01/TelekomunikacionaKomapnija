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
	public partial class DetaljiOstvareniPtotokForma : Form
	{
		OstavreniProtokBasic placanje;
		public DetaljiOstvareniPtotokForma()
		{
			InitializeComponent();
		}
		public DetaljiOstvareniPtotokForma(OstavreniProtokBasic pl)
		{
			InitializeComponent();
			placanje = pl;
		}

		private void DetaljiOstvareniPtotokForma_Load(object sender, EventArgs e)
		{
			PopuniPodacima();
		}

		public void PopuniPodacima()
		{
			lblProtok.Text = placanje.KolicinaOstavrenogProtoka.ToString();
		}

		private void brnIzmeni_Click(object sender, EventArgs e)
		{
			IzmeniDetaljeOstvareniProtok forma =new IzmeniDetaljeOstvareniProtok(placanje);
			forma.ShowDialog();
			PopuniPodacima();
		}
	}
}
