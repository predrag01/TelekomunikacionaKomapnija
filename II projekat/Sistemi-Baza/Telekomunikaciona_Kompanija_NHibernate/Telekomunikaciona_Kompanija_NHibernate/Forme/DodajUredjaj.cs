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
    public partial class DodajUredjaj : Form
    {

        Glavna_stanicaBasic glavna_StanicaBasic;
        Komunikacioni_cvorBasic komunikacioni_CvorBasic;

        public DodajUredjaj()
        {
            InitializeComponent();
            glavna_StanicaBasic = new Glavna_stanicaBasic();
            komunikacioni_CvorBasic=new Komunikacioni_cvorBasic();
        }

        private void DodajUredjaj_Load(object sender, EventArgs e)
        {
            TipUredjajaCb.Items.Add("Glavna stanica");
            TipUredjajaCb.Items.Add("Hub");
            TipUredjajaCb.Items.Add("Komunikacioni cvor");

            List<Glavna_stanicaBasic> hubovi = DTOmanagerM.vratiHubove();

            foreach (Glavna_stanicaBasic g in hubovi)
            {
               SerBrHubovaCB.Items.Add(g.Serijski_broj);
            }

            List<Glavna_stanicaPregled> gStanice = DTOmanagerM.vratiGlavneStanice();

            foreach (Glavna_stanicaPregled g in gStanice)
            {
                SerBrGSCB.Items.Add(g.Serijski_broj);
            }
        }

        private void DodajUredjajBtn_Click(object sender, EventArgs e)
        {
            bool ima = false;
            if (SerijskiBrojNum.Value > 0)
            {
                List<UredjajPregled> uredjaji = DTOmanagerM.vratiSveUredjaje();

                foreach(UredjajPregled u in uredjaji)
                {
                    if (SerijskiBrojNum.Value == u.Serijski_broj)
                    {
                        ima = true;
                        break;
                    }
                }
                if (ima == true)
                {
                    MessageBox.Show("Na zalost taj serijski broj je vec zauzet");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Morate uneti serijski broj uredjaja");
                return;
            }

            if(String.IsNullOrEmpty(ProizvodjacTB.Text) || String.IsNullOrWhiteSpace(ProizvodjacTB.Text))
            {
                MessageBox.Show("Morate uneti ime proizvodjaca");
                return;
            }
            if (String.IsNullOrEmpty(RazlogServisaBox.Text) || String.IsNullOrWhiteSpace(RazlogServisaBox.Text))
            {
                MessageBox.Show("Morate uneti ime proizvodjaca");
                return;
            }

            if (TipUredjajaCb.SelectedIndex == 1)
            {
                if (String.IsNullOrEmpty(RegionTB.Text) || String.IsNullOrWhiteSpace(RegionTB.Text))
                {
                    MessageBox.Show("Morate uneti region hub-a");
                    return;
                }
                this.glavna_StanicaBasic.Flag_Hub = true;
                this.glavna_StanicaBasic.Region= RegionTB.Text;
            }

            if (TipUredjajaCb.SelectedIndex == 2)
            {
                if (String.IsNullOrEmpty(AdresaTB.Text) || String.IsNullOrWhiteSpace(AdresaTB.Text))
                {
                    MessageBox.Show("Morate uneti adresu komunikacionog cvora");
                    return;
                }

                if (String.IsNullOrEmpty(OpisTB.Text) || String.IsNullOrWhiteSpace(OpisTB.Text))
                {
                    MessageBox.Show("Morate uneti opis komunikacionog cvora");
                    return;
                }


                this.komunikacioni_CvorBasic.Broj_lokacije =(int)BrLokacijeKCNum.Value;
                this.komunikacioni_CvorBasic.Opis=OpisTB.Text;
                Glavna_stanicaBasic glavna_stanica= DTOmanagerM.vratiGS(long.Parse(SerBrGSCB.SelectedItem.ToString()));

                if (glavna_stanica.Komunikacioni_cvor.Count - 1 == 20)
                {
                    MessageBox.Show("Odaberite drugu glavnu stanicu, ova je popunjena.");
                        return;
                }
                this.komunikacioni_CvorBasic.Glavna_stanica_kom_cvora = glavna_stanica;
            }

            if (TipUredjajaCb.SelectedIndex == 0)
            {
                this.glavna_StanicaBasic.Tip_uredjaja = "Glavna stanica";
                this.glavna_StanicaBasic.Flag_Hub = false;

                Glavna_stanicaBasic glavna_stanica = DTOmanagerM.vratiGS(long.Parse(SerBrGSCB.SelectedItem.ToString()));

                if (glavna_stanica.Komunikacioni_cvor.Count - 1 == 20)
                {
                    MessageBox.Show("Odaberite drugu glavnu stanicu, ova je popunjena.");
                    return;
                }

                this.glavna_StanicaBasic.Glavna_stanica_hub =glavna_stanica;

            }
            if (TipUredjajaCb.SelectedIndex == 1)
            {
                this.glavna_StanicaBasic.Tip_uredjaja = "Hub";
            }
            this.glavna_StanicaBasic.Serijski_broj = (long)SerijskiBrojNum.Value;
            this.glavna_StanicaBasic.Proizvodjac = ProizvodjacTB.Text;
            this.glavna_StanicaBasic.Razlog_poslednjeg_servisa=RazlogServisaBox.Text;
            this.glavna_StanicaBasic.Datum_pocetka_upotrebe = DatumPocDate.Value;

            this.komunikacioni_CvorBasic.Tip_uredjaja = "Komunikacioni cvor";
            this.komunikacioni_CvorBasic.Serijski_broj = (long)SerijskiBrojNum.Value;
            this.komunikacioni_CvorBasic.Proizvodjac = ProizvodjacTB.Text;
            this.komunikacioni_CvorBasic.Adresa=AdresaTB.Text;
            this.komunikacioni_CvorBasic.Razlog_poslednjeg_servisa = RazlogServisaBox.Text;
            this.komunikacioni_CvorBasic.Datum_pocetka_upotrebe=DatumPocDate.Value;

            if (TipUredjajaCb.SelectedIndex == 0)
            {
                DTOmanagerM.dodajGS(glavna_StanicaBasic);
            }
            if(TipUredjajaCb.SelectedIndex == 1)
            {
                DTOmanagerM.dodajHub(glavna_StanicaBasic);

            }
            if (TipUredjajaCb.SelectedIndex == 2)
            {
                DTOmanagerM.dodajKC(komunikacioni_CvorBasic);
            }

            MessageBox.Show("Uspesno dodat uredjaj");

            this.Close();
        }

        private void TipUredjajaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TipUredjajaCb.SelectedIndex==0) {

                KomCvorGB.Visible = false;
                GlavnaStanicaGB.Visible = true;
                RegionTB.Visible = false;
                RegionLabel.Visible = false;
                RegionTB.Enabled = false;
                ProglasiHubCheckBox.Checked = false;
                ProglasiHubCheckBox.Enabled = true;
                SerBrHubaGS.Enabled = true;
                SerBrHubaGS.Visible = true;
            }
            if (TipUredjajaCb.SelectedIndex == 1)
            {
                KomCvorGB.Visible = false;
                GlavnaStanicaGB.Visible = true;
                RegionTB.Visible = true;
                RegionLabel.Visible = true;
                RegionTB.Enabled = true;
                ProglasiHubCheckBox.Checked = true;
                ProglasiHubCheckBox.Enabled = false;
                SerBrHubaGS.Enabled = false;
                SerBrHubaGS.Visible = false;
            }

            if (TipUredjajaCb.SelectedIndex == 2)
            {
                GlavnaStanicaGB.Visible = false;
                KomCvorGB.Visible= true;
            }
        }

        private void ProglasiHubCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProglasiHubCheckBox.Checked == true)
            {
                TipUredjajaCb.SelectedIndex = 1;
            }
            if (ProglasiHubCheckBox.Checked == false)
                TipUredjajaCb.SelectedIndex = 0;
        }
    }
}
