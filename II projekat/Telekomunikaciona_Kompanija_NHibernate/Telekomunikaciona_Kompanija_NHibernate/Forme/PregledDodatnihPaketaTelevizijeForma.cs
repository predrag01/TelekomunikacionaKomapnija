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
    public partial class PregledDodatnihPaketaTelevizijeForma : Form
    {
        TelevizijaBasic televizija;
        public PregledDodatnihPaketaTelevizijeForma()
        {
            InitializeComponent();
        }
        public PregledDodatnihPaketaTelevizijeForma(TelevizijaBasic tel)
        {
            InitializeComponent();
            televizija=tel;
        }

        private void PregledDodatnihPaketaTelevizijeForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            dodatniPaketi.Items.Clear();
            List<DodatniPaketKanalaPregled> podaci = DTOManager.VratiDodatnePakete(televizija.Id);

            foreach (DodatniPaketKanalaPregled p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.DodatniPaket});
                dodatniPaketi.Items.Add(item);
            }
            dodatniPaketi.Refresh();
        }

        private void btnDodajDodatniPaket_Click(object sender, EventArgs e)
        {
            DodajDodatniPaketForma forma = new DodajDodatniPaketForma(televizija);
            forma.ShowDialog();
            PopuniPodacima();
        }

        private void btnIzmenidodatniPaket_Click(object sender, EventArgs e)
        {
            if (dodatniPaketi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite paket cije podatke zelite da izmenite!");
                return;
            }

            int id = Int32.Parse(dodatniPaketi.SelectedItems[0].SubItems[0].Text);
            DodatniPaketKanalaBasic dodatni = DTOManager.VratiDodatniPaket(id);
            IzmeniDodatniPaketForma forma = new IzmeniDodatniPaketForma(dodatni, televizija);
            forma.ShowDialog();
            PopuniPodacima();
        }

        private void btnObrisiDodatniPaket_Click(object sender, EventArgs e)
        {
            if (dodatniPaketi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite paket koji zelite da obrisete!");
                return;
            }

            int id = Int32.Parse(dodatniPaketi.SelectedItems[0].SubItems[0].Text);
			PotvdraBrisanjaDodatnogPaketaForma forma =new PotvdraBrisanjaDodatnogPaketaForma("Da li ste sigurni da zelite da obriste paket?", id);
			forma.ShowDialog();
			PopuniPodacima();

		}
    }
}
