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
    public partial class TelevizijaForma : Form
    {
        public TelevizijaForma()
        {
            InitializeComponent();
        }

        private void TelevizijaForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            televizije.Items.Clear();
            List<TelevizijaPregled> podaci = DTOManager.VratiTelevizije();

            foreach (TelevizijaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.TipUsluge, p.Paket});
                televizije.Items.Add(item);
            }
            televizije.Refresh();
        }

        private void btnDodajTeleviziju_Click(object sender, EventArgs e)
        {
            DodajTelevizijuForma forma = new DodajTelevizijuForma();
            forma.ShowDialog();
            PopuniPodacima();
        }

        private void btnIzmeniTeleviziju_Click(object sender, EventArgs e)
        {
            if (televizije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite televiziju cije podatke zelite da izmenite!");
                return;
            }

            int id = Int32.Parse(televizije.SelectedItems[0].SubItems[0].Text);
            TelevizijaBasic televizja = DTOManager.VratiTeleviziju(id);
            IzmeniTelevizijuForma forma = new IzmeniTelevizijuForma(televizja);
            forma.ShowDialog();
            PopuniPodacima();
        }

        private void btnObrisiTeleviziju_Click(object sender, EventArgs e)
        {
            if (televizije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite televiziju koje zelite da obrisete!");
                return;
            }

            int id = Int32.Parse(televizije.SelectedItems[0].SubItems[0].Text);
			PotvrdiBrisanjeTelevizijeForma forma = new PotvrdiBrisanjeTelevizijeForma("Da li ste sigurni da zelite da obriste televiziju?", id);
			forma.ShowDialog();
			PopuniPodacima();
		}

        private void btnDodatniPaket_Click(object sender, EventArgs e)
        {
            if (televizije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite televiziju cije dodatne pakete zelite da vidite!");
                return;
            }

            int id = Int32.Parse(televizije.SelectedItems[0].SubItems[0].Text);
            TelevizijaBasic paketi = DTOManager.VratiTeleviziju(id);
            PregledDodatnihPaketaTelevizijeForma forma = new PregledDodatnihPaketaTelevizijeForma(paketi);
            forma.ShowDialog();
            PopuniPodacima();
        }
    }
}
