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
	public partial class PotvdraBrisanjaDodatnogPaketaForma : Form
	{
		int id;
		string poruka;
		public PotvdraBrisanjaDodatnogPaketaForma()
		{
			InitializeComponent();
		}
		public PotvdraBrisanjaDodatnogPaketaForma(string p, int i)
		{
			InitializeComponent();
			poruka = p;
			id = i;
		}

		private void PotvdraBrisanjaDodatnogPaketaForma_Load(object sender, EventArgs e)
		{
			lblPoruka.Text = poruka;
		}

		private void btnDa_Click(object sender, EventArgs e)
		{
			DTOManager.ObrisiDodatniPaketKanala(id);
			Close();
		}

		private void btnNe_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
