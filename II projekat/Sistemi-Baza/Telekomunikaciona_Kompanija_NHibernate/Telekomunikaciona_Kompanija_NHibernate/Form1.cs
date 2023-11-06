using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telekomunikaciona_Kompanija_NHibernate.Entiteti;

namespace Telekomunikaciona_Kompanija_NHibernate
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitavanjeUredjaja_Click(object sender, EventArgs e)
        {
            try {
                ISession s = DataLayer.GetSession();

                Uredjaj u = s.Load<Uredjaj>(45678);

                MessageBox.Show(u.Razlog_poslednjeg_servisa);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cmdKreirajUredjaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Uredjaj u=new Uredjaj();


                u.Serijski_broj = 22012005;
                u.Datum_pocetka_upotrebe=DateTime.Now;
                u.Tip_uredjaja = "Komunikacioni cvor";
                u.Proizvodjac = "MARKO";
                u.Razlog_poslednjeg_servisa = "Jer nije je trebalo";
                
                s.Save(u);

                s.Flush();
                s.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdKreirajKomunikacioniCvor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s=DataLayer.GetSession();

                Komunikacioni_cvor kc = new Komunikacioni_cvor();

                kc.Broj_lokacije = 5;
                kc.Adresa = "Sutjeska";
                kc.Opis = "Neki kratki opis";

                s.Save(kc);
                s.Flush(); s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void cmdUcitajKomCvor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Komunikacioni_cvor kc = s.Load<Telekomunikaciona_Kompanija_NHibernate.Entiteti.Komunikacioni_cvor>(456789);

                MessageBox.Show(kc.Opis);

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitajGlavnuStanicu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Glavna_stanica g = s.Load<Telekomunikaciona_Kompanija_NHibernate.Entiteti.Glavna_stanica>(12345);

                MessageBox.Show(g.Region);

                s.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrikaziUsluge_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Usluga u = s.Load<Usluga>(3);

                MessageBox.Show(u.Tip_usluge);

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSviBrojeviTelefonije_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Telefonija u = s.Load<Telefonija>(3);

                foreach(BrojTelefona br in u.Brojevi_Telefona)
                {
                    MessageBox.Show("Broj:"+br.Broj+" potroseni minuti: "+br.Potroseni_minuti);
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajTelefoniju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Telefonija u = new Telefonija();

                u.Tip_usluge = "Telefonija";

                BrojTelefona b = new BrojTelefona();
                b.Broj = 123456788;
                b.Potroseni_minuti = 1234;

                BrojTelefona b1 = new BrojTelefona();
                b1.Broj = 12341111;
                b1.Potroseni_minuti = 14;

                b.PripadaTelefoniji = u;
                b1.PripadaTelefoniji = u;

                u.Brojevi_Telefona.Add(b);
                u.Brojevi_Telefona.Add(b1);

                s.Save(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrikaziDodatnePakete_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Televizija u = s.Load<Televizija>(5);

                foreach (DodatniPaketKanala br in u.DodatniPaketiKanala)
                {
                    MessageBox.Show("Osnovni paket: " + u.Paket + " dodatni paket: " + br.DodatniPaket);
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajPaket_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Televizija u = new Televizija();

                u.Tip_usluge = "Televizija";
                u.Paket = "Test paket";

                s.Save(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajDodatniPaket_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Televizija u = s.Load<Televizija>(15);

                //u.Tip_usluge = "Televizija";
                //u.Paket = "Test paket1";

                DodatniPaketKanala d = new DodatniPaketKanala();
                d.DodatniPaket = "Dodatni paket";
                d.Televizija = u;

                DodatniPaketKanala d1 = new DodatniPaketKanala();
                d1.DodatniPaket = "Dodatni paket1";
                d1.Televizija = u;

                u.DodatniPaketiKanala.Add(d);
                u.DodatniPaketiKanala.Add(d1);

                s.Save(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrikaziNet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internet i = s.Load<Internet>(1);

                if (i.FlagPrepaid==false)
                {
                    MessageBox.Show("Tip interneta: " + i.TipInterneta);
                }
                else
                {
                    MessageBox.Show("Tip interneta: " + i.TipInterneta + ", datum poslednje uplate: " + i.DatumPoslednjeUplate + " stanje racuna:" + i.StanjeRacuna);
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void brnDodajNet_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internet u = new Internet();

                u.TipInterneta = "Prepaid";
                u.FlagPrepaid = true;
                u.DatumPoslednjeUplate=DateTime.Now;
                u.StanjeRacuna = 12345;
                u.Tip_usluge = "Internet";

                FlataRate p=new FlataRate();
                p.TipPlacanja = "Flat rate";
                s.Save(p);
                s.Flush();

                u.Placanje = p;

                s.Save(u);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Komunikacioni_cvor komunikacioni_Cvor = s.Load<Komunikacioni_cvor>(456789);

                MessageBox.Show(komunikacioni_Cvor.Adresa);

                MessageBox.Show(komunikacioni_Cvor.Glavna_stanica_kom_cvora.Proizvodjac);

                s.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdOnetoMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica glavna_Stanica = s.Load<Glavna_stanica>(45678);

                MessageBox.Show(glavna_Stanica.Proizvodjac);

                foreach (Komunikacioni_cvor kc in glavna_Stanica.Komunikacioni_cvor)
                {
                    MessageBox.Show(kc.Opis + " " + kc.Adresa);
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdVratiHubStanice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s=DataLayer.GetSession();

                Glavna_stanica glavna_Stanica = s.Load<Glavna_stanica>(45678);

                MessageBox.Show(glavna_Stanica.Flag_Hub.ToString());

                MessageBox.Show(glavna_Stanica.Glavna_stanica_hub.Serijski_broj.ToString());

                s.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdVratiStaniceHuba_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Glavna_stanica hub = s.Load<Glavna_stanica>(12345);

                foreach(Glavna_stanica gs in hub.Hub_glavna_stanica)
                {
                    MessageBox.Show(gs.Serijski_broj.ToString());
                }

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdVratiKorisnike_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                /*
                                IQuery q = s.CreateQuery("select k.JMBG, k.Ime, k.Prezime from Korisnik k");

                                IList<object[]> result = q.List<object[]>();

                                foreach (object[] o in result)
                                {
                                    string JMBG = o[0].ToString();
                                    string ime = o[1].ToString();
                                    string prezime= o[2].ToString();

                                    MessageBox.Show("JMBG: " + JMBG + " Ime: " + ime + " Prezime: " + prezime);
                                }*/

                IList<Korisnik> korisniks=s.QueryOver<Korisnik>().List<Korisnik>();

                MessageBox.Show(korisniks[0].Ime);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Korisnik korisnik = s.Load<Korisnik>("4488990361220");


                MessageBox.Show(korisnik.Korisnik_koristi[0].JMBG_Korisnika.Ime);

                s.Flush();
                s.Close() ; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdVratiPravnoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pravna_lica p = s.Load<Pravna_lica>("6789012555878");

                MessageBox.Show(p.Broj_faksa.ToString());

/*                IList<Pravna_lica> lica=s.QueryOver<Pravna_lica>().List<Pravna_lica>();

                MessageBox.Show(lica[0].Ime);*/


/*                IQuery q = s.CreateQuery("select q.JMBG, q.Ime_kontakt_osobe from Pravna_lica q");

                IList<object[]> result = q.List<object[]>();

                foreach (object[] o in result)
                {
                    string JMBG= o[0].ToString();
                    string ime = o[1].ToString();

                    MessageBox.Show("JMBG: " + JMBG + " Ime: " + ime);
                }*/

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdVratiFizickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s=DataLayer.GetSession();

                IList<Fizicka_lica> fizicka_Lica = s.QueryOver<Fizicka_lica>().List<Fizicka_lica>();

                foreach(Fizicka_lica f in fizicka_Lica)
                {
                    MessageBox.Show(f.Kom_cvor.Adresa + " " + f.Prezime);
                }

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajHub_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }

        private void cmdDodajKorisnika_Click(object sender, EventArgs e)
        {

        }

        private void cmdDodajPravnoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Pravna_lica lice=new Pravna_lica();

                lice.Ime = "Milos";
                lice.Prezime = "Stanojevic";
                lice.JMBG = "2201002752517";
                lice.Broj_faksa = 23;
                lice.Adresa = "Sutjeska";
                lice.Broj = "14";
                lice.Poreski_identifikacioni_broj = 1234567890;
                lice.Tip_korisnika = "Pravno lice";
                lice.Grad = "Kladovo";
                lice.Ime_kontakt_osobe = "Milos";

                Komunikacioni_cvor kc = s.Load<Komunikacioni_cvor>((long)4567890);

                lice.Kom_cvor = kc;

                s.Save(lice);

                s.Flush();
                s.Close(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodajBrojKorisniku_Click(object sender, EventArgs e)
        {

        }
    }
}
