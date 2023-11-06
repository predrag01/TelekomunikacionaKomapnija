using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikaciona_Kompanija_NHibernate.Entiteti;

namespace Telekomunikaciona_Kompanija_NHibernate
{
    #region Uredjaj
    public class UredjajPregled
    {
        public string Proizvodjac { get; set; }
        public DateTime Datum_pocetka_upotrebe { get; set; }
        public string Razlog_poslednjeg_servisa { get; set; }
        public string Tip_uredjaja { get; set; }
        public Int64 Serijski_broj { get; set; }

        public UredjajPregled() { }

        public UredjajPregled(string proizvodjac, DateTime datum_pocetka_upotrebe, string tip_uredjaja, long serijski_broj)
        {
            Proizvodjac = proizvodjac;
            Datum_pocetka_upotrebe = datum_pocetka_upotrebe;
            Tip_uredjaja = tip_uredjaja;
            Serijski_broj = serijski_broj;
        }

        public UredjajPregled(string proizvodjac, DateTime datum_pocetka_upotrebe, string razlog_poslednjeg_servisa, string tip_uredjaja, long serijski_broj)
        {
            Proizvodjac = proizvodjac;
            Datum_pocetka_upotrebe = datum_pocetka_upotrebe;
            Razlog_poslednjeg_servisa = razlog_poslednjeg_servisa;
            Tip_uredjaja = tip_uredjaja;
            Serijski_broj = serijski_broj;
        }
    }

    public class Glavna_stanicaPregled : UredjajPregled
    {
        public bool Flag_Hub { get; set; }
        public string Region { get; set; }

        public Glavna_stanicaPregled()
        {
            Flag_Hub = false;
        }

        public Glavna_stanicaPregled(bool flag_Hub, string region, string proizvodjac, DateTime datum_pocetka_upotrebe, string razlog_poslednjeg_servisa, string tip_uredjaja, long serijski_broj) : base(proizvodjac, datum_pocetka_upotrebe, razlog_poslednjeg_servisa, tip_uredjaja, serijski_broj)
        {
            Flag_Hub = flag_Hub;
            Region = region;
        }
    }

    public class Komunikacioni_cvorPregled : UredjajPregled
    {
        public string Opis { get; set; }
        public int Broj_lokacije { get; set; }
        public string Adresa { get; set; }

        public Komunikacioni_cvorPregled() { }

        public Komunikacioni_cvorPregled(string opis, int broj_lokacije,string adresa, string proizvodjac, DateTime datum_pocetka_upotrebe, string razlog_poslednjeg_servisa, string tip_uredjaja, long serijski_broj) : base(proizvodjac, datum_pocetka_upotrebe, razlog_poslednjeg_servisa, tip_uredjaja, serijski_broj)
        {
            Adresa = adresa;
            Opis = opis;
            Broj_lokacije = broj_lokacije;
        }
    }

    public class UredjajBasic
    {
        public string Proizvodjac { get; set; }
        public DateTime Datum_pocetka_upotrebe { get; set; }
        public string Razlog_poslednjeg_servisa { get; set; }
        public string Tip_uredjaja { get; set; }
        public Int64 Serijski_broj { get; set; }

        public UredjajBasic() { }

        public UredjajBasic(string proizvodjac, DateTime datum_pocetka_upotrebe, string razlog_poslednjeg_servisa, string tip_uredjaja, long serijski_broj)
        {
            Proizvodjac = proizvodjac;
            Datum_pocetka_upotrebe = datum_pocetka_upotrebe;
            Razlog_poslednjeg_servisa = razlog_poslednjeg_servisa;
            Tip_uredjaja = tip_uredjaja;
            Serijski_broj = serijski_broj;
        }
    }

    public class Glavna_stanicaBasic : UredjajBasic
    {
        public bool Flag_Hub { get; set; }
        public string Region { get; set; }
        public Glavna_stanicaBasic Glavna_stanica_hub { get; set; }
        public IList<Glavna_stanicaBasic> Hub_glavna_stanica { get; set; }
        public IList<Komunikacioni_cvorBasic> Komunikacioni_cvor { get; set; }
        public Glavna_stanicaBasic()
        {
            Flag_Hub = false;
            Hub_glavna_stanica = new List<Glavna_stanicaBasic>();
            Komunikacioni_cvor = new List<Komunikacioni_cvorBasic>();
        }
        public Glavna_stanicaBasic(bool flag_Hub, string region, string proizvodjac, DateTime datum_pocetka_upotrebe,
            string razlog_poslednjeg_servisa, string tip_uredjaja, long serijski_broj) : base(proizvodjac, datum_pocetka_upotrebe, razlog_poslednjeg_servisa, tip_uredjaja, serijski_broj)
        {
            Flag_Hub = flag_Hub;
            Region = region;
        }
    }

    public class Komunikacioni_cvorBasic : UredjajBasic
    {
        public string Opis { get; set; }
        public int Broj_lokacije { get; set; }
        public string Adresa { get; set; }
        public Glavna_stanicaBasic Glavna_stanica_kom_cvora { get; set; }
        public IList<KorisnikBasic> Korisnik { get; set; }

        public Komunikacioni_cvorBasic()
        {
            Korisnik = new List<KorisnikBasic>();
        }

