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
	public partial class IzmeniDetaljeOstvareniProtok : Form
	{
		OstavreniProtokBasic placanje;
		public IzmeniDetaljeOstvareniProtok()
		{
			InitializeComponent();
		}
		public IzmeniDetaljeOstvareniProtok(OstavreniProtokBasic pl)
		{
			InitializeComponent();
			placanje = pl;
		}

		private void IzmeniDetaljeOstvareniProtok_Load(object sender, EventArgs e)
		{
			PopuniPodacima();
		}
		public void PopuniPodacima()
		{
			numOstvareniProtok.Value = placanje.KolicinaOstavrenogProtoka;
		}

		private void brnsacuvaj_Click(object sender, EventArgs e)
		{
			placanje.KolicinaOstavrenogProtoka = (int)numOstvareniProtok.Value;
			DTOManager.IzmeniOstvareniProtok(placanje);
			Close();
		}
	}
}
