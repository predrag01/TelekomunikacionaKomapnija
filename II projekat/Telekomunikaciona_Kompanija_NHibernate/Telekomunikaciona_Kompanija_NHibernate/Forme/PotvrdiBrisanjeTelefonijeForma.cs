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
	public partial class PotvrdiBrisanjeTelefonijeForma : Form
	{
		int id;
		string poruka;
		public PotvrdiBrisanjeTelefonijeForma()
		{
			InitializeComponent();
		}
		public PotvrdiBrisanjeTelefonijeForma(string p, int i)
		{
			InitializeComponent();
			poruka = p;
			id = i;
		}

		private void btnDa_Click(object sender, EventArgs e)
		{
			DTOManager.ObrisiTelefoniju(id);
			Close();
		}

		private void PotvrdiBrisanjeTelefonijeForma_Load(object sender, EventArgs e)
		{
			lblPoruka.Text = poruka;
		}

		private void btnNe_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
