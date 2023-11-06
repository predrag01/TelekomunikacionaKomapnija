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
    public partial class DetaljiOUredjajuHub : Form
    {
        UredjajBasic hub;
        public DetaljiOUredjajuHub()
        {
            InitializeComponent();
        }

        public DetaljiOUredjajuHub(UredjajBasic uredjajBasic)
        {
            InitializeComponent();
            hub = uredjajBasic;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            SerijskiBrojLabel.Text=hub.Serijski_broj.ToString();
            List<Glavna_stanicaPregled> glavne_stanice = DTOmanagerM.vratiGlavneStaniceHuba(hub.Serijski_broj);
            foreach(Glavna_stanicaPregled gs in glavne_stanice)
            {
                SerijskiBrojeviLB.Items.Add(gs.Serijski_broj);
            }

            RazlogServisaLabel.Text=hub.Razlog_poslednjeg_servisa.ToString();

            Glavna_stanicaBasic h = DTOmanagerM.vratiGS(hub.Serijski_broj);

            RegionLabel.Text = h.Region;

            SerijskiBrojeviLB.Refresh();
        }

        private void DetaljiOUredjajuHub_Load(object sender, EventArgs e)
        {

        }
    }
}
