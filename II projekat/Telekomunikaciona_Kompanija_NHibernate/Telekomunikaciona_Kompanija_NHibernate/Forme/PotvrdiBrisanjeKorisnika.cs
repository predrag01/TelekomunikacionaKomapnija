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
    public partial class PotvrdiBrisanjeKorisnika : Form
    {
        KorisnikBasic korisnik_Basic;
        public PotvrdiBrisanjeKorisnika()
        {
            InitializeComponent();
        }

        public PotvrdiBrisanjeKorisnika(KorisnikBasic korisnikBasic)
        {
            InitializeComponent();
            korisnik_Basic = korisnikBasic;
        }

        private void PotvrdiBrisanjeKorisnika_Load(object sender, EventArgs e)
        {

        }

        private void DABtn_Click(object sender, EventArgs e)
        {
            DTOmanagerM.obrisiKorisnika(korisnik_Basic);

            MessageBox.Show("Uspesno obrisan korisnik");
            this.Close();
        }

        private void NEBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
