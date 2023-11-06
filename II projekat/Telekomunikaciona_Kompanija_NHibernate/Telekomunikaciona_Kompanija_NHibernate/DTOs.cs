using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;
            using Telekomunikaciona_Kompanija_NHibernate.Entiteti;

namespace Telekomunikaciona_Kompanija_NHibernate
    {
        #region Usluga
        public class UslugaPregled
        {
            public int Id { get; set; }
            public string TipUsluge { get; set; }

            public UslugaPregled()
            {

            }

            public UslugaPregled(int id, string tip)
            {
                Id = id;
                TipUsluge = tip;
            }
        }

        public class TelefonijaPregled : UslugaPregled
        {
            public int BrojTelefona1 { get; set; }
            public int BrojTelefona2 { get; set; }
		    public int BrojTelefona3 { get; set; }
		    public int BrojTelefona4 { get; set; }
		    public int PotroseniMinuti1 { get; set; }
            public int PotroseniMinuti2 { get; set; }
		    public int PotroseniMinuti3 { get; set; }
		    public int PotroseniMinuti4 { get; set; }
		public TelefonijaPregled(int id, string tip, int br1, int min, int br2, int min2) : base(id, tip)
            {
                BrojTelefona1 = br1;
                BrojTelefona2 = br2;
                PotroseniMinuti1 = min;
                PotroseniMinuti2 = min2;
            }
        public TelefonijaPregled(int id, string tip, int br1, int min) : base(id, tip)
        {
            BrojTelefona1 = br1;
            PotroseniMinuti1 = min;
        }
        public TelefonijaPregled(int id, string tip, int br1, int min, int br2, int min2, int br3, int min3) : base(id, tip)
        {
			BrojTelefona1 = br1;
			BrojTelefona2 = br2;
            BrojTelefona3 = br3;
			PotroseniMinuti1 = min;
			PotroseniMinuti2 = min2;
            PotroseniMinuti3 = min3;
		}
		public TelefonijaPregled(int id, string tip, int br1, int min, int br2, int min2, int br3, int min3, int br4, int min4) : base(id, tip)
		{
			BrojTelefona1 = br1;
			BrojTelefona2 = br2;
			BrojTelefona3 = br3;
            BrojTelefona4= br4;
			PotroseniMinuti1 = min;
			PotroseniMinuti2 = min2;
			PotroseniMinuti3 = min3;
            PotroseniMinuti4 = min4;
		}
	}

        public class TelevizijaPregled : UslugaPregled
        {
            public string Paket { get; set; }
            public TelevizijaPregled(int id, string tip, string paket) : base(id, tip)
            {
                Paket = paket;
            }   
    }

        public class InternetPregled : UslugaPregled
        {
            public string TipInterneta { get; set; }
            public bool FlagPrepaid { get; set; }

            public DateTime DatumPoslednjeUplate { get; set; }
            public int StanjeRacuna { get; set; }
            public InternetPregled(int id, string tip, string tipInterneta, bool prepaid,
                DateTime poslednjauplata, int stanjeRacuna) : base(id, tip)
            {
                TipInterneta = tipInterneta;
                FlagPrepaid = prepaid;
                DatumPoslednjeUplate = poslednjauplata;
                StanjeRacuna = stanjeRacuna;
            }
        }

        public class UslugaBasic
        {
            public int Id { get; set; }
            public string TipIUsluge { get; set; }
            public UslugaBasic()
            {

            }

            public UslugaBasic(int id, string tip)
            {
                Id = id;
                TipIUsluge = tip;
            }
        }

        public class TelefonijaBasic : UslugaBasic
        {
            public virtual IList<BrojTelefonaBasic> Brojevi_Telefona { get; set; }
            public TelefonijaBasic()
            {
                Brojevi_Telefona = new List<BrojTelefonaBasic>();
            }
            public TelefonijaBasic(int id, string tip) : base(id, tip)
            {

            }
        }

        public class TelevizijaBasic : UslugaBasic
        {
            public string Paket { get; set; }
            public virtual IList<DodatniPaketKanalaBasic> DodatniPaketiKanala { get; set; }
            public TelevizijaBasic()
            {
                DodatniPaketiKanala = new List<DodatniPaketKanalaBasic>();
            }
            public TelevizijaBasic(int id, string tip, string paket) : base(id, tip)
            {
                Paket = paket;
            }
        }

        public class InternetBasic : UslugaBasic
        {
            public string TipInterneta { get; set; }
            public bool FlagPrepaid { get; set; }

            public DateTime DatumPoslednjeUplate { get; set; }
            public int StanjeRacuna { get; set; }
            public PlacanjeBasic Placanje { get; set; }
            public InternetBasic()
            {

            }
            public InternetBasic(int id, string tip, string tipInterneta, bool prepaid,
                DateTime poslednjauplata, int stanjeRacuna) : base(id, tip)
            {
                TipInterneta = tipInterneta;
                FlagPrepaid = prepaid;
                DatumPoslednjeUplate = poslednjauplata;
                StanjeRacuna = stanjeRacuna;
            }
        }
        #endregion

        #region Broj telefona
        public class BrojTelefonaPregled
        {
            public int Id { get; set; }
            public int Broj { get; set; }
            public int Potroseni_minuti { get; set; }
            public BrojTelefonaPregled()
            {

            }
            public BrojTelefonaPregled(int id, int br, int potroseni)
            {
                Id = id;
                Broj = br;
                Potroseni_minuti = potroseni;
            }
        }

        public class BrojTelefonaBasic
        {
            public int Id { get; set; }
            public int Broj { get; set; }
            public int Potroseni_minuti { get; set; }
            public TelefonijaBasic PripadaTelefoniji { get; set; }
            public BrojTelefonaBasic()
            {

            }
            public BrojTelefonaBasic(int id, int br, int potroseni)
            {
                Id = id;
                Broj = br;
                Potroseni_minuti = potroseni;
            }
        }
        #endregion

        #region Dodatni paket kanala
        public class DodatniPaketKanalaPregled
        {
            public int Id { get; set; }
            public string DodatniPaket { get; set; }
            public DodatniPaketKanalaPregled()
            {

            }
            public DodatniPaketKanalaPregled(int id, string dodatni)
            {
                Id = id;
                DodatniPaket = dodatni;
            }
        }
        public class DodatniPaketKanalaBasic
        {
            public int Id { get; set; }
            public string DodatniPaket { get; set; }
            public TelevizijaBasic Televizija { get; set; }
            public DodatniPaketKanalaBasic()
            {

            }
            public DodatniPaketKanalaBasic(int id, string dodatni)
            {
                Id = id;
                DodatniPaket = dodatni;
            }
        }
        #endregion

        #region Placanje
        public class PlacanjePregled
        {
            public int Id { get; set; }
            public string TipPlacanja { get; set; }
            public int Protok { get; set; }

        public PlacanjePregled()
            {

            }
            public PlacanjePregled(int id, string tip)
            {
                Id = id;
                TipPlacanja = tip;
            }
            public PlacanjePregled(int id, string tip, int protok)
            {
                Id = id;
                TipPlacanja = tip;
                Protok = protok;
            }
    }

        public class FlatRatePregled : PlacanjePregled
        {
            public FlatRatePregled()
            {

            }
            public FlatRatePregled(int id, string tip) : base(id, tip)
            {

            }
        }

        public class OstavreniProtokPregled : PlacanjePregled
        {
            public int KolicinaOstavrenogProtoka { get; set; }
            public OstavreniProtokPregled()
            {

            }
            public OstavreniProtokPregled(int id, string tip, int ostvareno) : base(id, tip)
            {
                KolicinaOstavrenogProtoka = ostvareno;
            }
        }

        public class PlacanjeBasic
        {
            public int Id { get; set; }
            public string TipPlacanja { get; set; }

            public PlacanjeBasic()
            {
                
            }
            public PlacanjeBasic(int id, string tip)
            {
                Id = id;
                TipPlacanja = tip;
            }
        }

        public class FlatRateBasic : PlacanjeBasic
        {
            public IList<StatickaAdresaBasic> StatickeAdrese { get; set; }
            public FlatRateBasic()
            {
                StatickeAdrese = new List<StatickaAdresaBasic>();
            }
            public FlatRateBasic(int id, string tip) : base(id, tip)
            {

            }
        }

        public class OstavreniProtokBasic : PlacanjeBasic
        {
            public int KolicinaOstavrenogProtoka { get; set; }
            public OstavreniProtokBasic()
            {

            }
            public OstavreniProtokBasic(int id, string tip, int ostvareno) : base(id, tip)
            {
                KolicinaOstavrenogProtoka = ostvareno;
            }
        }
        #endregion

        #region Staticka adresa
        public class StatickaAdresaPregled
        {
            public int Id { get; set; }
            public string Staticka_Adresa { get; set; }
            public StatickaAdresaPregled()
            {

            }
            public StatickaAdresaPregled(int id, string adr)
            {
                Id = id;
                Staticka_Adresa = adr;
            }
        }
        public class StatickaAdresaBasic
        {
            public int Id { get; set; }
            public string Staticka_Adresa { get; set; }
            public FlatRateBasic FlataRate { get; set; }
            public StatickaAdresaBasic()
            {

            }
            public StatickaAdresaBasic(int id, string adr)
            {
                Id = id;
                Staticka_Adresa = adr;
            }
        }
        #endregion
    } 