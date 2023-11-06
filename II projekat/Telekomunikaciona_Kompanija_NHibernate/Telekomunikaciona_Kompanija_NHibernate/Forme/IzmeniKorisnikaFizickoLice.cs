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
    public partial class IzmeniKorisnikaFizickoLice : Form
    {

        List<UslugaPregled> dodateUsluge;
        List<UslugaPregled> postojeceUsluge;
        List<TelefonPregled> postojeciTelefoni;
        List<Komunikacioni_cvorBasic> slobodniKC;
        Komunikacioni_cvorBasic zauzetKC;
        Fizicka_licaBasic korisnik_Basic;
        string jmbg;
        public IzmeniKorisnikaFizickoLice(KorisnikBasic ub)
        {
            InitializeComponent();
            StariBrojCB.Items.Clear();
            IDUslugeCB.Items.Clear();
            OtkaziUsluguCB.Items.Clear();
            OdveziKCCB.Items.Clear();
            SerBrKCCB.Items.Clear();
            dodateUsluge = new List<UslugaPregled>();
            postojeceUsluge = new List<UslugaPregled>();
            postojeciTelefoni = new List<TelefonPregled>();
            slobodniKC = new List<Komunikacioni_cvorBasic>();
            zauzetKC = new Komunikacioni_cvorBasic();
            jmbg = ub.JMBG;
            Fizicka_licaBasic lice = DTOmanagerM.vratiFizickoLiceBasic(ub.JMBG);

            korisnik_Basic = lice;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ImeTB.Text = korisnik_Basic.Ime;
            PrezimeTB.Text = korisnik_Basic.Prezime;
            AdresaTB.Text = korisnik_Basic.Adresa;
            GradTB.Text = korisnik_Basic.Grad;
            BrojNum.Value = decimal.Parse(korisnik_Basic.Broj);


            
            List<Komunikacioni_cvorBasic> kc = DTOmanagerM.vratiKomCvorove();

            foreach (Komunikacioni_cvorBasic k in kc)
            {
                SerBrKCCB.Items.Add(k.Serijski_broj);
                slobodniKC.Add(k);
            }

            Komunikacioni_cvorBasic kom = DTOmanagerM.vratiKCKorisnikaBasic(korisnik_Basic.JMBG);

            OdveziKCCB.Items.Add(kom.Serijski_broj);
            zauzetKC = kom;

            List<UslugaBasic> usluge = DTOmanagerM.vratiUslugeBasic();

            foreach (UslugaBasic u in usluge)
            {
                IDUslugeCB.Items.Add(u.Id);
            }

            List<UslugaPregled> uslugeKorisnika = DTOmanagerM.vratiUslugeKorisnika(korisnik_Basic.JMBG);

            foreach (UslugaPregled k in uslugeKorisnika)
            {
                OtkaziUsluguCB.Items.Add(k.Id);
                postojeceUsluge.Add(k);

            }

            List<TelefonPregled> telefoni = DTOmanagerM.vratiTelefoneKorisnika(korisnik_Basic.JMBG);

            foreach (TelefonPregled t in telefoni)
            {
                StariBrojCB.Items.Add(t.telefon);
                postojeciTelefoni.Add(t);
            }
        }

        private void IDUslugeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IzmeniKorisnikaFizickoLice_Load(object sender, EventArgs e)
        {

        }

        private void PoveziKCCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (PoveziKCCheckB.Checked)
            {
                SerBrKCCB.Visible=true;
                UnosSerBrKomCvLabel.Visible=true;
                PoveziKomCvorBtn.Visible=true;
            }
            if(!PoveziKCCheckB.Checked)
            {
                SerBrKCCB.Visible = false;
                UnosSerBrKomCvLabel.Visible = false;
                PoveziKomCvorBtn.Visible = false;
            }
        }

        private void OdveziKCCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (OdveziKCCheckB.Checked)
            {
                OdveziKCCB.Visible=true;
                OvezivanjeUnosSerBrKomCvLabel.Visible = true;
                OdveziKomunikacioniCvorBtn.Visible=true;
            }
            if(!OdveziKCCheckB.Checked)
            {
                OdveziKCCB.Visible = false;
                OvezivanjeUnosSerBrKomCvLabel.Visible = false;
                OdveziKomunikacioniCvorBtn.Visible = false;
            }
        }

        private void DodajUsluguCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if(DodajUsluguCheckB.Checked) 
            {
                IDUslugeCB.Visible=true;
                DodajIDLabel.Visible=true;
                DodajUsluguBtn.Visible=true;
            }
            if (!DodajUsluguCheckB.Checked)
            {
                IDUslugeCB.Visible = false;
                DodajIDLabel.Visible = false;
                DodajUsluguBtn.Visible = false;
            }
        }

        private void OtkaziUsluguCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (OtkaziUsluguCheckB.Checked)
            {
                OtkaziUsluguCB.Visible=true;
                OtkaziIDLabel.Visible=true;
                OtkaziUsluguBtn.Visible=true;
            }
            if (!OtkaziUsluguCheckB.Checked)
            {
                OtkaziUsluguCB.Visible = false;
                OtkaziIDLabel.Visible = false;
                OtkaziUsluguBtn.Visible = false;
            }
        }

        private void PromeniTelefonCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (PromeniTelefonCheckB.Checked)
            {
                PromeniTelefonGB.Visible=true;
            }
            if (!PromeniTelefonCheckB.Checked)
            {
                PromeniTelefonGB.Visible=false;
            }
        }

        private void PoveziKomCvorBtn_Click(object sender, EventArgs e)
        {
            if (OdveziKCCB.Items.Count != 0)
            {
                MessageBox.Show("Morate prvo da se odvezete sa trenutnog komunikacionog cvora");
                return;
            }

            Komunikacioni_cvorBasic kc = DTOmanagerM.vratiKCBasic(long.Parse(SerBrKCCB.SelectedItem.ToString()));

            if (kc == null)
            {
                MessageBox.Show("Morate da odaberete komunikacioni cvor");
                return;
            }
            SerBrKCCB.Items.Remove(SerBrKCCB.SelectedItem);
            OdveziKCCB.Items.Add(kc.Serijski_broj);
            zauzetKC = kc;

            if (OdveziKCCB.Items.Count == 1)
            {


                Komunikacioni_cvorBasic kom = DTOmanagerM.vratiKCBasic(long.Parse(OdveziKCCB.Items[0].ToString()));
                DTOmanagerM.promeniKCKorisniku(jmbg, kom);

            }
            else
            {
                MessageBox.Show("Korisnik mora biti povezan na 1 komunikacioni cvor");
                return;
            }
        }

        private void OdveziKomunikacioniCvorBtn_Click(object sender, EventArgs e)
        {
            if (OdveziKCCB.Items.Count == 1)
            {
                zauzetKC = null;
                slobodniKC.Add(DTOmanagerM.vratiKCBasic(long.Parse(OdveziKCCB.SelectedItem.ToString())));
                SerBrKCCB.Items.Add(OdveziKCCB.SelectedItem.ToString());
                OdveziKCCB.Items.Clear();
                OdveziKCCB.Text = null;
            }
            else
            {
                MessageBox.Show("Morate da selektujete komunikacioni cvor");
                return;
            }
        }

        private void DodajUsluguBtn_Click(object sender, EventArgs e)
        {
            UslugaPregled usluga = DTOmanagerM.vratiUslugu(int.Parse(IDUslugeCB.SelectedItem.ToString()));

            dodateUsluge.Add(usluga);

            DTOmanagerM.dodeliUsluguKorisniku(usluga, jmbg);

            IDUslugeCB.Items.Remove(IDUslugeCB.SelectedItem);
            OtkaziUsluguCB.Items.Add(usluga.Id);

            MessageBox.Show("Dodali ste uslugu");
        }

        private void OtkaziUsluguBtn_Click(object sender, EventArgs e)
        {
            UslugaPregled usluga = DTOmanagerM.vratiUslugu(int.Parse(OtkaziUsluguCB.SelectedItem.ToString()));

            DTOmanagerM.otkaziUsluguKorisniku(usluga, jmbg);

            postojeceUsluge.Remove(usluga);
            OtkaziUsluguCB.Items.Remove(OtkaziUsluguCB.SelectedItem);
            IDUslugeCB.Items.Add(usluga.Id);

            MessageBox.Show("Uspesno uklonjena usluga");
        }

        private void PromeniTelefonBtn_Click(object sender, EventArgs e)
        {
            if (StariBrojCB.SelectedIndex > -1)
            {

                if (String.IsNullOrEmpty(NoviBrojTB.Text) || String.IsNullOrWhiteSpace(NoviBrojTB.Text))
                {
                    MessageBox.Show("Morate uneti novi broj telefona");
                    return;
                }

                DTOmanagerM.promeniTelefon(NoviBrojTB.Text, StariBrojCB.SelectedItem.ToString());

                foreach (TelefonPregled t in postojeciTelefoni)
                {
                    if (t.telefon == long.Parse(StariBrojCB.SelectedItem.ToString()))
                    {
                        t.telefon = long.Parse(NoviBrojTB.Text);
                    }
                }

                StariBrojCB.Items.Clear();

                foreach (TelefonPregled t in postojeciTelefoni)
                {
                    StariBrojCB.Items.Add(t.telefon);
                }


                NoviBrojTB.Clear();
                MessageBox.Show("Uspesno promenjen broj telefona");
                return;
            }
            else
            {
                MessageBox.Show("Odaberite telefon koji zelite da promenite");
                return;
            }
        }

        private void DodajTelefonBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NoviBrojTB.Text) || String.IsNullOrWhiteSpace(NoviBrojTB.Text))
            {
                MessageBox.Show("Morate uneti novi broj telefona");
                return;
            }

            if (NoviBrojTB.Text.Length != 9)
            {
                MessageBox.Show("Telefon mora imati 9 cifara, nulu ne pisete");
                return;
            }

            DTOmanagerM.kreirajTelefonIDodeliKorisniku(NoviBrojTB.Text, korisnik_Basic.JMBG);

            StariBrojCB.Items.Clear();

            List<TelefonPregled> telefoni = DTOmanagerM.vratiTelefoneKorisnika(korisnik_Basic.JMBG);
            postojeciTelefoni.Clear();
            foreach (TelefonPregled t in telefoni)
            {
                StariBrojCB.Items.Add(t.telefon);
                postojeciTelefoni.Add(t);
            }

            NoviBrojTB.Clear();
            MessageBox.Show("Uspesno dodat novi broj telefona");
            return;
        }

        private void GotovoBtn_Click(object sender, EventArgs e)
        {

            if (OdveziKCCB.Items.Count == 0)
            {
                MessageBox.Show("Korisnik mora biti povezan na komunikacioni cvor");
                return;
            }
            else
                this.Close();
        }

        private void SacuvajBtn_Click(object sender, EventArgs e)
        {
            List<KorisnikPregled> korisnici = DTOmanagerM.vratiSveKorisnike();


            if (String.Compare(ImeTB.Text, korisnik_Basic.Ime) != 0 && !String.IsNullOrEmpty(ImeTB.Text) && !String.IsNullOrWhiteSpace(ImeTB.Text))
            {
                korisnik_Basic.Ime = ImeTB.Text;
            }

            if (String.Compare(PrezimeTB.Text, korisnik_Basic.Prezime) != 0 && !String.IsNullOrEmpty(PrezimeTB.Text) && !String.IsNullOrWhiteSpace(PrezimeTB.Text))
            {
                korisnik_Basic.Prezime = PrezimeTB.Text;
            }

            if (String.Compare(AdresaTB.Text, korisnik_Basic.Adresa) != 0 && !String.IsNullOrEmpty(AdresaTB.Text) && !String.IsNullOrWhiteSpace(AdresaTB.Text))
            {
                korisnik_Basic.Adresa = AdresaTB.Text;
            }

            if (String.Compare(GradTB.Text, korisnik_Basic.Grad) != 0 && !String.IsNullOrEmpty(GradTB.Text) && !String.IsNullOrWhiteSpace(GradTB.Text))
            {
                korisnik_Basic.Grad = GradTB.Text;
            }

            DTOmanagerM.promeniKorisnikaFizickoLice(korisnik_Basic);

            MessageBox.Show("Uspesno promenjen korisnik");

            if (OdveziKCCB.Items.Count == 0)
            {
                MessageBox.Show("Korisnik mora biti povezan na komunikacioni cvor");
                return;
            }
            else
                this.Close();
        }
    }
}
