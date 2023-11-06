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
    public partial class IzmeniUredjajKomunikacioniCvor : Form
    {
        Komunikacioni_cvorBasic komCvor_Basic;
        List<Glavna_stanicaPregled> slobodneGS;
        Glavna_stanicaPregled povezanaGS;
        List<KorisnikPregled> slobodniKorisnici;
        List<KorisnikPregled> zauzetiKorisnici;
        public IzmeniUredjajKomunikacioniCvor()
        {
            InitializeComponent();
        }

        public IzmeniUredjajKomunikacioniCvor(UredjajBasic ub)
        {
            InitializeComponent();
            slobodneGS = new List<Glavna_stanicaPregled>();
            povezanaGS = new Glavna_stanicaPregled();
            slobodniKorisnici = new List<KorisnikPregled>();
            zauzetiKorisnici = new List<KorisnikPregled>();

            Komunikacioni_cvorBasic kc = DTOmanagerM.vratiKCBasic(ub.Serijski_broj);
            komCvor_Basic = kc;

            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ProizvodjacGSTB.Text = komCvor_Basic.Proizvodjac;
            AdresaTB.Text = komCvor_Basic.Adresa;
            BrojLokacijeNum.Value = komCvor_Basic.Broj_lokacije;
            DatumPocGSDate.Value = komCvor_Basic.Datum_pocetka_upotrebe;
            RazlogServisaGSBox.Text = komCvor_Basic.Razlog_poslednjeg_servisa;
            OpisTB.Text = komCvor_Basic.Opis;

            List<Glavna_stanicaPregled> stanice = DTOmanagerM.vratiGlavneStanice();
            foreach (Glavna_stanicaPregled g in stanice)
            {
                SerBrGSCB.Items.Add(g.Serijski_broj);
                slobodneGS.Add(g);
            }
            povezanaGS = DTOmanagerM.vratiGlavnuStanicuKC(komCvor_Basic.Serijski_broj);
            OdveziSerBrGSCB.Items.Add(povezanaGS.Serijski_broj);

            List<KorisnikPregled> korisnici = DTOmanagerM.vratiSveKorisnike();
            foreach (KorisnikPregled k in korisnici)
            {
                JMBGCB.Items.Add(k.JMBG);
                slobodniKorisnici.Add(k);
            }

            List<KorisnikPregled> korisnik = DTOmanagerM.vratiKorisnikeKC(komCvor_Basic.Serijski_broj);
            foreach (KorisnikPregled k in korisnik)
            {
                UkloniJMBGCB.Items.Add(k.JMBG);
                zauzetiKorisnici.Add(k);
            }
        }

        private void PoveziNaGSCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (PoveziNaGSCheckB.Checked)
            {
                SerBrGSCB.Visible = true;
                UnosSerGlanveStaniceLabel.Visible = true;
                PoveziGlavnuStanicuBtn.Visible = true;
                PoveziGlavnuStanicuBtn.Enabled = true;
            }
            if (!PoveziNaGSCheckB.Checked)
            {
                SerBrGSCB.Visible = false;
                UnosSerGlanveStaniceLabel.Visible = false;
                PoveziGlavnuStanicuBtn.Visible = false;
                PoveziGlavnuStanicuBtn.Enabled = false;
            }
        }

        private void OdveziGSCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (OdveziGSCheckB.Checked)
            {
                OdveziSerBrGSCB.Visible = true;
                label1.Visible = true;
                OdveziGlavnuStanicuBtn.Visible = true;
                OdveziGlavnuStanicuBtn.Enabled = true;
            }
            if (!OdveziGSCheckB.Checked)
            {
                OdveziSerBrGSCB.Visible = false;
                label1.Visible = false;
                OdveziGlavnuStanicuBtn.Visible = false;
                OdveziGlavnuStanicuBtn.Enabled = false;
            }
        }

        private void DodajKorisnikaCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (DodajKorisnikaCheckB.Checked)
            {
                JMBGCB.Visible = true;
                UnosJMBGLabel.Visible = true;
                DodajKorisnikaBtn.Visible = true;
                DodajKorisnikaBtn.Enabled = true;
            }
            if (!DodajKorisnikaCheckB.Checked)
            {
                JMBGCB.Visible = false;
                UnosJMBGLabel.Visible = false;
                DodajKorisnikaBtn.Visible = false;
                DodajKorisnikaBtn.Enabled = false;
            }
        }

        private void UkloniKorisnikaCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (UkloniKorisnikaCheckB.Checked)
            {
                UkloniJMBGCB.Visible = true;
                label2.Visible = true;
                UkloniKorisnikaBtn.Visible = true;
                UkloniKorisnikaBtn.Enabled = true;
            }
            if (!UkloniKorisnikaCheckB.Checked)
            {
                UkloniJMBGCB.Visible = false;
                label2.Visible = false;
                UkloniKorisnikaBtn.Visible = false;
                UkloniKorisnikaBtn.Enabled = false;
            }
        }

        private void Gotovo_Click(object sender, EventArgs e)
        {
            if (OdveziSerBrGSCB.Items.Count != 1)
            {
                MessageBox.Show("Komunikacioni cvor mora biti povezan na tacno 1 stanicu");
                return;
            }
            this.Close();
        }

        private void DodajKorisnikaBtn_Click(object sender, EventArgs e)
        {
            if (JMBGCB.SelectedIndex > -1)
            {
                if (zauzetiKorisnici.Count - 1 == 1000)
                {
                    MessageBox.Show("Vec je popunjen taj komunikacioni cvor sa korisnicima.");
                    return;
                }

                KorisnikPregled korisnik = DTOmanagerM.vratiKorisnika(JMBGCB.SelectedItem.ToString());
                zauzetiKorisnici.Add(korisnik);
                slobodniKorisnici.Remove(korisnik);
                UkloniJMBGCB.Items.Add(korisnik.JMBG);
                JMBGCB.Items.Remove(JMBGCB.SelectedItem);
                JMBGCB.Text = null; 

                DTOmanagerM.dodajKorisnikaKCu(korisnik.JMBG, komCvor_Basic.Serijski_broj);

                MessageBox.Show("Uspesno dodat korisnik");

            }
            else
            {
                MessageBox.Show("Odaberite jmbg korisnika");
                return;
            }
        }

        private void UkloniKorisnikaBtn_Click(object sender, EventArgs e)
        {
            if (UkloniJMBGCB.SelectedIndex > -1)
            {
                KorisnikPregled korisnik = DTOmanagerM.vratiKorisnika(UkloniJMBGCB.SelectedItem.ToString());

                zauzetiKorisnici.Remove(korisnik);
                slobodniKorisnici.Add(korisnik);
                UkloniJMBGCB.Items.Remove(UkloniJMBGCB.SelectedItem);
                UkloniJMBGCB.Text = null;
                JMBGCB.Items.Add(korisnik.JMBG);

                ZaPromenuKomCvora promena = new ZaPromenuKomCvora(korisnik);
                promena.ShowDialog();

                MessageBox.Show("Uspesno uklonjen korisnik");
            }
            else
            {
                MessageBox.Show("Odaberite jmbg korisnika");
                return;
            }
        }

        private void PoveziGlavnuStanicuBtn_Click(object sender, EventArgs e)
        {

            if (OdveziSerBrGSCB.Items.Count != 0)
            {
                MessageBox.Show("Morate prvo da odvezete glavnu stanicu da bi ste povezali drugu");
                return;
            }

            if (SerBrGSCB.SelectedIndex > -1)
            {
                Glavna_stanicaPregled gs = DTOmanagerM.vratiGSPregled(long.Parse(SerBrGSCB.SelectedItem.ToString()));
                SerBrGSCB.Items.Remove(SerBrGSCB.SelectedItem);
                OdveziSerBrGSCB.Items.Add(gs.Serijski_broj);
                slobodneGS.Remove(gs);
                povezanaGS = gs;

                if (OdveziSerBrGSCB.Items.Count == 1)
                {
                    Glavna_stanicaPregled g = DTOmanagerM.vratiGSPregled(long.Parse(OdveziSerBrGSCB.Items[0].ToString()));
                    DTOmanagerM.promeniGSKCa(g.Serijski_broj,komCvor_Basic.Serijski_broj);
                }
                else
                {
                    MessageBox.Show("Komunikacioni cvor moze imati samo 1 glavnu stanicu");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Morate da odaberete glavnu stanicu na koju zelite da se povezete");
                return;
            }
        }

        private void OdveziGlavnuStanicuBtn_Click(object sender, EventArgs e)
        {
            if (OdveziSerBrGSCB.SelectedIndex > -1)
            {

                Glavna_stanicaPregled gs = DTOmanagerM.vratiGSPregled(long.Parse(OdveziSerBrGSCB.SelectedItem.ToString()));

                povezanaGS = null;
                slobodneGS.Add(gs);
                SerBrGSCB.Items.Add(gs.Serijski_broj);
                OdveziSerBrGSCB.Items.Clear();
                OdveziSerBrGSCB.Text = null;

                MessageBox.Show("Uspesno uklonjena glavna stanica");
                return;
            }
            else
            {
                MessageBox.Show("Odaberite stanicu koju hocete da odvezete");
                return;
            }
        }

        private void SacuvajGSBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(ProizvodjacGSTB.Text) && !String.IsNullOrWhiteSpace(ProizvodjacGSTB.Text) && String.Compare(ProizvodjacGSTB.Text, komCvor_Basic.Proizvodjac)!=0)
            {
                komCvor_Basic.Proizvodjac=ProizvodjacGSTB.Text;
            }

            if (!String.IsNullOrEmpty(AdresaTB.Text) && !String.IsNullOrWhiteSpace(AdresaTB.Text) && String.Compare(AdresaTB.Text, komCvor_Basic.Adresa) != 0)
            {
                komCvor_Basic.Adresa = AdresaTB.Text;
            }

            if(BrojLokacijeNum.Value>0 && BrojLokacijeNum.Value != komCvor_Basic.Broj_lokacije)
            {
                komCvor_Basic.Broj_lokacije =(int)BrojLokacijeNum.Value;
            }

            if (DatumPocGSDate.Value != komCvor_Basic.Datum_pocetka_upotrebe)
            {
                komCvor_Basic.Datum_pocetka_upotrebe=DatumPocGSDate.Value;
            }

            if (!String.IsNullOrEmpty(RazlogServisaGSBox.Text) && !String.IsNullOrWhiteSpace(RazlogServisaGSBox.Text) && String.Compare(RazlogServisaGSBox.Text, komCvor_Basic.Razlog_poslednjeg_servisa) != 0)
            {
                komCvor_Basic.Razlog_poslednjeg_servisa = RazlogServisaGSBox.Text;
            }

            if (!String.IsNullOrEmpty(OpisTB.Text) && !String.IsNullOrWhiteSpace(OpisTB.Text) && String.Compare(OpisTB.Text, komCvor_Basic.Opis) != 0)
            {
                komCvor_Basic.Opis = OpisTB.Text;
            }

            DTOmanagerM.promeniKC(komCvor_Basic);

            MessageBox.Show("Uspesno promenjen komunikacioni cvor");

            if (OdveziSerBrGSCB.Items.Count != 1)
            {
                MessageBox.Show("Komunikacioni cvor mora biti povezan na tacno 1 stanicu");
                return;
            }

            this.Close();
        }
    }
}

