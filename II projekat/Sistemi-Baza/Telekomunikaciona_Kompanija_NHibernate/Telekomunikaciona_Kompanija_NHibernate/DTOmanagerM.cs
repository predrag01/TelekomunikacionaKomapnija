using NHibernate;
using NHibernate.Engine;
using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikaciona_Kompanija_NHibernate.Entiteti;

namespace Telekomunikaciona_Kompanija_NHibernate
{
    internal class DTOmanagerM
    {
        #region Uredjaji



        internal static void obrisiUredjaj(UredjajBasic uredjaj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Uredjaj u = s.Load<Uredjaj>(uredjaj.Serijski_broj);

                s.Delete(u);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static List<UredjajPregled> vratiSveUredjaje()
        {
            List<UredjajPregled> uredjaji = new List<UredjajPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Telekomunikaciona_Kompanija_NHibernate.Entiteti.Uredjaj> sviUredjaji = from u in s.Query<Telekomunikaciona_Kompanija_NHibernate.Entiteti.Uredjaj>()
                                                                                                   select u;

                foreach (Uredjaj u in sviUredjaji)
                {
                    uredjaji.Add(new UredjajPregled(u.Proizvodjac, u.Datum_pocetka_upotrebe, u.Tip_uredjaja, u.Serijski_broj));
                }

                s.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return uredjaji;
        }

        internal static void dodajHub(Glavna_stanicaBasic glavna)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica gs = new Glavna_stanica();

                gs.Tip_uredjaja = glavna.Tip_uredjaja;
                gs.Serijski_broj = glavna.Serijski_broj;
                gs.Proizvodjac = glavna.Proizvodjac;
                gs.Datum_pocetka_upotrebe = glavna.Datum_pocetka_upotrebe;
                gs.Razlog_poslednjeg_servisa = glavna.Razlog_poslednjeg_servisa;
                gs.Region = glavna.Region;
                gs.Flag_Hub = glavna.Flag_Hub;
                gs.Hub_glavna_stanica = new List<Glavna_stanica>();

                s.SaveOrUpdate(gs);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static void dodajGS(Glavna_stanicaBasic glavna)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica gs = new Glavna_stanica();

                gs.Tip_uredjaja = glavna.Tip_uredjaja;
                gs.Serijski_broj = glavna.Serijski_broj;
                gs.Proizvodjac = glavna.Proizvodjac;
                gs.Datum_pocetka_upotrebe = glavna.Datum_pocetka_upotrebe;
                gs.Razlog_poslednjeg_servisa = glavna.Razlog_poslednjeg_servisa;
                gs.Flag_Hub = glavna.Flag_Hub;
                gs.Glavna_stanica_hub = s.Load<Glavna_stanica>(glavna.Glavna_stanica_hub.Serijski_broj);
                gs.Hub_glavna_stanica = new List<Glavna_stanica>();

                s.SaveOrUpdate(gs);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static void dodajKC(Komunikacioni_cvorBasic cvor)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Komunikacioni_cvor kc = new Komunikacioni_cvor();

                kc.Tip_uredjaja = cvor.Tip_uredjaja;
                kc.Serijski_broj = cvor.Serijski_broj;
                kc.Proizvodjac = cvor.Proizvodjac;
                kc.Datum_pocetka_upotrebe = cvor.Datum_pocetka_upotrebe;
                kc.Razlog_poslednjeg_servisa = cvor.Razlog_poslednjeg_servisa;
                kc.Broj_lokacije = cvor.Broj_lokacije;
                kc.Adresa = cvor.Adresa;
                kc.Opis = cvor.Opis;
                kc.Glavna_stanica_kom_cvora = s.Load<Glavna_stanica>(cvor.Glavna_stanica_kom_cvora.Serijski_broj);
                kc.Korisnik = new List<Korisnik>();


                s.Save(kc);
                s.Flush();

                s.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        internal static List<Glavna_stanicaPregled> vratiGlavneStanice()
        {
            List<Glavna_stanicaPregled> gStanice = new List<Glavna_stanicaPregled>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Glavna_stanica> gs = from g in s.Query<Glavna_stanica>() select g;

                foreach (Glavna_stanica g in gs)
                {
                    gStanice.Add(new Glavna_stanicaPregled(g.Flag_Hub, g.Region, g.Proizvodjac, g.Datum_pocetka_upotrebe, g.Razlog_poslednjeg_servisa, g.Tip_uredjaja, g.Serijski_broj));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return gStanice;
        }

        internal static UredjajBasic vratiUredjaj(long serijskiBrojUredjaja)
        {
            UredjajBasic ub = new UredjajBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Uredjaj u = s.Load<Uredjaj>(serijskiBrojUredjaja);

                ub = new UredjajBasic(u.Proizvodjac, u.Datum_pocetka_upotrebe, u.Razlog_poslednjeg_servisa, u.Tip_uredjaja, u.Serijski_broj);

                s.Close();
            }

            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            return ub;
        }

        internal static Glavna_stanicaPregled vratiGSPregled(long serijski_broj)
        {
            Glavna_stanicaPregled ub = new Glavna_stanicaPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica u = s.Load<Glavna_stanica>(serijski_broj);

                ub = new Glavna_stanicaPregled(u.Flag_Hub, u.Region, u.Proizvodjac, u.Datum_pocetka_upotrebe, u.Razlog_poslednjeg_servisa, u.Tip_uredjaja, u.Serijski_broj);

                s.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ub;
        }

        internal static Glavna_stanicaBasic vratiGS(long serijski_broj)
        {
            Glavna_stanicaBasic ub = new Glavna_stanicaBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica u = s.Load<Glavna_stanica>(serijski_broj);

                ub = new Glavna_stanicaBasic(u.Flag_Hub, u.Region, u.Proizvodjac, u.Datum_pocetka_upotrebe, u.Razlog_poslednjeg_servisa, u.Tip_uredjaja, u.Serijski_broj);

                s.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ub;
        }

        internal static List<Komunikacioni_cvorPregled> vratiAdreseKomCvorova(long serijski_broj)
        {
            List<Komunikacioni_cvorPregled> komCvorovi = new List<Komunikacioni_cvorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica glavna_Stanica = s.Load<Glavna_stanica>(serijski_broj);

                foreach (Komunikacioni_cvor komCvor in glavna_Stanica.Komunikacioni_cvor)
                {
                    komCvorovi.Add(new Komunikacioni_cvorPregled(komCvor.Opis, komCvor.Broj_lokacije, komCvor.Adresa, komCvor.Proizvodjac, komCvor.Datum_pocetka_upotrebe, komCvor.Razlog_poslednjeg_servisa, komCvor.Tip_uredjaja, komCvor.Serijski_broj));
                }
                s.Close();

            }
            catch (Exception e) {

                Console.WriteLine(e.ToString());
            }

            return komCvorovi;
        }

