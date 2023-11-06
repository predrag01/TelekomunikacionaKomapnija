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
	public partial class PotvrdiBrisanjeInternetaForma : Form
	{
		string poruka;
		int id;
		public PotvrdiBrisanjeInternetaForma()
		{
			InitializeComponent();
		}
		public PotvrdiBrisanjeInternetaForma(string p, int i)
		{
			InitializeComponent();
			poruka = p;
			id = i;
		}

		private void PotvrdiBrisanjeForma_Load(object sender, EventArgs e)
		{
			lblPoruka.Text = poruka;
		}

		private void btnDa_Click(object sender, EventArgs e)
		{
			DTOManager.ObrisiInternet(id);
			Close();
		}

		private void btnNe_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