        public Komunikacioni_cvorBasic(string opis, int broj_lokacije, string adresa,
            string proizvodjac, DateTime datum_pocetka_upotrebe, 
            string razlog_poslednjeg_servisa, string tip_uredjaja, 
            long serijski_broj) : base(proizvodjac, datum_pocetka_upotrebe, razlog_poslednjeg_servisa, tip_uredjaja, serijski_broj)
        {
            Adresa = adresa;
            Opis = opis;
            Broj_lokacije = broj_lokacije;
        }
    }
    #endregion

    #region Korisnik

    public class KorisnikPregled
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Broj { get; set; }
        public string Grad { get; set; }
        public string Tip_korisnika { get; set; }

        public KorisnikPregled() { }

        public KorisnikPregled(string jMBG, string ime, string prezime, string adresa, string broj, string grad, string tip_korisnika)
        {
            JMBG = jMBG;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Broj = broj;
            Grad = grad;
            Tip_korisnika = tip_korisnika;
        }
    }

    public class Fizicka_licaPregled : KorisnikPregled
    {
        public Fizicka_licaPregled()
        {
        }

        public Fizicka_licaPregled(string jMBG, string ime, string prezime, string adresa, string broj, string grad, string tip_korisnika) : base(jMBG, ime, prezime, adresa, broj, grad, tip_korisnika)
        {

        }
    }

    public class Pravna_licaPregled : KorisnikPregled
    {
        public string Ime_kontakt_osobe { get; set; }
        public Int64 Broj_faksa { get; set; }
        public Int64 Poreski_identifikacioni_broj { get; set; }

        public Pravna_licaPregled() { }

        public Pravna_licaPregled(string ime_kontakt_osobe, long broj_faksa, long poreski_identifikacioni_broj, string jMBG, string ime, string prezime, string adresa, string broj, string grad, string tip_korisnika) : base(jMBG, ime, prezime, adresa, broj, grad, tip_korisnika)
        {
            Ime_kontakt_osobe = ime_kontakt_osobe;
            Broj_faksa = broj_faksa;
            Poreski_identifikacioni_broj = poreski_identifikacioni_broj;
        }
    }

    public class KorisnikBasic
    {
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Broj { get; set; }
        public string Grad { get; set; }
        public string Tip_korisnika { get; set; }

        public IList<TelefonBasic> Telefoni_korinika { get; set; }
        public Komunikacioni_cvorBasic Kom_cvor { get; set; }

        public IList<KoristiBasic> Korisnik_koristi { get; set; }

        public KorisnikBasic()
        {
            Korisnik_koristi = new List<KoristiBasic>();
            Telefoni_korinika = new List<TelefonBasic>();
        }

        public KorisnikBasic(string jMBG, string ime, string prezime, string adresa, string broj, string grad, string tip_korisnika)
        {
            JMBG = jMBG;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Broj = broj;
            Grad = grad;
            Tip_korisnika = tip_korisnika;
        }
    }

    public class Fizicka_licaBasic : KorisnikBasic
    {
        public Fizicka_licaBasic() { }

        public Fizicka_licaBasic(string jMBG, string ime, string prezime, string adresa, string broj, string grad, string tip_korisnika) : base(jMBG, ime, prezime, adresa, broj, grad, tip_korisnika)
        {

        }
    }

    public class Pravna_licaBasic : KorisnikBasic
    {
        public string Ime_kontakt_osobe { get; set; }
        public Int64 Broj_faksa { get; set; }
        public Int64 Poreski_identifikacioni_broj { get; set; }

        public Pravna_licaBasic() { }

        public Pravna_licaBasic(string ime_kontakt_osobe, long broj_faksa, long poreski_identifikacioni_broj, string jMBG, string ime, string prezime, string adresa, string broj, string grad, string tip_korisnika) : base(jMBG, ime, prezime, adresa, broj, grad, tip_korisnika)
        {
            Ime_kontakt_osobe = ime_kontakt_osobe;
            Broj_faksa = broj_faksa;
            Poreski_identifikacioni_broj = poreski_identifikacioni_broj;
        }
    }

    #endregion

    #region Telefon

    public class TelefonPregled
    {
        public int Id { get; set; }
        public long telefon { get; set; }

        public TelefonPregled() { }

        public TelefonPregled(int id, long Telefon) { Id = id; telefon = Telefon; }
    }

    public class TelefonBasic
    {
        public int Id { get; set; }
        public KorisnikBasic JMBG_korisnika { get; set; }
        public long telefon { get; set; }

        public TelefonBasic() { }

        public TelefonBasic(int id, long Telefon) { Id = id; telefon = Telefon; }
    }
    #endregion

    #region Koristi
    public class KoristiPregled
    {
        public int Id { get; set; }

        public KoristiPregled() { }

        public KoristiPregled(int id)
        {
            Id = id;
        }
    }

    public class KoristiBasic
    {
        public int Id { get; set; }
        public KorisnikBasic JMBG_Korisnika { get; set; }
        public UslugaBasic ID_Usluge { get; set; }

        public KoristiBasic() { }

        public KoristiBasic(int id)
        {
            Id = id;
        }
    }

    #endregion
}
