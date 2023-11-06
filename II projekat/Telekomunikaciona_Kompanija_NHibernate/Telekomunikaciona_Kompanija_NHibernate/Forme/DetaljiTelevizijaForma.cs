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
	public partial class DetaljiTelevizijaForma : Form
	{
		TelevizijaBasic televizija;
		public DetaljiTelevizijaForma()
		{
			InitializeComponent();
		}
		public DetaljiTelevizijaForma(TelevizijaBasic te)
		{
			InitializeComponent();
			televizija= te;
		}

		private void DetaljiTelevizijaForma_Load(object sender, EventArgs e)
		{
			PopuniPodacima();
		}

		public void PopuniPodacima()
		{
			lblId.Text=televizija.Id.ToString();
			lblPaket.Text=televizija.Paket;
			if(televizija.DodatniPaketiKanala.Count > 0 )
			{
				foreach(DodatniPaketKanalaBasic p in televizija.DodatniPaketiKanala)
				{
					ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.DodatniPaket});
					dodatniPaketi.Items.Add(item);
				}
				dodatniPaketi.Refresh();
			}
		}
	}
}
