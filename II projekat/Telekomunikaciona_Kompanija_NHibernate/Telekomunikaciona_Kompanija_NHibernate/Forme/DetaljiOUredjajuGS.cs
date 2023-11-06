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
    public partial class DetaljiOUredjajuGS : Form
    {
        UredjajBasic glavna_StanicaBasic;
        public DetaljiOUredjajuGS()
        {
            InitializeComponent();
        }

        public DetaljiOUredjajuGS(UredjajBasic uB)
        {
            InitializeComponent();
            glavna_StanicaBasic = uB;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            SerijskiBrojLabel.Text = glavna_StanicaBasic.Serijski_broj.ToString();
            List<Komunikacioni_cvorPregled> podaci = DTOmanagerM.vratiAdreseKomCvorova(glavna_StanicaBasic.Serijski_broj);
            foreach(Komunikacioni_cvorPregled kc in podaci)
            {
                AdreseKomCvorovaLB.Items.Add(kc.Adresa);
            }
            RazlogServisaLabel.Text=glavna_StanicaBasic.Razlog_poslednjeg_servisa.ToString();

            Glavna_stanicaPregled gs = DTOmanagerM.vratiHubOdabraneStanice(glavna_StanicaBasic.Serijski_broj);

            SerijskiBrojHubaLabel.Text = gs.Serijski_broj.ToString();

            AdreseKomCvorovaLB.Refresh();
        }

        private void DetaljiOUredjajuGS_Load(object sender, EventArgs e)
        {

        }
    }
}
