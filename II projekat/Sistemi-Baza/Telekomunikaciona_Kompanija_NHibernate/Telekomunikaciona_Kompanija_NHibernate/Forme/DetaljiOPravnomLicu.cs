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
    public partial class DetaljiOPravnomLicu : Form
    {
        KorisnikBasic korisnik_Basic;

        public DetaljiOPravnomLicu()
        {
            InitializeComponent();
        }

        public DetaljiOPravnomLicu(KorisnikBasic korisnikBasic)
        {
            InitializeComponent();
            korisnik_Basic = korisnikBasic;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            JMBGLabel.Text = korisnik_Basic.JMBG;
            Pravna_licaPregled lice = DTOmanagerM.vratiPravnoLice(korisnik_Basic.JMBG);
            ImeKonOsobeLabel.Text = lice.Ime_kontakt_osobe;
            BrojFaksaLabel.Text=lice.Broj_faksa.ToString();
            PoreskiBrLabel.Text = lice.Poreski_identifikacioni_broj.ToString();
            Komunikacioni_cvorPregled kc = DTOmanagerM.vratiKCKorisnika(lice.JMBG);
            KomCvorLabel.Text = kc.Serijski_broj.ToString();
            List<TelefonPregled> telefoni = DTOmanagerM.vratiTelefoneKorisnika(lice.JMBG);

            foreach (TelefonPregled t in telefoni)
            {
                TelefoniKorisnikaLB.Items.Add(t.telefon);
            }

            List<UslugaPregled> usluge = DTOmanagerM.vratiUslugeKorisnika(lice.JMBG);

            foreach (UslugaPregled u in usluge)
            {
                UslugeKorisnikaLB.Items.Add(u.Id + " " + u.TipUsluge);
            }

            BrojUgovoraLabel.Text = usluge.Count.ToString();

            TelefoniKorisnikaLB.Refresh();
            UslugeKorisnikaLB.Refresh();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DetaljiOPravnomLicu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
			if (UslugeKorisnikaLB.SelectedIndex > -1)
			{
				string usluga = UslugeKorisnikaLB.SelectedItems[0].ToString();

				string[] idUsluge = usluga.Split(' ');
				if (String.Compare(idUsluge[1], "Televizija") == 0)
				{
					TelevizijaBasic tv = DTOManager.VratiTeleviziju(Int32.Parse(idUsluge[0]));
					DetaljiTelevizijaForma detalji = new DetaljiTelevizijaForma(tv);
					detalji.ShowDialog();
					return;
				}
				else if (idUsluge[1] == "Televizija\n")
				{
					TelevizijaBasic tv = DTOManager.VratiTeleviziju(Int32.Parse(idUsluge[0]));
					DetaljiTelevizijaForma detalji = new DetaljiTelevizijaForma(tv);
					detalji.ShowDialog();
					return;
				}
				if (String.Compare(idUsluge[1], "Telefonija") == 0)
				{
					TelefonijaBasic tel = DTOManager.VratiTelefoniju(int.Parse(idUsluge[0]));
					DetaljiTelefonijaForma detalji = new DetaljiTelefonijaForma(tel);
					detalji.ShowDialog();
					return;
				}
				else if (idUsluge[1] == "Telefonija\n")
				{
					TelefonijaBasic tel = DTOManager.VratiTelefoniju(int.Parse(idUsluge[0]));
					DetaljiTelefonijaForma detalji = new DetaljiTelefonijaForma(tel);
					detalji.ShowDialog();
					return;
				}
				if (String.Compare(idUsluge[1], "Internet") == 0)
				{
					InternetBasic net = DTOManager.VratiInternet(int.Parse(idUsluge[0]));
					DetaljiInternetForma detalji = new DetaljiInternetForma(net);
					detalji.ShowDialog();
					return;
				}
				else if (idUsluge[1] == "Internet\n")
				{
					InternetBasic net = DTOManager.VratiInternet(int.Parse(idUsluge[0]));
					DetaljiInternetForma detalji = new DetaljiInternetForma(net);
					detalji.ShowDialog();
					return;
				}

			}
			else
			{
				MessageBox.Show("Morate da odaberete uslugu cije detalje zelite da vidite.");
				return;
			}
		}
	}
}
