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
    public partial class PotvrdiBrisanjeUredjaja : Form
    {
        UredjajBasic uredjaj_Basic;
        public PotvrdiBrisanjeUredjaja()
        {
            InitializeComponent();
        }

        public PotvrdiBrisanjeUredjaja(UredjajBasic uredjaj)
        {
            InitializeComponent();
            uredjaj_Basic= uredjaj;
        }

        private void PotvrdiBrisanjeUredjaja_Load(object sender, EventArgs e)
        {

        }

        private void DABtn_Click(object sender, EventArgs e)
        {
            DTOmanagerM.obrisiUredjaj(uredjaj_Basic);

            MessageBox.Show("Uspesno obrisan uredjaj");

            this.Close();
        }

        private void NEBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
