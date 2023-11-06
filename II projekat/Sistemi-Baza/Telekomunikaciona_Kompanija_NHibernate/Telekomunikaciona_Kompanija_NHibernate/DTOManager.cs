using NHibernate;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telekomunikaciona_Kompanija_NHibernate.Entiteti;

namespace Telekomunikaciona_Kompanija_NHibernate
{
    public class DTOManager
    {
        #region Telefonija
        public static void SacuvajTelefoniju(TelefonijaBasic tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefonija telefonija = new Telefonija();

                telefonija.Tip_usluge = tel.TipIUsluge;

                BrojTelefona broj = new BrojTelefona();

                broj.Potroseni_minuti = tel.Brojevi_Telefona[0].Potroseni_minuti;
                broj.Broj = tel.Brojevi_Telefona[0].Broj;
                broj.PripadaTelefoniji = telefonija;
                telefonija.Brojevi_Telefona.Add(broj);

                if (tel.Brojevi_Telefona.Count == 2)
                {
                    BrojTelefona br = new BrojTelefona();

                    br.Potroseni_minuti = tel.Brojevi_Telefona[1].Potroseni_minuti;
                    br.Broj = tel.Brojevi_Telefona[1].Broj;
                    br.PripadaTelefoniji = telefonija;
                    telefonija.Brojevi_Telefona.Add(br);
                }
                else if(tel.Brojevi_Telefona.Count == 3)
                {
					BrojTelefona br = new BrojTelefona();

					br.Potroseni_minuti = tel.Brojevi_Telefona[1].Potroseni_minuti;
					br.Broj = tel.Brojevi_Telefona[1].Broj;
					br.PripadaTelefoniji = telefonija;
					telefonija.Brojevi_Telefona.Add(br);

					BrojTelefona br1 = new BrojTelefona();

					br1.Potroseni_minuti = tel.Brojevi_Telefona[2].Potroseni_minuti;
					br1.Broj = tel.Brojevi_Telefona[2].Broj;
					br1.PripadaTelefoniji = telefonija;
					telefonija.Brojevi_Telefona.Add(br1);
				}
                else
                {
					BrojTelefona br = new BrojTelefona();

					br.Potroseni_minuti = tel.Brojevi_Telefona[1].Potroseni_minuti;
					br.Broj = tel.Brojevi_Telefona[1].Broj;
					br.PripadaTelefoniji = telefonija;
					telefonija.Brojevi_Telefona.Add(br);

					BrojTelefona br1 = new BrojTelefona();

					br1.Potroseni_minuti = tel.Brojevi_Telefona[2].Potroseni_minuti;
					br1.Broj = tel.Brojevi_Telefona[2].Broj;
					br1.PripadaTelefoniji = telefonija;
					telefonija.Brojevi_Telefona.Add(br1);
					
                    BrojTelefona br2 = new BrojTelefona();

					br2.Potroseni_minuti = tel.Brojevi_Telefona[3].Potroseni_minuti;
					br2.Broj = tel.Brojevi_Telefona[3].Broj;
					br2.PripadaTelefoniji = telefonija;
					telefonija.Brojevi_Telefona.Add(br2);
				}

                s.Save(telefonija);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static List<TelefonijaPregled> vratiTelefonije()
        {
            List<TelefonijaPregled> telefonije = new List<TelefonijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Telefonija> tel = s.Query<Telefonija>();

                foreach (Telefonija t in tel)
                {
                    if(t.Brojevi_Telefona.Count==4)
                    {
						telefonije.Add(new TelefonijaPregled(t.Id, t.Tip_usluge, t.Brojevi_Telefona[0].Broj, t.Brojevi_Telefona[0].Potroseni_minuti, t.Brojevi_Telefona[1].Broj, t.Brojevi_Telefona[1].Potroseni_minuti, t.Brojevi_Telefona[2].Broj, t.Brojevi_Telefona[2].Potroseni_minuti, t.Brojevi_Telefona[3].Broj, t.Brojevi_Telefona[3].Potroseni_minuti));
					}
                    else if(t.Brojevi_Telefona.Count==3)
                    {
						telefonije.Add(new TelefonijaPregled(t.Id, t.Tip_usluge, t.Brojevi_Telefona[0].Broj, t.Brojevi_Telefona[0].Potroseni_minuti, t.Brojevi_Telefona[1].Broj, t.Brojevi_Telefona[1].Potroseni_minuti, t.Brojevi_Telefona[2].Broj, t.Brojevi_Telefona[2].Potroseni_minuti));
					}
                    else if (t.Brojevi_Telefona.Count == 2)
                    {
                        telefonije.Add(new TelefonijaPregled(t.Id, t.Tip_usluge, t.Brojevi_Telefona[0].Broj, t.Brojevi_Telefona[0].Potroseni_minuti, t.Brojevi_Telefona[1].Broj, t.Brojevi_Telefona[1].Potroseni_minuti));
                    }
                    else
                    {
                        telefonije.Add(new TelefonijaPregled(t.Id, t.Tip_usluge, t.Brojevi_Telefona[0].Broj, t.Brojevi_Telefona[0].Potroseni_minuti));
                    }
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return telefonije;
        }

        public static TelefonijaBasic VratiTelefoniju(int id)
        {
            TelefonijaBasic tb = new TelefonijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Telefonija t = s.Load<Telefonija>(id);

                tb.Id = t.Id;
                tb.TipIUsluge = t.Tip_usluge;
                BrojTelefonaBasic br = new BrojTelefonaBasic();
                br.Id = t.Brojevi_Telefona[0].Id;
                br.Broj = t.Brojevi_Telefona[0].Broj;
                br.Potroseni_minuti = t.Brojevi_Telefona[0].Potroseni_minuti;
                br.PripadaTelefoniji = tb;
                tb.Brojevi_Telefona.Add(br);

                if (t.Brojevi_Telefona.Count == 2)
                {
                    BrojTelefonaBasic br1 = new BrojTelefonaBasic();
                    br1.Id = t.Brojevi_Telefona[1].Id;
                    br1.Broj = t.Brojevi_Telefona[1].Broj;
                    br1.Potroseni_minuti = t.Brojevi_Telefona[1].Potroseni_minuti;
                    br1.PripadaTelefoniji = tb;
                    tb.Brojevi_Telefona.Add(br1);
                }
                else if(t.Brojevi_Telefona.Count == 3)
                {
					BrojTelefonaBasic br1 = new BrojTelefonaBasic();
					br1.Id = t.Brojevi_Telefona[1].Id;
					br1.Broj = t.Brojevi_Telefona[1].Broj;
					br1.Potroseni_minuti = t.Brojevi_Telefona[1].Potroseni_minuti;
					br1.PripadaTelefoniji = tb;
					tb.Brojevi_Telefona.Add(br1);

					BrojTelefonaBasic br2 = new BrojTelefonaBasic();
					br2.Id = t.Brojevi_Telefona[2].Id;
					br2.Broj = t.Brojevi_Telefona[2].Broj;
					br2.Potroseni_minuti = t.Brojevi_Telefona[2].Potroseni_minuti;
					br2.PripadaTelefoniji = tb;
					tb.Brojevi_Telefona.Add(br2);
				}
                else
                {
					BrojTelefonaBasic br1 = new BrojTelefonaBasic();
					br1.Id = t.Brojevi_Telefona[1].Id;
					br1.Broj = t.Brojevi_Telefona[1].Broj;
					br1.Potroseni_minuti = t.Brojevi_Telefona[1].Potroseni_minuti;
					br1.PripadaTelefoniji = tb;
					tb.Brojevi_Telefona.Add(br1);

					BrojTelefonaBasic br2 = new BrojTelefonaBasic();
					br2.Id = t.Brojevi_Telefona[2].Id;
					br2.Broj = t.Brojevi_Telefona[2].Broj;
					br2.Potroseni_minuti = t.Brojevi_Telefona[2].Potroseni_minuti;
					br2.PripadaTelefoniji = tb;
					tb.Brojevi_Telefona.Add(br2);

					BrojTelefonaBasic br3 = new BrojTelefonaBasic();
					br3.Id = t.Brojevi_Telefona[3].Id;
					br3.Broj = t.Brojevi_Telefona[3].Broj;
					br3.Potroseni_minuti = t.Brojevi_Telefona[3].Potroseni_minuti;
					br3.PripadaTelefoniji = tb;
					tb.Brojevi_Telefona.Add(br3);
				}

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return tb;
        }

        public static void IzmeniTelefoniju(TelefonijaBasic tel)
         {
            try
            {
                ISession s = DataLayer.GetSession();
                Telefonija t = s.Load<Telefonija>(tel.Id);

                if(tel.Brojevi_Telefona.Count>=t.Brojevi_Telefona.Count)
                {
                    for(int i=0;i<t.Brojevi_Telefona.Count;i++)
                    {
						t.Brojevi_Telefona[i].Broj = tel.Brojevi_Telefona[i].Broj;
						t.Brojevi_Telefona[i].Potroseni_minuti = tel.Brojevi_Telefona[i].Potroseni_minuti;
					}
                    for(int i = t.Brojevi_Telefona.Count; i < tel.Brojevi_Telefona.Count; i++)
                    {
						BrojTelefona broj = new BrojTelefona();
						broj.Broj = tel.Brojevi_Telefona[i].Broj;
						broj.Potroseni_minuti = tel.Brojevi_Telefona[i].Potroseni_minuti;
						broj.PripadaTelefoniji = t;
						t.Brojevi_Telefona.Add(broj);
					}
                }
                else
                {
					for (int i = 0; i < tel.Brojevi_Telefona.Count; i++)
					{
						t.Brojevi_Telefona[i].Broj = tel.Brojevi_Telefona[i].Broj;
						t.Brojevi_Telefona[i].Potroseni_minuti = tel.Brojevi_Telefona[i].Potroseni_minuti;
					}
					for (int i = t.Brojevi_Telefona.Count-1; i > tel.Brojevi_Telefona.Count-1; i--)
					{
						s.Delete(t.Brojevi_Telefona[i]);
						t.Brojevi_Telefona.RemoveAt(i);
					}
				}

                s.SaveOrUpdate(t);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void ObrisiTelefoniju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Telefonija telefonija = s.Load<Telefonija>(id);

                s.Delete(telefonija);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Televizija
        public static List<TelevizijaPregled> VratiTelevizije()
        {
            List<TelevizijaPregled> telefonije = new List<TelevizijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Televizija> tel = s.Query<Televizija>();

                foreach (Televizija t in tel)
                {
                    telefonije.Add(new TelevizijaPregled(t.Id, t.Tip_usluge, t.Paket));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return telefonije;
        }

        public static void SacuvajTeleviziju(TelevizijaBasic tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Telefonija telefonija = s.Load<Telefonija>(3);
                Televizija televizija = new Televizija();

                televizija.Tip_usluge = tel.TipIUsluge;
                televizija.Paket = tel.Paket;

                s.Save(televizija);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static TelevizijaBasic VratiTeleviziju(int id)
        {
            TelevizijaBasic tb = new TelevizijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Televizija t = s.Load<Televizija>(id);

                tb.Id = t.Id;
                tb.TipIUsluge = t.Tip_usluge;
                tb.Paket = t.Paket;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return tb;
        }

        public static void IzmeniTeleviziju(TelevizijaBasic tb)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Televizija t = s.Load<Televizija>(tb.Id);

                t.Paket = tb.Paket;

                s.SaveOrUpdate(t);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void ObrisiTeleviziju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Televizija t = s.Load<Televizija>(id);

                s.Delete(t);

                s.Flush();

                s.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Dodatni paketi kanala
        public static List<DodatniPaketKanalaPregled> VratiDodatnePakete(int televizija)
        {
            List<DodatniPaketKanalaPregled> paketi = new List<DodatniPaketKanalaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<DodatniPaketKanala> p = from o in s.Query<DodatniPaketKanala>()
                                                    where o.Televizija.Id == televizija
                                                    select o;
                foreach (DodatniPaketKanala paket in p)
                {
                    paketi.Add(new DodatniPaketKanalaPregled(paket.Id, paket.DodatniPaket));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return paketi;
        }

        public static void SacuvajDodatniPaket(DodatniPaketKanalaBasic paket)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DodatniPaketKanala kanal = new DodatniPaketKanala();

                kanal.DodatniPaket = paket.DodatniPaket;

                Televizija t = s.Load<Televizija>(paket.Televizija.Id);
                kanal.Televizija = t;

                s.Save(kanal);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static DodatniPaketKanalaBasic VratiDodatniPaket(int id)
        {
            DodatniPaketKanalaBasic d = new DodatniPaketKanalaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                DodatniPaketKanala paket = s.Load<DodatniPaketKanala>(id);

                d.Id = paket.Id;
                d.DodatniPaket = paket.DodatniPaket;

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return d;
        }

        public static void IzmeniDodatniPaket(DodatniPaketKanalaBasic paket)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DodatniPaketKanala p = s.Load<DodatniPaketKanala>(paket.Id);

                p.DodatniPaket = paket.DodatniPaket;
                Televizija t = s.Load<Televizija>(paket.Televizija.Id);
                p.Televizija = t;

                s.SaveOrUpdate(p);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        public static void ObrisiDodatniPaketKanala(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                DodatniPaketKanala p = s.Load<DodatniPaketKanala>(id);

                s.Delete(p);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        #endregion

        #region Internet
        public static List<InternetPregled> VratiInternete()
        {
            List<InternetPregled> interneti = new List<InternetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Internet> i = s.Query<Internet>();

                foreach (Internet p in i)
                {
                    interneti.Add(new InternetPregled(p.Id, p.Tip_usluge, p.TipInterneta, p.FlagPrepaid, p.DatumPoslednjeUplate, p.StanjeRacuna));
                }
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return interneti;
        }

        public static void SacuvajInternet(InternetBasic net, OstavreniProtokBasic placanje, FlatRateBasic pl)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internet n = new Internet();
                n.Tip_usluge = net.TipIUsluge;
                n.TipInterneta = net.TipInterneta;
                n.FlagPrepaid = net.FlagPrepaid;
                n.DatumPoslednjeUplate = net.DatumPoslednjeUplate;
                n.StanjeRacuna = net.StanjeRacuna;


                if (placanje != null)
                {
                    OstvareniProtok p = new OstvareniProtok();
                    p.TipPlacanja = placanje.TipPlacanja;
                    p.Protok = placanje.KolicinaOstavrenogProtoka;
                    n.Placanje = p;
                }
                else if (pl != null)
                {
                    FlatRate p = new FlatRate();
                    p.TipPlacanja = pl.TipPlacanja;
                    StatickaAdresa ad = new StatickaAdresa();
                    if (pl.StatickeAdrese.Count > 1)
                    {
                        ad.FlatRate = p;
                        ad.Staticka_Adresa = pl.StatickeAdrese[0].Staticka_Adresa;
                        p.StatickeAdrese.Add(ad);

                        StatickaAdresa ad1 = new StatickaAdresa();
                        ad1.FlatRate = p;
                        ad1.Staticka_Adresa = pl.StatickeAdrese[1].Staticka_Adresa;
                        p.StatickeAdrese.Add(ad1);
                    }
                    else
                    {
                        ad.FlatRate = p;
                        ad.Staticka_Adresa = pl.StatickeAdrese[0].Staticka_Adresa;
                        p.StatickeAdrese.Add(ad);
                    }
                    n.Placanje = p;
                }

                s.Save(n);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static InternetBasic VratiInternet(int id)
        {
            InternetBasic tb = new InternetBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Internet t = s.Load<Internet>(id);

                tb.Id = t.Id;
                tb.TipIUsluge = t.Tip_usluge;
                tb.TipInterneta = t.TipInterneta;
                tb.FlagPrepaid = t.FlagPrepaid;
                tb.DatumPoslednjeUplate = t.DatumPoslednjeUplate;
                tb.StanjeRacuna = t.StanjeRacuna;

                Placanje pl = s.Load<Placanje>(t.Placanje.Id);

                PlacanjeBasic p = new PlacanjeBasic();

                p.Id = pl.Id;
                p.TipPlacanja = pl.TipPlacanja;
                tb.Placanje = p;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return tb;
        }

        public static void IzmeniInternet(InternetBasic net)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internet t = s.Load<Internet>(net.Id);

                t.TipInterneta = net.TipInterneta;
                t.FlagPrepaid = net.FlagPrepaid;
                t.DatumPoslednjeUplate = net.DatumPoslednjeUplate;
                t.StanjeRacuna = net.StanjeRacuna;

                s.SaveOrUpdate(t);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }

        public static void ObrisiInternet(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Internet t = s.Load<Internet>(id);

                s.Delete(t);

                s.Flush();

                s.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Placanje
        public static List<PlacanjePregled> VratiPlacanja()
        {
            List<PlacanjePregled> placanja = new List<PlacanjePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Placanje> i = s.Query<Placanje>();
                foreach (Placanje p in i)
                {
                    if (p.TipPlacanja == "Ostvareni protok")
                    {
                        OstvareniProtok op = s.Load<OstvareniProtok>(p.Id);
                        placanja.Add(new PlacanjePregled(p.Id, p.TipPlacanja, op.Protok));
                    }
                    else
                    {
                        placanja.Add(new PlacanjePregled(p.Id, p.TipPlacanja));
                    }
                }
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return placanja;
        }
        public static PlacanjeBasic VratiPlacanje(int id)
        {
            PlacanjeBasic tb = new PlacanjeBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Placanje t = s.Load<Placanje>(id);

                tb.Id = t.Id;
                tb.TipPlacanja = t.TipPlacanja;

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return tb;
        }
        public static void ObrisiPlacanje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Placanje t = s.Load<Placanje>(id);

                s.Delete(t);

                s.Flush();

                s.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
            #endregion

        #region Ostvareni protok
            public static OstavreniProtokBasic VratiPlacanjeOP(int id)
            {
                OstavreniProtokBasic tb = new OstavreniProtokBasic();
                try
                {
                    ISession s = DataLayer.GetSession();

                    OstvareniProtok t = s.Load<OstvareniProtok>(id);

                    tb.Id = t.Id;
                    tb.TipPlacanja = t.TipPlacanja;
                    tb.KolicinaOstavrenogProtoka = t.Protok;

                    s.Close();

                }
                catch (Exception ec)
                {
                    //handle exceptions
                }
                return tb;
            }

            public static void IzmeniOstvareniProtok(OstavreniProtokBasic placanje)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    OstvareniProtok t = s.Load<OstvareniProtok>(placanje.Id);

                    t.Protok = placanje.KolicinaOstavrenogProtoka;

                    s.SaveOrUpdate(t);

                    s.Flush();

                    s.Close();
                }
                catch (Exception ec)
                {
                    //handle exceptions
                }
            }
            public static void SacuvajOstvareniProtok(OstavreniProtokBasic placanje)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    OstvareniProtok p = new OstvareniProtok();
                    p.TipPlacanja = placanje.TipPlacanja;
                    p.Protok = placanje.KolicinaOstavrenogProtoka;

                    s.Save(p);

                    s.Flush();

                    s.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            #endregion

        #region Flat rate
            public static FlatRateBasic VratiPlacanjaFR(int id)
            {
                FlatRateBasic tb = new FlatRateBasic();
                try
                {
                    ISession s = DataLayer.GetSession();

                    FlatRate t = s.Load<FlatRate>(id);

                    tb.Id = t.Id;
                    tb.TipPlacanja = t.TipPlacanja;

                    StatickaAdresaBasic ad = new StatickaAdresaBasic();
                    ad.Id = t.StatickeAdrese[0].Id;
                    ad.FlataRate = tb;
                    ad.Staticka_Adresa = t.StatickeAdrese[0].Staticka_Adresa;
                    tb.StatickeAdrese.Add(ad);
                    if (t.StatickeAdrese.Count > 1)
                    {
                        StatickaAdresaBasic ad1 = new StatickaAdresaBasic();
                        ad1.Id = t.StatickeAdrese[1].Id;
                        ad1.FlataRate = tb;
                        ad1.Staticka_Adresa = t.StatickeAdrese[1].Staticka_Adresa;
                        tb.StatickeAdrese.Add(ad1);
                    }

                    s.Close();

                }
                catch (Exception ec)
                {
                    //handle exceptions
                }
                return tb;
            }
            public static void IzmeniFlatRate(FlatRateBasic placanje)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    FlatRate t = s.Load<FlatRate>(placanje.Id);

                    if (t.StatickeAdrese.Count == 0)
                    {
                        StatickaAdresa ad1 = new StatickaAdresa();
                        ad1.FlatRate = t;
                        ad1.Staticka_Adresa = placanje.StatickeAdrese[0].Staticka_Adresa;
                        t.StatickeAdrese.Add(ad1);
                    }
                    else
                    {
                        t.StatickeAdrese[0].Staticka_Adresa = placanje.StatickeAdrese[0].Staticka_Adresa;
                    }
                    if (placanje.StatickeAdrese.Count > 1)
                    {
                        if (t.StatickeAdrese.Count > 1)
                        {
                            t.StatickeAdrese[1].Staticka_Adresa = placanje.StatickeAdrese[1].Staticka_Adresa;
                        }
                        else
                        {
                            StatickaAdresa ad = new StatickaAdresa();
                            ad.FlatRate = t;
                            ad.Staticka_Adresa = placanje.StatickeAdrese[1].Staticka_Adresa;
                            t.StatickeAdrese.Add(ad);
                        }
                    }
                    else if (t.StatickeAdrese.Count > 1)
                    {
                        if (placanje.StatickeAdrese.Count < 2)
                        {
                            StatickaAdresa a = s.Load<StatickaAdresa>(t.StatickeAdrese[1].Id);

                            t.StatickeAdrese.RemoveAt(1);

                            s.Delete(a);
                        }
                    }

                    s.SaveOrUpdate(t);

                    s.Flush();

                    s.Close();
                }
                catch (Exception ec)
                {
                    //handle exceptions
                }
            }
            public static void SacuvajFlatRate(FlatRateBasic pl)
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    FlatRate p = new FlatRate();
                    p.TipPlacanja = pl.TipPlacanja;
                    StatickaAdresa ad = new StatickaAdresa();
                    if (pl.StatickeAdrese.Count > 1)
                    {
                        ad.FlatRate = p;
                        ad.Staticka_Adresa = pl.StatickeAdrese[0].Staticka_Adresa;
                        p.StatickeAdrese.Add(ad);

                        StatickaAdresa ad1 = new StatickaAdresa();
                        ad1.FlatRate = p;
                        ad1.Staticka_Adresa = pl.StatickeAdrese[1].Staticka_Adresa;
                        p.StatickeAdrese.Add(ad1);
                    }
                    else
                    {
                        ad.FlatRate = p;
                        ad.Staticka_Adresa = pl.StatickeAdrese[0].Staticka_Adresa;
                        p.StatickeAdrese.Add(ad);
                    }

                    s.Save(p);

                    s.Flush();

                    s.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            #endregion
    }
}

