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
    public partial class DetaljiOUredjajuKomCvor : Form
    {
        UredjajBasic komunikacioni_cvor_basic;
        public DetaljiOUredjajuKomCvor()
        {
            InitializeComponent();
        }

        public DetaljiOUredjajuKomCvor(UredjajBasic uredjajBasic)
        {
            InitializeComponent();
            komunikacioni_cvor_basic = uredjajBasic;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            SerijskiBrojLabel.Text=komunikacioni_cvor_basic.Serijski_broj.ToString();
            Komunikacioni_cvorPregled komunikacioni_Cvor = DTOmanagerM.vratiKC(komunikacioni_cvor_basic.Serijski_broj);
            OpisLabel.Text = komunikacioni_Cvor.Opis;
            RazlogServisaLabel.Text = komunikacioni_Cvor.Razlog_poslednjeg_servisa;
            AdresaLabela.Text = komunikacioni_Cvor.Adresa;
            BrLokacijeLabela.Text = komunikacioni_Cvor.Broj_lokacije.ToString();
            Glavna_stanicaPregled gs = DTOmanagerM.vratiGlavnuStanicuKC(komunikacioni_cvor_basic.Serijski_broj);
            SerijskiBrojGlavneStaniceLabel.Text=gs.Serijski_broj.ToString();

            List<KorisnikPregled> korisnici = DTOmanagerM.vratiKorisnikeKC(komunikacioni_cvor_basic.Serijski_broj);

            foreach(KorisnikPregled k in korisnici)
            {
                KorisniciLB.Items.Add(k.JMBG + " " + k.Ime + " " + k.Prezime);
            }

            KorisniciLB.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DetaljiOUredjajuKomCvor_Load(object sender, EventArgs e)
        {

        }
    }
}
