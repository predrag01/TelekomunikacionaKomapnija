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
    public partial class IzmeniUredjajHub : Form
    {
        Glavna_stanicaBasic hub_Basic;
        List<Glavna_stanicaPregled> slobodneGS;
        List<Glavna_stanicaPregled> povezaneGS;
        List<Komunikacioni_cvorPregled> slobodniKomCvorovi;
        List<Komunikacioni_cvorPregled> zauzetiKomCvorovi;

        public IzmeniUredjajHub()
        {
            InitializeComponent();
        }

        public IzmeniUredjajHub(UredjajBasic ub)
        {
            InitializeComponent();
            Glavna_stanicaBasic gs = DTOmanagerM.vratiGS(ub.Serijski_broj);
            hub_Basic = gs;
            slobodneGS = new List<Glavna_stanicaPregled>();
            povezaneGS = new List<Glavna_stanicaPregled>();
            slobodniKomCvorovi = new List<Komunikacioni_cvorPregled>();
            zauzetiKomCvorovi = new List<Komunikacioni_cvorPregled>();

            popuniPodacima();
        }
        public void popuniPodacima()
        {
            DatumPocGSDate.Value = hub_Basic.Datum_pocetka_upotrebe;
            RazlogServisaGSBox.Text = hub_Basic.Razlog_poslednjeg_servisa;
            ProizvodjacGSTB.Text = hub_Basic.Proizvodjac;
            RegionHubTB.Text = hub_Basic.Region;

            List<Glavna_stanicaPregled> hubovi = DTOmanagerM.vratiHubovePregled();
            foreach (Glavna_stanicaPregled h in hubovi)
            {
                SerBrGSCB.Items.Add(h.Serijski_broj);
                slobodneGS.Add(h);
            }

            List<Glavna_stanicaPregled> glavne = DTOmanagerM.vratiGlavneStaniceHuba(hub_Basic.Serijski_broj);
            foreach(Glavna_stanicaPregled g in glavne)
            {
                povezaneGS.Add(g);
                OdveziSerBrGSCB.Items.Add(g.Serijski_broj);
            }

            List<Komunikacioni_cvorPregled> cvorovi = DTOmanagerM.vratiKomCvorovePregled();
            foreach (Komunikacioni_cvorPregled c in cvorovi)
            {
                SerBrKCCB.Items.Add(c.Serijski_broj);
                slobodniKomCvorovi.Add(c);
            }

            List<Komunikacioni_cvorPregled> kom = DTOmanagerM.vratiKCvoroveGS(hub_Basic.Serijski_broj);

            foreach (Komunikacioni_cvorPregled k in kom)
            {
                zauzetiKomCvorovi.Add(k);
                OdveziSerBrKCCB.Items.Add(k.Serijski_broj);
            }
        }

        private void PoveziGSCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (PoveziGSCheckB.Checked)
            {
                SerBrGSCB.Visible = true;
                UnosSerBrGSLabel.Visible = true;
                PoveziGSBtn.Visible = true;
                PoveziGSBtn.Enabled = true;
            }
            if (!PoveziGSCheckB.Checked)
            {
                SerBrGSCB.Visible = false;
                UnosSerBrGSLabel.Visible = false;
                PoveziGSBtn.Visible = false;
                PoveziGSBtn.Enabled = false;
            }
        }

        private void OdveziGSCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (OdveziGSCheckB.Checked)
            {
                OdveziSerBrGSCB.Visible = true;
                label1.Visible = true;
                OdveziGSBtn.Visible = true;
                OdveziGSBtn.Enabled = true;
            }
            if (!OdveziGSCheckB.Checked)
            {
                OdveziSerBrGSCB.Visible = false;
                label1.Visible = false;
                OdveziGSBtn.Visible = false;
                OdveziGSBtn.Enabled = false;
            }
        }

        private void PoveziKCCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (PoveziKCCheckB.Checked)
            {
                SerBrKCCB.Visible = true;
                UnosSerBrKomCvLabel.Visible = true;
                PoveziKCBtn.Visible = true;
                PoveziKCBtn.Enabled = true;
            }
            if (!PoveziKCCheckB.Checked)
            {
                SerBrKCCB.Visible = false;
                UnosSerBrKomCvLabel.Visible = false;
                PoveziKCBtn.Visible = false;
                PoveziKCBtn.Enabled = false;
            }
        }

        private void OdveziKCCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (OdveziKCCheckB.Checked)
            {
                OdveziSerBrKCCB.Visible = true;
                OdvezivanjeUnosSerBrKomCvLabel.Visible = true;
                OdveziKomunikacioniCvorGSBtn.Visible = true;
                OdveziKomunikacioniCvorGSBtn.Enabled = true;
            }

            if (!OdveziKCCheckB.Checked)
            {
                OdveziSerBrKCCB.Visible = false;
                OdvezivanjeUnosSerBrKomCvLabel.Visible = false;
                OdveziKomunikacioniCvorGSBtn.Visible = false;
                OdveziKomunikacioniCvorGSBtn.Enabled = false;
            }
        }

        private void Gotovo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PoveziKCBtn_Click(object sender, EventArgs e)
        {
            if (SerBrKCCB.SelectedIndex > -1)
            {
                Komunikacioni_cvorPregled kc = DTOmanagerM.vratiKC(long.Parse(SerBrKCCB.SelectedItem.ToString()));
                slobodniKomCvorovi.Remove(kc);
                zauzetiKomCvorovi.Add(kc);
                OdveziSerBrKCCB.Items.Add(kc.Serijski_broj);
                SerBrKCCB.Items.Remove(SerBrKCCB.SelectedItem);
                SerBrKCCB.Text = null;

                DTOmanagerM.dodajKCGS(kc.Serijski_broj, hub_Basic.Serijski_broj);

                MessageBox.Show("Uspesno povezan komunikacioni cvor");
                return;
            }
            else
            {
                MessageBox.Show("Morate da selektujete koji komunikacioni cvor zelite da povezete");
                return;
            }
        }

        private void OdveziKomunikacioniCvorGSBtn_Click(object sender, EventArgs e)
        {
            if (OdveziSerBrKCCB.SelectedIndex > -1)
            {
                Komunikacioni_cvorPregled kc = DTOmanagerM.vratiKC(long.Parse(OdveziSerBrKCCB.SelectedItem.ToString()));

                slobodniKomCvorovi.Remove(kc);
                zauzetiKomCvorovi.Add(kc);

                SerBrKCCB.Items.Add(kc.Serijski_broj);
                OdveziSerBrKCCB.Items.Remove(OdveziSerBrKCCB.SelectedItem);
                OdveziSerBrKCCB.Text = null;

                ZaPromenuStanice promena=new ZaPromenuStanice(kc);
                promena.ShowDialog();


                MessageBox.Show("Uspesno uklonjen komunikacioni cvor");
                return;
            }
            else
            {
                MessageBox.Show("Morate da selektujete koji komunikacioni cvor zelite da odvezete");
                return;
            }
        }

        private void SacuvajGSBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ProizvodjacGSTB.Text) && !String.IsNullOrWhiteSpace(ProizvodjacGSTB.Text) && String.Compare(ProizvodjacGSTB.Text, hub_Basic.Proizvodjac) != 0)
            {
                hub_Basic.Proizvodjac = ProizvodjacGSTB.Text;
            }
            if (DatumPocGSDate.Value != hub_Basic.Datum_pocetka_upotrebe)
            {
                hub_Basic.Datum_pocetka_upotrebe = DatumPocGSDate.Value;
            }
            if (!String.IsNullOrEmpty(RazlogServisaGSBox.Text) && !String.IsNullOrWhiteSpace(RazlogServisaGSBox.Text) && String.Compare(RazlogServisaGSBox.Text, hub_Basic.Razlog_poslednjeg_servisa) != 0)
            {
                hub_Basic.Razlog_poslednjeg_servisa = RazlogServisaGSBox.Text;
            }

            if (!String.IsNullOrEmpty(RegionHubTB.Text) && !String.IsNullOrWhiteSpace(RegionHubTB.Text) && String.Compare(RegionHubTB.Text, hub_Basic.Region) != 0)
            {
                hub_Basic.Region = RegionHubTB.Text;
            }

            DTOmanagerM.promeniHub(hub_Basic);

            
            MessageBox.Show("Uspesno promenjen hub");
            this.Close();
        }

        private void OdveziGSBtn_Click(object sender, EventArgs e)
        {
            if (OdveziSerBrGSCB.SelectedIndex > -1)
            {
                Glavna_stanicaPregled stanica = DTOmanagerM.vratiGSPregled(long.Parse(OdveziSerBrGSCB.SelectedItem.ToString()));

                OdveziSerBrGSCB.Items.Remove(OdveziSerBrGSCB.SelectedItem);
                povezaneGS.Remove(stanica);

                slobodneGS.Add(stanica);

                SerBrGSCB.Items.Add(stanica.Serijski_broj);

                DTOmanagerM.odveziGSSaHuba(stanica.Serijski_broj, hub_Basic.Serijski_broj);

                MessageBox.Show("Uspesno odvezana stanica");
                return;
            }
            else
            {
                MessageBox.Show("Morate da odaberete stanicu koju hocete da odvezete");
                return;
            }
        }

        private void PoveziGSBtn_Click(object sender, EventArgs e)
        {
            if (SerBrGSCB.SelectedIndex > -1)
            {
                Glavna_stanicaPregled stanica = DTOmanagerM.vratiGSPregled(long.Parse(SerBrGSCB.SelectedItem.ToString()));

                SerBrGSCB.Items.Remove(SerBrGSCB.SelectedItem);
                slobodneGS.Remove(stanica);
                slobodneGS.Add(stanica);
                OdveziSerBrGSCB.Items.Add(stanica.Serijski_broj);

                DTOmanagerM.poveziGSNaHub(stanica.Serijski_broj, hub_Basic.Serijski_broj);

                MessageBox.Show("Uspesno povezana stanica na hub");
                return;
            }
            else
            {
                MessageBox.Show("Morate da odaberete glavnu stanicu koju hocete da povezete na hub");
                return;
            }
        }
    }
}