        internal static List<Glavna_stanicaPregled> vratiHubovePregled()
        {
            List<Glavna_stanicaPregled> hubovi = new List<Glavna_stanicaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Glavna_stanica> gs = from g in s.Query<Glavna_stanica>() where g.Flag_Hub == true select g;

                foreach (Glavna_stanica g in gs)
                {
                    hubovi.Add(new Glavna_stanicaPregled(g.Flag_Hub, g.Region, g.Proizvodjac, g.Datum_pocetka_upotrebe, g.Razlog_poslednjeg_servisa, g.Tip_uredjaja, g.Serijski_broj));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return hubovi;
        }
        internal static List<Glavna_stanicaBasic> vratiHubove()
        {
            List<Glavna_stanicaBasic> hubovi = new List<Glavna_stanicaBasic>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Glavna_stanica> gs = from g in s.Query<Glavna_stanica>() where g.Flag_Hub == true select g;

                foreach (Glavna_stanica g in gs)
                {
                    hubovi.Add(new Glavna_stanicaBasic(g.Flag_Hub, g.Region, g.Proizvodjac, g.Datum_pocetka_upotrebe, g.Razlog_poslednjeg_servisa, g.Tip_uredjaja, g.Serijski_broj));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return hubovi;
        }

        internal static Glavna_stanicaPregled vratiHubOdabraneStanice(long serijski_broj)
        {
            Glavna_stanicaPregled glavna_Stanica = new Glavna_stanicaPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica gs = s.Load<Glavna_stanica>(serijski_broj);

                Glavna_stanica hub = s.Load<Glavna_stanica>(gs.Glavna_stanica_hub.Serijski_broj);

                glavna_Stanica = new Glavna_stanicaPregled(hub.Flag_Hub, hub.Region, hub.Proizvodjac, hub.Datum_pocetka_upotrebe, hub.Razlog_poslednjeg_servisa, hub.Tip_uredjaja, hub.Serijski_broj);
            }
            catch (System.Exception e) { Console.WriteLine(e.Message); }

            return glavna_Stanica;
        }

        internal static List<Glavna_stanicaPregled> vratiGlavneStaniceHuba(long serijski_broj)
        {
            List<Glavna_stanicaPregled> glavne_stanice = new List<Glavna_stanicaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica glavna_stanica = s.Load<Glavna_stanica>(serijski_broj);

                foreach (Glavna_stanica gs in glavna_stanica.Hub_glavna_stanica)
                {
                    glavne_stanice.Add(new Glavna_stanicaPregled(gs.Flag_Hub, gs.Region, gs.Proizvodjac, gs.Datum_pocetka_upotrebe, gs.Razlog_poslednjeg_servisa, gs.Tip_uredjaja, gs.Serijski_broj));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return glavne_stanice;
        }

        internal static Komunikacioni_cvorBasic vratiKCBasic(long serijski_broj)
        {
            Komunikacioni_cvorBasic ub = new Komunikacioni_cvorBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Komunikacioni_cvor u = s.Load<Komunikacioni_cvor>(serijski_broj);

                ub = new Komunikacioni_cvorBasic(u.Opis, u.Broj_lokacije, u.Adresa, u.Proizvodjac, u.Datum_pocetka_upotrebe, u.Razlog_poslednjeg_servisa, u.Tip_uredjaja, u.Serijski_broj);

                s.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ub;
        }

        internal static Komunikacioni_cvorPregled vratiKC(long serijski_broj)
        {
            Komunikacioni_cvorPregled ub = new Komunikacioni_cvorPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                Komunikacioni_cvor u = s.Load<Komunikacioni_cvor>(serijski_broj);

                ub = new Komunikacioni_cvorPregled(u.Opis, u.Broj_lokacije, u.Adresa, u.Proizvodjac, u.Datum_pocetka_upotrebe, u.Razlog_poslednjeg_servisa, u.Tip_uredjaja, u.Serijski_broj);

                s.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ub;
        }

        internal static Glavna_stanicaPregled vratiGlavnuStanicuKC(long serijski_broj)
        {
            Glavna_stanicaPregled glavna_Stanica = new Glavna_stanicaPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Komunikacioni_cvor kc = s.Load<Komunikacioni_cvor>(serijski_broj);

                Glavna_stanica gs = kc.Glavna_stanica_kom_cvora;

                glavna_Stanica = new Glavna_stanicaPregled(gs.Flag_Hub, gs.Region, gs.Proizvodjac, gs.Datum_pocetka_upotrebe, gs.Razlog_poslednjeg_servisa, gs.Tip_uredjaja, gs.Serijski_broj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return glavna_Stanica;
        }

        internal static List<KorisnikPregled> vratiKorisnikeKC(long serijski_broj)
        {
            List<KorisnikPregled> korisnici = new List<KorisnikPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                Komunikacioni_cvor kc = s.Load<Komunikacioni_cvor>(serijski_broj);

                IEnumerable<Korisnik> sviKorisnici = from k in s.Query<Korisnik>() where k.Kom_cvor == kc select k;

                foreach (Korisnik k in sviKorisnici)
                {
                    korisnici.Add(new KorisnikPregled(k.JMBG, k.Ime, k.Prezime, k.Adresa, k.Broj, k.Grad, k.Tip_korisnika));
                }

                s.Close();
            }
            catch (System.Exception e)
            {
                Console.Write(e.ToString());
            }

            return korisnici;
        }
        #endregion

        #region Korisnik

        internal static void obrisiKorisnika(KorisnikBasic korisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik k = s.Load<Korisnik>(korisnik.JMBG);

                s.Delete(k);
                s.Flush();

                s.Close();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static void dodajPravnoLice(Pravna_licaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pravna_lica lice = new Pravna_lica();

                lice.JMBG = p.JMBG;
                lice.Ime = p.Ime;
                lice.Prezime = p.Prezime;
                lice.Broj = p.Broj;
                lice.Adresa = p.Adresa;
                lice.Grad = p.Grad;
                lice.Broj_faksa = p.Broj_faksa;
                lice.Poreski_identifikacioni_broj = p.Poreski_identifikacioni_broj;
                lice.Tip_korisnika = p.Tip_korisnika;
                lice.Ime_kontakt_osobe = p.Ime_kontakt_osobe;
                lice.Korisnik_koristi = new List<Koristi>();
                lice.Telefoni_korinika = new List<Telefon>();
                lice.Kom_cvor = s.Load<Komunikacioni_cvor>(p.Kom_cvor.Serijski_broj);


                s.Save(lice);
                s.Flush();

                /*                DTOmanagerM.dodajKCKorisniku(lice.JMBG, p.Kom_cvor);*/

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static void dodajFizickoLice(Fizicka_licaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fizicka_lica lice = new Fizicka_lica();

                lice.JMBG = p.JMBG;
                lice.Ime = p.Ime;
                lice.Prezime = p.Prezime;
                lice.Broj = p.Broj;
                lice.Adresa = p.Adresa;
                lice.Grad = p.Grad;
                lice.Tip_korisnika = p.Tip_korisnika;

                lice.Kom_cvor = s.Load<Komunikacioni_cvor>(p.Kom_cvor.Serijski_broj);

                s.Save(lice);
                s.Flush();


                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void dodajKCKorisniku(string JMBG, Komunikacioni_cvorBasic kom_cvor)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik korisnik = s.Load<Korisnik>(JMBG);

                Komunikacioni_cvor kc = s.Load<Komunikacioni_cvor>(kom_cvor.Serijski_broj);

                korisnik.Kom_cvor = kc;

                s.Save(korisnik);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static List<KorisnikPregled> vratiSveKorisnike()
        {
            List<KorisnikPregled> korisnici = new List<KorisnikPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Korisnik> korisnik = from k in s.Query<Telekomunikaciona_Kompanija_NHibernate.Entiteti.Korisnik>()
                                                 select k;

                foreach (Korisnik k in korisnik)
                {
                    korisnici.Add(new KorisnikPregled(k.JMBG, k.Ime, k.Prezime, k.Adresa, k.Broj, k.Grad, k.Tip_korisnika));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return korisnici;
        }

        internal static void promeniKorisnikaFizickoLice(Fizicka_licaBasic korisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Fizicka_lica p = s.Load<Fizicka_lica>(korisnik.JMBG);
                p.Ime = korisnik.Ime;
                p.Prezime = korisnik.Prezime;
                p.Adresa = korisnik.Adresa;
                p.Broj = korisnik.Broj;
                p.Grad = korisnik.Grad;

                s.Update(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static void promeniKorisnikaPravnoLice(Pravna_licaBasic korisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pravna_lica p = s.Load<Pravna_lica>(korisnik.JMBG);
                p.Ime = korisnik.Ime;
                p.Prezime = korisnik.Prezime;
                p.Adresa = korisnik.Adresa;
                p.Broj = korisnik.Broj;
                p.Grad = korisnik.Grad;
                p.Poreski_identifikacioni_broj = korisnik.Poreski_identifikacioni_broj;
                p.Broj_faksa = korisnik.Broj_faksa;
                p.Ime_kontakt_osobe = korisnik.Ime_kontakt_osobe;

                s.Update(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static KorisnikBasic vratiKorisnikaBasic(string JMBG)
        {
            KorisnikBasic ub = new KorisnikBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik u = s.Load<Korisnik>(JMBG);

                ub = new KorisnikBasic(u.JMBG, u.Ime, u.Prezime, u.Adresa, u.Broj, u.Grad, u.Tip_korisnika);

                s.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ub;
        }
        internal static KorisnikPregled vratiKorisnika(string JMBG)
        {
            KorisnikPregled ub = new KorisnikPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik u = s.Load<Korisnik>(JMBG);

                ub = new KorisnikPregled(u.JMBG, u.Ime, u.Prezime, u.Adresa, u.Broj, u.Grad, u.Tip_korisnika);

                s.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ub;
        }

        internal static Fizicka_licaBasic vratiFizickoLiceBasic(string JMBG)
        {
            Fizicka_licaBasic pravnoLice = new Fizicka_licaBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Fizicka_lica p = s.Load<Fizicka_lica>(JMBG);

                pravnoLice = new Fizicka_licaBasic(p.JMBG, p.Ime, p.Prezime, p.Adresa, p.Broj, p.Grad, p.Tip_korisnika);

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return pravnoLice;
        }

        internal static Pravna_licaBasic vratiPravnoLiceBasic(string JMBG)
        {
            Pravna_licaBasic pravnoLice = new Pravna_licaBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Pravna_lica p = s.Load<Pravna_lica>(JMBG);

                pravnoLice = new Pravna_licaBasic(p.Ime_kontakt_osobe, p.Broj_faksa, p.Poreski_identifikacioni_broj, p.JMBG, p.Ime, p.Prezime, p.Adresa, p.Broj, p.Grad, p.Tip_korisnika);

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return pravnoLice;
        }

        internal static Pravna_licaPregled vratiPravnoLice(string JMBG)
        {
            Pravna_licaPregled pravnoLice = new Pravna_licaPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                Pravna_lica p = s.Load<Pravna_lica>(JMBG);

                pravnoLice = new Pravna_licaPregled(p.Ime_kontakt_osobe, p.Broj_faksa, p.Poreski_identifikacioni_broj, p.JMBG, p.Ime, p.Prezime, p.Adresa, p.Broj, p.Grad, p.Tip_korisnika);

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return pravnoLice;
        }

        internal static Komunikacioni_cvorBasic vratiKCKorisnikaBasic(string JMBG)
        {
            Komunikacioni_cvorBasic kc_Pregled = new Komunikacioni_cvorBasic();

            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik korisnik = s.Load<Korisnik>(JMBG);

                Komunikacioni_cvor kc = korisnik.Kom_cvor;

                kc_Pregled = new Komunikacioni_cvorBasic(kc.Opis, kc.Broj_lokacije, kc.Adresa, kc.Proizvodjac, kc.Datum_pocetka_upotrebe, kc.Razlog_poslednjeg_servisa, kc.Tip_uredjaja, kc.Serijski_broj);

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return kc_Pregled;
        }

        internal static Komunikacioni_cvorPregled vratiKCKorisnika(string JMBG)
        {
            Komunikacioni_cvorPregled kc_Pregled = new Komunikacioni_cvorPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik korisnik = s.Load<Korisnik>(JMBG);

                Komunikacioni_cvor kc = korisnik.Kom_cvor;

                kc_Pregled = new Komunikacioni_cvorPregled(kc.Opis, kc.Broj_lokacije, kc.Adresa, kc.Proizvodjac, kc.Datum_pocetka_upotrebe, kc.Razlog_poslednjeg_servisa, kc.Tip_uredjaja, kc.Serijski_broj);

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return kc_Pregled;
        }

        internal static List<TelefonPregled> vratiTelefoneKorisnika(string JMBG)
        {
            List<TelefonPregled> telefoni = new List<TelefonPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik korisnik = s.Load<Korisnik>(JMBG);

                IEnumerable<Telefon> tel = from k in s.Query<Telefon>() where k.JMBG_korisnika == korisnik select k;

                foreach (Telefon t in tel)
                {
                    telefoni.Add(new TelefonPregled(t.Id, t.telefon));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return telefoni;
        }

        internal static List<UslugaPregled> vratiUslugeKorisnika(string JMBG)
        {
            List<UslugaPregled> usluge = new List<UslugaPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik korisnik = s.Load<Korisnik>(JMBG);

                IEnumerable<Koristi> koristi = from k in s.Query<Koristi>() where k.JMBG_Korisnika.JMBG == korisnik.JMBG select k;

                foreach (Koristi k in koristi)
                {
                    usluge.Add(new UslugaPregled(k.ID_Usluge.Id, k.ID_Usluge.Tip_usluge));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return usluge;
        }

        #endregion
        #region Usluga

        internal static UslugaPregled vratiUslugu(int id)
        {
            UslugaPregled usluga = new UslugaPregled();
            try
            {
                ISession s = DataLayer.GetSession();

                Usluga u = s.Load<Usluga>(id);

                usluga = new UslugaPregled(u.Id, u.Tip_usluge);

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return usluga;
        }


        internal static void otkaziUsluguKorisniku(UslugaPregled usluga, string jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Usluga u = s.Load<Usluga>(usluga.Id);

                Korisnik k = s.Load<Korisnik>(jmbg);

                IEnumerable<Koristi> koristiList = from kor in s.Query<Koristi>() where kor.JMBG_Korisnika == k && kor.ID_Usluge == u select kor;

                Koristi jedan = koristiList.First();

                Koristi koristi = s.Load<Koristi>(jedan.Id);

                s.Delete(koristi);
                s.Flush();

                s.Update(k);
                s.Flush();

                s.Update(u); s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static void dodeliUsluguKorisniku(UslugaPregled usluga, string JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Usluga u = s.Load<Usluga>(usluga.Id);

                Korisnik k = s.Load<Korisnik>(JMBG);

                Koristi koristi = new Koristi();

                koristi.JMBG_Korisnika = k;
                koristi.ID_Usluge = u;

                s.SaveOrUpdate(koristi);
                s.Flush();

                k.Korisnik_koristi.Add(koristi);

                s.SaveOrUpdate(k);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static void kreirajTelefonIDodeliKorisniku(string telefon, string JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik k = s.Load<Korisnik>(JMBG);

                Telefon t = new Telefon();

                t.telefon = long.Parse(telefon);
                t.JMBG_korisnika = k;

                s.SaveOrUpdate(t);
                s.Flush();

                k.Telefoni_korinika.Add(t);

                s.SaveOrUpdate(k);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static List<UslugaPregled> vratiUsluge()
        {
            List<UslugaPregled> usluge = new List<UslugaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Usluga> usl = from u in s.Query<Usluga>() select u;

                foreach (Usluga u in usl)
                {
                    usluge.Add(new UslugaPregled(u.Id, u.Tip_usluge));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return usluge;
        }

        internal static List<UslugaBasic> vratiUslugeBasic()
        {
            List<UslugaBasic> usluge = new List<UslugaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Usluga> usl = from u in s.Query<Usluga>() select u;

                foreach (Usluga u in usl)
                {
                    usluge.Add(new UslugaBasic(u.Id, u.Tip_usluge));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return usluge;
        }

        #endregion

        #region GlavnaStanica

        internal static void promeniHubGSe(long h, long gs)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica g = s.Load<Glavna_stanica>(gs);
                Glavna_stanica hub = s.Load<Glavna_stanica>(h);

                g.Glavna_stanica_hub = hub;

                hub.Hub_glavna_stanica.Add(g);

                s.Update(g);
                s.Flush();

                s.Update(hub);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        internal static void proglasiZaHub(long ser)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica g = s.Load<Glavna_stanica>(ser);

                g.Flag_Hub = true;
                g.Glavna_stanica_hub = null;
                g.Tip_uredjaja = "Hub";

                s.Update(g);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static void promeniGS(Glavna_stanicaBasic glavna)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica g = s.Load<Glavna_stanica>(glavna.Serijski_broj);

                g.Proizvodjac = glavna.Proizvodjac;
                g.Datum_pocetka_upotrebe = glavna.Datum_pocetka_upotrebe;
                g.Razlog_poslednjeg_servisa = glavna.Razlog_poslednjeg_servisa;

                s.Update(g);
                s.Flush();

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
        #region Hub
        internal static void poveziGSNaHub(long stanica, long hub)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Glavna_stanica st = s.Load<Glavna_stanica>(stanica);
                Glavna_stanica h = s.Load<Glavna_stanica>(hub);

                h.Hub_glavna_stanica.Add(st);
                st.Glavna_stanica_hub = h;

                s.Update(st);
                s.Flush();

                s.Update(h);
                s.Flush();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        internal static void odveziGSSaHuba(long stanica, long hub)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Glavna_stanica st=s.Load<Glavna_stanica>(stanica);
                Glavna_stanica h = s.Load<Glavna_stanica>(hub);

                h.Hub_glavna_stanica.Remove(st);
                st.Glavna_stanica_hub = null;

                s.Update(st);
                s.Flush();

                s.Update(h);
                s.Flush();

                s.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        internal static void promeniHub(Glavna_stanicaBasic hub)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica g = s.Load<Glavna_stanica>(hub.Serijski_broj);

                g.Proizvodjac = hub.Proizvodjac;
                g.Datum_pocetka_upotrebe = hub.Datum_pocetka_upotrebe;
                g.Razlog_poslednjeg_servisa = hub.Razlog_poslednjeg_servisa;
                g.Region=hub.Region;

                s.Update(g);
                s.Flush();

                s.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region KomCvor

        internal static void dodajKCGS(long kc,long gs)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Glavna_stanica g = s.Load<Glavna_stanica>(gs);
                Komunikacioni_cvor k = s.Load<Komunikacioni_cvor>(kc);

                k.Glavna_stanica_kom_cvora = g;

                s.Update(g);
                s.Flush();

                s.Update(k);
                s.Flush();

                s.Close();
            }
            catch(Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        internal static List<Komunikacioni_cvorPregled> vratiKCvoroveGS(long ser)
        {
            List<Komunikacioni_cvorPregled> cvorovi = new List<Komunikacioni_cvorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Glavna_stanica g = s.Load<Glavna_stanica>(ser);

                foreach(Komunikacioni_cvor k in g.Komunikacioni_cvor)
                {
                    cvorovi.Add(new Komunikacioni_cvorPregled(k.Opis, k.Broj_lokacije, k.Adresa, k.Proizvodjac, k.Datum_pocetka_upotrebe, k.Razlog_poslednjeg_servisa, k.Tip_uredjaja, k.Serijski_broj));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return cvorovi;
        }

        internal static void promeniKC(Komunikacioni_cvorBasic kom)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Komunikacioni_cvor kc = s.Load<Komunikacioni_cvor>(kom.Serijski_broj);

                kc.Proizvodjac = kom.Proizvodjac;
                kc.Adresa = kom.Adresa;
                kc.Datum_pocetka_upotrebe = kom.Datum_pocetka_upotrebe;
                kc.Broj_lokacije = kom.Broj_lokacije;
                kc.Razlog_poslednjeg_servisa = kom.Razlog_poslednjeg_servisa;
                kc.Opis = kom.Opis;

                s.Update(kc);
                s.Flush();

                s.Close();
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        internal static void promeniGSKCa(long serGS,long serKC)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Glavna_stanica gs = s.Load<Glavna_stanica>(serGS);

                Komunikacioni_cvor kc = s.Load<Komunikacioni_cvor>(serKC);

                kc.Glavna_stanica_kom_cvora = gs;

                s.Update(gs);
                s.Flush();

                s.Update(kc);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        internal static void ukloniKorisnikaKCa(string jmbg,long ser)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Korisnik korisnik = s.Load<Korisnik>(jmbg);

                Komunikacioni_cvor kom=s.Load<Komunikacioni_cvor>(ser);

                kom.Korisnik.Remove(korisnik);

                s.Update(kom);
                s.Flush();

                s.Update(korisnik);
                s.Flush();

                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static void dodajKorisnikaKCu(string jmbg, long ser)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Korisnik k = s.Load<Korisnik>(jmbg);

                Komunikacioni_cvor kom=s.Load<Komunikacioni_cvor>(ser);

                k.Kom_cvor = kom;

                s.Update(kom);
                s.Flush();

                s.Update(k);
                s.Flush();

                s.Close();
            }
            catch(Exception  ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static void promeniKCKorisniku(string jmbg, Komunikacioni_cvorBasic zauzetKC)
        {
            try
            {
                ISession s= DataLayer.GetSession();

                Korisnik k = s.Load<Korisnik>(jmbg);

                Komunikacioni_cvor kc = s.Load<Komunikacioni_cvor>(zauzetKC.Serijski_broj);

                k.Kom_cvor = kc;

                s.Update(k);
                s.Flush();

                s.Update(kc);
                s.Flush();

                s.Close();
            }
            catch(Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }

        internal static List<Komunikacioni_cvorBasic> vratiKomCvorove()
        {
            List<Komunikacioni_cvorBasic> komCvorovi=new List<Komunikacioni_cvorBasic>();

            try
            {
                ISession s= DataLayer.GetSession();

                IEnumerable<Komunikacioni_cvor> kc = from k in s.Query<Komunikacioni_cvor>() select k;

                foreach(Komunikacioni_cvor k in kc)
                {
                    komCvorovi.Add(new Komunikacioni_cvorBasic(k.Opis, k.Broj_lokacije, k.Adresa, k.Proizvodjac, k.Datum_pocetka_upotrebe, k.Razlog_poslednjeg_servisa, k.Tip_uredjaja, k.Serijski_broj));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return komCvorovi;
        }

        internal static List<Komunikacioni_cvorPregled> vratiKomCvorovePregled()
        {
            List<Komunikacioni_cvorPregled> komCvorovi = new List<Komunikacioni_cvorPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Komunikacioni_cvor> kc = from k in s.Query<Komunikacioni_cvor>() select k;

                foreach (Komunikacioni_cvor k in kc)
                {
                    komCvorovi.Add(new Komunikacioni_cvorPregled(k.Opis, k.Broj_lokacije, k.Adresa, k.Proizvodjac, k.Datum_pocetka_upotrebe, k.Razlog_poslednjeg_servisa, k.Tip_uredjaja, k.Serijski_broj));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return komCvorovi;
        }

        #endregion

        #region Telefon

        internal static List<TelefonPregled> vratiTelefone()
        {
            List<TelefonPregled> telefoni=new List<TelefonPregled> ();
            try
            {
                ISession s=DataLayer.GetSession();

                IEnumerable<Telefon> tel = from t in s.Query<Telefon>() select t;

                foreach(Telefon t in tel)
                {
                    telefoni.Add(new TelefonPregled(t.Id, t.telefon));
                }

                s.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return telefoni;
        }

        internal static void promeniTelefon(string novi, string stari)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Telefon> t = from tel in s.Query<Telefon>() where tel.telefon == long.Parse(stari) select tel;

                Telefon telefon = t.First();

                telefon.telefon = long.Parse(novi);

                s.Update(telefon);
                s.Flush();

                s.Close();
            }
            catch(Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }



        #endregion
    }
}
