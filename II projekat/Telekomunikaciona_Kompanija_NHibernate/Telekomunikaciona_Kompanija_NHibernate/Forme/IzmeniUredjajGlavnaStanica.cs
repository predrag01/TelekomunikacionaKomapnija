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
    public partial class IzmeniUredjajGlavnaStanica : Form
    {
        Glavna_stanicaBasic glavna_Basic;
        List<Glavna_stanicaPregled> slobodniHubovi;
        Glavna_stanicaPregled hub;
        List<Komunikacioni_cvorPregled> slobodniKomCvorovi;
        List<Komunikacioni_cvorPregled> zauzetiKomCvorovi;
        public IzmeniUredjajGlavnaStanica()
        {
            InitializeComponent();
        }

        public IzmeniUredjajGlavnaStanica(UredjajBasic ub)
        {
            InitializeComponent();
            Glavna_stanicaBasic gs = DTOmanagerM.vratiGS(ub.Serijski_broj);
            glavna_Basic = gs;
            slobodniHubovi = new List<Glavna_stanicaPregled>();
            hub = new Glavna_stanicaPregled();
            slobodniKomCvorovi = new List<Komunikacioni_cvorPregled>();
            zauzetiKomCvorovi = new List<Komunikacioni_cvorPregled>();

            popuniPodacima();
        }

        public void popuniPodacima()
        {
            DatumPocGSDate.Value = glavna_Basic.Datum_pocetka_upotrebe;
            RazlogServisaGSBox.Text = glavna_Basic.Razlog_poslednjeg_servisa;
            ProizvodjacGSTB.Text = glavna_Basic.Proizvodjac;

            List<Glavna_stanicaPregled> hubovi = DTOmanagerM.vratiHubovePregled();
            foreach(Glavna_stanicaPregled h in hubovi)
            {
                SerBrHubaCB.Items.Add(h.Serijski_broj);
                slobodniHubovi.Add(h);
            }

            hub = DTOmanagerM.vratiHubOdabraneStanice(glavna_Basic.Serijski_broj);
            OdveziSerBrHubCB.Items.Add(hub.Serijski_broj);

            List<Komunikacioni_cvorPregled> cvorovi = DTOmanagerM.vratiKomCvorovePregled();
            foreach(Komunikacioni_cvorPregled c in cvorovi)
            {
                SerBrKCCB.Items.Add(c.Serijski_broj);
                slobodniKomCvorovi.Add(c);
            }

            List<Komunikacioni_cvorPregled> kom = DTOmanagerM.vratiKCvoroveGS(glavna_Basic.Serijski_broj);

            foreach(Komunikacioni_cvorPregled k in kom)
            {
                zauzetiKomCvorovi.Add(k);
                OdveziSerBrKCCB.Items.Add(k.Serijski_broj);
            }
        }

        private void IzmeniUredjajGlavnaStanica_Load(object sender, EventArgs e)
        {

        }

        private void PoveziNaHubCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (PoveziNaHubCheckB.Checked)
            {
                SerBrHubaCB.Visible = true;
                UnosSerBrHubLabel.Visible = true;
                PoveziNaHubBtn.Visible = true;
                PoveziNaHubBtn.Enabled = true;
            }
            if (!PoveziNaHubCheckB.Checked)
            {
                SerBrHubaCB.Visible = false;
                UnosSerBrHubLabel.Visible = false;
                PoveziNaHubBtn.Visible = false;
                PoveziNaHubBtn.Enabled = false;
            }
        }

        private void OdevziSaHubaCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (OdevziSaHubaCheckB.Checked)
            {
                OdveziSerBrHubCB.Visible = true;
                label1.Visible = true;
                OdeveziSaHubaBtn.Visible = true;
                OdeveziSaHubaBtn.Enabled = true;
            }
            if (!OdevziSaHubaCheckB.Checked)
            {
                OdveziSerBrHubCB.Visible = false;
                label1.Visible = false;
                OdeveziSaHubaBtn.Visible = false;
                OdeveziSaHubaBtn.Enabled = false;
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
            if(OdveziKCCheckB.Checked)
            {
                OdveziSerBrKCCB.Visible=true;
                OdvezivanjeUnosSerBrKomCvLabel.Visible=true;
                OdveziKomunikacioniCvorGSBtn.Visible=true;
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

                DTOmanagerM.dodajKCGS(kc.Serijski_broj, glavna_Basic.Serijski_broj);

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

                ZaPromenuStanice promena = new ZaPromenuStanice(kc);
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

        private void PoveziNaHubBtn_Click(object sender, EventArgs e)
        {
            if(SerBrHubaCB.SelectedIndex > -1)
            {
                Glavna_stanicaPregled h = DTOmanagerM.vratiGSPregled(long.Parse(SerBrHubaCB.SelectedItem.ToString()));

                if (OdveziSerBrHubCB.Items.Count == 0)
                {
                    slobodniHubovi.Remove(h);
                    hub = h;
                    OdveziSerBrHubCB.Items.Add(h.Serijski_broj);
                    SerBrHubaCB.Items.Remove(SerBrHubaCB.SelectedItem);

                    DTOmanagerM.promeniHubGSe(h.Serijski_broj, glavna_Basic.Serijski_broj);

                    MessageBox.Show("Uspesno povezana glavna stanica na hub");

                    return;
                }
                else
                {
                    MessageBox.Show("Morate prvo da odvezete glavnu stanicu sa hub-a");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Morate da odaberete na koji hub zelite da povezete stanicu");
                return;
            }
        }

        private void OdeveziSaHubaBtn_Click(object sender, EventArgs e)
        {
            if(OdveziSerBrHubCB.SelectedIndex > -1) { 
            
                Glavna_stanicaPregled h=DTOmanagerM.vratiGSPregled(long.Parse(OdveziSerBrHubCB.SelectedItem.ToString()));
                slobodniHubovi.Add(h);
                hub = null;

                OdveziSerBrHubCB.Items.Clear();
                SerBrHubaCB.Items.Add(h.Serijski_broj);

                MessageBox.Show("Uspesno odvezana stanica sa hub-a");
                return;
            }
            else
            {
                MessageBox.Show("Morate da odaberete hub koji zelite da odvezete");
                return;
            }
        }

        private void Gotovo_Click(object sender, EventArgs e)
        {
            if (OdveziSerBrHubCB.Items.Count != 1)
            {
                MessageBox.Show("Glavna stanica moze i mora biti povezana samo na tacno 1 hub");
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void SacuvajGSBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ProizvodjacGSTB.Text) && !String.IsNullOrWhiteSpace(ProizvodjacGSTB.Text) && String.Compare(ProizvodjacGSTB.Text, glavna_Basic.Proizvodjac) != 0)
            {
                glavna_Basic.Proizvodjac = ProizvodjacGSTB.Text;
            }
            if (DatumPocGSDate.Value != glavna_Basic.Datum_pocetka_upotrebe)
            {
                glavna_Basic.Datum_pocetka_upotrebe = DatumPocGSDate.Value;
            }
            if (!String.IsNullOrEmpty(RazlogServisaGSBox.Text) && !String.IsNullOrWhiteSpace(RazlogServisaGSBox.Text) && String.Compare(RazlogServisaGSBox.Text, glavna_Basic.Razlog_poslednjeg_servisa) != 0)
            {
                glavna_Basic.Razlog_poslednjeg_servisa = RazlogServisaGSBox.Text;
            }

            DTOmanagerM.promeniGS(glavna_Basic);

            if (OdveziSerBrHubCB.Items.Count != 1)
            {
                MessageBox.Show("Glavna stanica moze i mora biti povezana samo na tacno 1 hub");
                return;
            }
            else
            {
                MessageBox.Show("Uspesno promenjena glavna stanica");
                this.Close();
            }
        }

        private void ProglasiZaHubBtn_Click(object sender, EventArgs e)
        {
            DTOmanagerM.proglasiZaHub(glavna_Basic.Serijski_broj);

            MessageBox.Show("Uspesno prograsena stanica za hub");
            IzmeniUredjajHub hubForma = new IzmeniUredjajHub(glavna_Basic);
            hubForma.ShowDialog();
            return;
        }
    }
}
