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
    public partial class Korisnici : Form
    {
        public Korisnici()
        {
            InitializeComponent();
        }

        private void ListaUredjaja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OtvoriObrisiFormuBtn_Click(object sender, EventArgs e)
        {
            if (ListKorisnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika kojeg zelite da promenite");
                return;
            }

            string korisnikJMBG = ListKorisnika.SelectedItems[0].SubItems[0].Text;
            KorisnikBasic korisnikBasic = DTOmanagerM.vratiKorisnikaBasic(korisnikJMBG);

            if (korisnikBasic == null)
            {
                MessageBox.Show("Greska prilikom vracanja selektovanog korisnika");
                return;
            }

            PotvrdiBrisanjeKorisnika potvrdaForma = new PotvrdiBrisanjeKorisnika(korisnikBasic);
            potvrdaForma.ShowDialog();
            this.popuniPodacima();
        }

        private void Korisnici_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ListKorisnika.Items.Clear();
            List<KorisnikPregled> podaci = DTOmanagerM.vratiSveKorisnike();


            foreach(KorisnikPregled k in  podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { k.JMBG, k.Ime, k.Prezime, k.Adresa, k.Broj, k.Grad, k.Tip_korisnika });
                ListKorisnika.Items.Add(item);
            }

            ListKorisnika.Refresh();
        }

        private void OtvoriDodajFormuBtn_Click(object sender, EventArgs e)
        {
            DodajKorisnika formaDodaj = new DodajKorisnika();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void OtvoriIzmeniFormubtn_Click(object sender, EventArgs e)
        {
            if (ListKorisnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika kojeg zelite da promenite");
                return;
            }

            string korisnikJMBG = ListKorisnika.SelectedItems[0].SubItems[0].Text;
            KorisnikBasic ub = DTOmanagerM.vratiKorisnikaBasic(korisnikJMBG);

            if (String.Compare(ub.Tip_korisnika, "Pravno") == 0 || String.Compare(ub.Tip_korisnika, "Pravno lice") == 0 || String.Compare(ub.Tip_korisnika, "Pravno ") == 0)
            {
                IzmeniKorisnikaPravnoLice pravnoForma = new IzmeniKorisnikaPravnoLice(ub);
                pravnoForma.ShowDialog();
                this.popuniPodacima();
            }
            else if (String.Compare(ub.Tip_korisnika, "Fizicko") == 0 || String.Compare(ub.Tip_korisnika, "Fizicko lice") == 0 || String.Compare(ub.Tip_korisnika, "Fizicko ") == 0)
            {
                IzmeniKorisnikaFizickoLice  fizickoForma = new IzmeniKorisnikaFizickoLice(ub);
                fizickoForma.ShowDialog();
                this.popuniPodacima();
            }
            else
                MessageBox.Show("Greska sa pribavljanjem tipa korisnika");

        }

        private void OtvoriDetaljiFormuBtn_Click(object sender, EventArgs e)
        {
            if (ListKorisnika.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika kojeg zelite da vidite detaljnije");
                return;
            }

            string JMBG = ListKorisnika.SelectedItems[0].SubItems[0].Text;
            KorisnikBasic korisnikBasic = DTOmanagerM.vratiKorisnikaBasic(JMBG);

            if (korisnikBasic == null)
            {
                MessageBox.Show("Greska prilikom vracanja selektovanog korisnika");
                return;
            }

            if (String.Compare(korisnikBasic.Tip_korisnika, "Pravno") == 0 || String.Compare(korisnikBasic.Tip_korisnika, "Pravno lice") == 0 || String.Compare(korisnikBasic.Tip_korisnika, "Pravno ") == 0)
            {
                DetaljiOPravnomLicu pravnoForma = new DetaljiOPravnomLicu(korisnikBasic);
                pravnoForma.ShowDialog();
                this.popuniPodacima();
            }
            else if (String.Compare(korisnikBasic.Tip_korisnika, "Fizicko") == 0 || String.Compare(korisnikBasic.Tip_korisnika, "Fizicko lice") == 0 || String.Compare(korisnikBasic.Tip_korisnika, "Fizicko ") == 0)
            {
                DetaljiOFizickomLicu fizickoForma = new DetaljiOFizickomLicu(korisnikBasic);
                fizickoForma.ShowDialog();
                this.popuniPodacima();
            }
            else
                MessageBox.Show("Greska sa pribavljanjem tipa korisnika");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
