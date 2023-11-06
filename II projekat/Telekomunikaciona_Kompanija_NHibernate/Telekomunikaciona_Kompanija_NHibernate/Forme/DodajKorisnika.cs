using NHibernate.Mapping;
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
    public partial class DodajKorisnika : Form
    {
        Pravna_licaBasic pravnoLice;
        Fizicka_licaBasic fizickoLice;
        List<UslugaPregled> dodateUsluge;
        public DodajKorisnika()
        {
            InitializeComponent();
            pravnoLice = new Pravna_licaBasic();
            fizickoLice = new Fizicka_licaBasic();
            dodateUsluge = new List<UslugaPregled>();
        }

        private void DodajKorisnika_Load(object sender, EventArgs e)
        {
            TipKorisnikaCB.Items.Add("Pravno lice");
            TipKorisnikaCB.Items.Add("Fizicko lice");

            List<UslugaPregled> usluge = DTOmanagerM.vratiUsluge();

            foreach (UslugaPregled u in usluge)
            {
                IDUslugeCB.Items.Add(u.Id);
            }

            List<Komunikacioni_cvorBasic> kc = DTOmanagerM.vratiKomCvorove();

        
            foreach (Komunikacioni_cvorBasic k in kc)
            {
                SerBrKCCB.Items.Add(k.Serijski_broj);
            }
        }

        private void TipKorisnikaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipKorisnikaCB.SelectedIndex == 0)
            {
                PravnoLiceGB.Visible = true;
            }
            if (TipKorisnikaCB.SelectedIndex == 1)
            {
                PravnoLiceGB.Visible = false;
            }
        }

        private void PoveziKCCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if(PoveziKCCheckB.Checked == true)
            {
                SerBrKCCB.Visible = true;
                UnosSerBrKomCvLabel.Visible = true;
            }
            if(PoveziKCCheckB.Checked != true)
            {
                SerBrKCCB.Visible = false;
                UnosSerBrKomCvLabel.Visible = false;
            }
        }

        private void DodajUsluguCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if(DodajUsluguCheckB.Checked == true)
            {
                IDUslugeCB.Visible = true;
                DodajIDLabel.Visible = true;
                DodajUsluguBtn.Visible = true;
                DodajUsluguBtn.Enabled = true;
            }
            if (DodajUsluguCheckB.Checked != true)
            {
                IDUslugeCB.Visible = false;
                DodajIDLabel.Visible = false;
                DodajUsluguBtn.Visible = false;
                DodajUsluguBtn.Enabled = false;
            }
        }

        private void DodajTelefoneBtn_Click(object sender, EventArgs e)
        {
            if(BrojTelefonaTB.Text!=null && String.IsNullOrEmpty(BrojTelefonaTB.Text) && String.IsNullOrWhiteSpace(BrojTelefonaTB.Text) && BrojTelefonaTB.Text.Length < 10)
            {
                MessageBox.Show("Greska sa dodavanjem broja telefona. Broj mora imati bar 10 cifara");
                return;
            }
            else
            {
                BrojeviTelefonaLB.Items.Add(BrojTelefonaTB.Text);
                BrojTelefonaTB.Text = "";
            }
        }

        private void BrojTelefonaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PoveziKomCvorBtn_Click(object sender, EventArgs e)
        {

        }

        private void DodajUsluguBtn_Click(object sender, EventArgs e)
        {
            dodateUsluge.Add(DTOmanagerM.vratiUslugu(int.Parse(IDUslugeCB.SelectedItem.ToString())));
            MessageBox.Show($"Uspesno dodata usluga: {IDUslugeCB.SelectedItem}");
            return;
        }

        private void UkloniTelefonBtn_Click(object sender, EventArgs e)
        {
            if (BrojeviTelefonaLB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite telefon koji zelite da uklonite");
                return;
            }

            for(int i=BrojeviTelefonaLB.SelectedItems.Count-1; i>=0; i--)
            {
                BrojeviTelefonaLB.Items.Remove(BrojeviTelefonaLB.Items[i]);
                MessageBox.Show("Uspesno ukolonjen broj");
            }
        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            if (TipKorisnikaCB.SelectedIndex == 0)
            {
                if (PoreskiBrojNum.Value == 0)
                {
                    MessageBox.Show("Ne moze pib biti 0");
                    return;
                }
                if(BrojFaksaNum.Value == 0)
                {
                    MessageBox.Show("Ne moze broj faksa biti 0");
                    return;
                }
                if(String.IsNullOrEmpty(ImeKontaktOsobeTB.Text) || String.IsNullOrWhiteSpace(ImeKontaktOsobeTB.Text))
                {
                    MessageBox.Show("Morate uneti ime kontakt osobe");
                    return;
                }

                this.pravnoLice.Poreski_identifikacioni_broj =(long) PoreskiBrojNum.Value;
                this.pravnoLice.Broj_faksa =(long)BrojFaksaNum.Value;
                this.pravnoLice.Ime_kontakt_osobe = ImeKontaktOsobeTB.Text;

            }
                if(String.IsNullOrEmpty(ImeTB.Text) || String.IsNullOrWhiteSpace(ImeTB.Text))
                {
                    MessageBox.Show("Morate uneti ime osobe");
                    return;
                }

                if (String.IsNullOrEmpty(PrezimeTB.Text) || String.IsNullOrWhiteSpace(PrezimeTB.Text))
                {
                    MessageBox.Show("Morate uneti prezime osobe");
                    return;
                }

                if (String.IsNullOrEmpty(AdresaTB.Text) || String.IsNullOrWhiteSpace(AdresaTB.Text))
                {
                    MessageBox.Show("Morate uneti adresu osobe");
                    return;
                }
                if (String.IsNullOrEmpty(GradTB.Text) || String.IsNullOrWhiteSpace(GradTB.Text))
                {
                    MessageBox.Show("Morate uneti grad osobe");
                    return;
                }

                if (String.IsNullOrEmpty(BrojTB.Text) || String.IsNullOrWhiteSpace(BrojTB.Text))
                {
                    MessageBox.Show("Morate uneti broj adrese osobe");
                    return;
                }
        
            if (String.IsNullOrEmpty(JMBGTB.Text) || String.IsNullOrWhiteSpace(JMBGTB.Text))
            {
                MessageBox.Show("Morate uneti JMBG osobe");
                return;
            }

            if (JMBGTB.Text.Length != 13)
            {
                MessageBox.Show("JMBG korisnika mora biti duzine tacno 13");
                return;
            }

            List<KorisnikPregled> korisnici = DTOmanagerM.vratiSveKorisnike();

            foreach(KorisnikPregled k in korisnici)
            {
                if(String.Compare(k.JMBG,JMBGTB.Text)==0)
                {
                    MessageBox.Show("Taj JMBG vec postoji");
                    return;
                }
            }

                List<KorisnikPregled> korisniciKCa = DTOmanagerM.vratiKorisnikeKC(long.Parse(SerBrKCCB.SelectedItem.ToString()));

                if (korisniciKCa.Count-1==1000)
                {
                    MessageBox.Show("Na zalost, taj komunikacioni cvor je prepun, odaberite drugi");
                    return;
                }

            List<TelefonPregled> telefoni = DTOmanagerM.vratiTelefone();

            if (BrojeviTelefonaLB.Items.Count > 0)
            {
                foreach (TelefonPregled t in telefoni)
                {
                    foreach (var broj in BrojeviTelefonaLB.Items)
                    {
                        if (long.Parse(broj.ToString()) == t.telefon)
                        {
                            MessageBox.Show($"Na zalost broj {broj} je vec zauzet");
                            return;
                        }
                    }
                }
            }

            this.pravnoLice.Ime = ImeTB.Text;
            this.pravnoLice.Prezime=PrezimeTB.Text;
            this.pravnoLice.Adresa=AdresaTB.Text;
            this.pravnoLice.Broj=BrojTB.Text;
            this.pravnoLice.JMBG=JMBGTB.Text;
            this.pravnoLice.Grad=GradTB.Text;
            this.pravnoLice.Tip_korisnika = "Pravno lice";
            this.pravnoLice.Kom_cvor = DTOmanagerM.vratiKCBasic(long.Parse(SerBrKCCB.SelectedItem.ToString()));

            this.fizickoLice.Ime = ImeTB.Text;
            this.fizickoLice.Prezime = PrezimeTB.Text;
            this.fizickoLice.Broj = BrojTB.Text;
            this.fizickoLice.JMBG = JMBGTB.Text;
            this.fizickoLice.Grad = GradTB.Text;
            this.fizickoLice.Adresa = AdresaTB.Text;
            this.fizickoLice.Tip_korisnika = "Fizicko lice";
            this.fizickoLice.Kom_cvor = DTOmanagerM.vratiKCBasic(long.Parse(SerBrKCCB.SelectedItem.ToString()));


            if (TipKorisnikaCB.SelectedIndex == 0)
            {
                DTOmanagerM.dodajPravnoLice(pravnoLice);
            }
            else
            {
                DTOmanagerM.dodajFizickoLice(fizickoLice);
            }

            //dodaj ovde za dodavanje telefona i usluge

            foreach(var t in BrojeviTelefonaLB.Items)
            {
                DTOmanagerM.kreirajTelefonIDodeliKorisniku(t.ToString(),JMBGTB.Text);
            }

            foreach(UslugaPregled usluga in dodateUsluge)
            {
                DTOmanagerM.dodeliUsluguKorisniku(usluga,JMBGTB.Text);
            }

            MessageBox.Show("Uspesno dodat korisnik");

            this.Close();
        }
    }
}
