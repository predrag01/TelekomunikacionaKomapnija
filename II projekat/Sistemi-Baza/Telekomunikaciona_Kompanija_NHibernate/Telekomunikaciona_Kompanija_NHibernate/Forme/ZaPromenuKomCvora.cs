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
    public partial class ZaPromenuKomCvora : Form
    {
        KorisnikBasic korisnik_Basic;
        public ZaPromenuKomCvora(KorisnikPregled korisnik)
        {
            InitializeComponent();
            KorisnikBasic k = DTOmanagerM.vratiKorisnikaBasic(korisnik.JMBG);

            korisnik_Basic = k;

            popuniPodacima();
        }

        public void popuniPodacima()
        {
            List<Komunikacioni_cvorBasic> kom = DTOmanagerM.vratiKomCvorove();

            foreach(Komunikacioni_cvorBasic k in kom)
            {
                comboBox1.Items.Add(k.Serijski_broj);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex > -1)
            {
                Komunikacioni_cvorBasic cvor=DTOmanagerM.vratiKCBasic(long.Parse(comboBox1.SelectedItem.ToString()));

                DTOmanagerM.promeniKCKorisniku(korisnik_Basic.JMBG, cvor);

                MessageBox.Show("Uspesno promenjen komunikacioni cvor korisniku");
                this.Close();
            }
            else
            {
                MessageBox.Show("Morate da odaberete komunikacioni cvor na koji ce korisnik biti povezan");
                return;
            }
        }
    }
}
