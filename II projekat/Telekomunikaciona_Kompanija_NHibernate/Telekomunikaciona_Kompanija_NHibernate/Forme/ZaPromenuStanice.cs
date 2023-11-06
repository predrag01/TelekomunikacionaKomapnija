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
    public partial class ZaPromenuStanice : Form
    {
        Komunikacioni_cvorBasic kom_Basic;
        public ZaPromenuStanice(Komunikacioni_cvorPregled kc)
        {
            InitializeComponent();
            Komunikacioni_cvorBasic kom = DTOmanagerM.vratiKCBasic(kc.Serijski_broj);
            kom_Basic=kom;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            List<Glavna_stanicaPregled> glavne_stanice = DTOmanagerM.vratiGlavneStanice();

            foreach(Glavna_stanicaPregled g in glavne_stanice)
            {
                comboBox1.Items.Add(g.Serijski_broj);
            }
        }

        private void ZaPromenuStanice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >-1) {

                Glavna_stanicaPregled glavna = DTOmanagerM.vratiGSPregled(long.Parse(comboBox1.SelectedItem.ToString()));

                DTOmanagerM.promeniGSKCa(glavna.Serijski_broj, kom_Basic.Serijski_broj);

                MessageBox.Show("Uspesno promenjena glavna stanica komunikacionog cvora");
                this.Close();      
            }
            else
            {
                MessageBox.Show("Morate da odaberete glavnu stanicu");
                return;
            }
        }
    }
}
