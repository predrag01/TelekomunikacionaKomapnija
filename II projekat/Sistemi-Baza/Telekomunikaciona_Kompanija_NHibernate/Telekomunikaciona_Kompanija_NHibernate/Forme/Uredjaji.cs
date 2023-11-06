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
    public partial class Uredjaji : Form
    {
        public Uredjaji()
        {
            InitializeComponent();
        }

        private void OtvoriIzmeniFormubtn_Click(object sender, EventArgs e)
        {
            if (ListaUredjaja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite uredjaj koji zelite da promenite");
                return;
            }

            long serijskiBrojUredjaja = long.Parse(ListaUredjaja.SelectedItems[0].SubItems[0].Text);
            UredjajBasic ub = DTOmanagerM.vratiUredjaj(serijskiBrojUredjaja);

            if (String.Compare(ub.Tip_uredjaja,"Hub")==0)
            {
                IzmeniUredjajHub hubForma = new IzmeniUredjajHub(ub);
                hubForma.ShowDialog();
                this.popuniPodacima();
            }
            else if (String.Compare(ub.Tip_uredjaja, "Glavna stanica") == 0)
            {
                IzmeniUredjajGlavnaStanica glavnaStanicaForma=new IzmeniUredjajGlavnaStanica(ub);
                glavnaStanicaForma.ShowDialog();
                this.popuniPodacima();
            }
            else if (String.Compare(ub.Tip_uredjaja, "Komunikacioni cvor") == 0)
            {
                IzmeniUredjajKomunikacioniCvor komunikacioniCvorForma=new IzmeniUredjajKomunikacioniCvor(ub);
                komunikacioniCvorForma.ShowDialog();
                this.popuniPodacima();
            }
            else
                MessageBox.Show("Greska sa pribavljanjem tipa uredjaja");
        }

        private void Uredjaji_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            ListaUredjaja.Items.Clear();
            List<UredjajPregled> podaci = DTOmanagerM.vratiSveUredjaje();

            foreach(UredjajPregled u in podaci)
            {
                ListViewItem item= new ListViewItem(new string[] {u.Serijski_broj.ToString(), u.Proizvodjac, u.Datum_pocetka_upotrebe.ToString(), u.Tip_uredjaja});
                ListaUredjaja.Items.Add(item);
            }

            ListaUredjaja.Refresh();
        }

        private void OtvoriDodajFormuBtn_Click(object sender, EventArgs e)
        {
            DodajUredjaj formaDodaj= new DodajUredjaj();
            formaDodaj.ShowDialog();
            this.popuniPodacima();
        }

        private void OtvoriObrisiFormuBtn_Click(object sender, EventArgs e)
        {
            if (ListaUredjaja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite uredjaj koji zelite da obrisete");
                return;
            }

            long serijskiBrojUredjaj = long.Parse(ListaUredjaja.SelectedItems[0].SubItems[0].Text);
            UredjajBasic uredjajBasic = DTOmanagerM.vratiUredjaj(serijskiBrojUredjaj);

            if( uredjajBasic == null )
            {
                MessageBox.Show("Greska prilikom vracanja selektovanog uredjaja");
                return;
            }    

            PotvrdiBrisanjeUredjaja potvrdaForma=new PotvrdiBrisanjeUredjaja(uredjajBasic);
            potvrdaForma.ShowDialog();
            this.popuniPodacima();
        }

        private void OtvoriDetaljiUredjajaFormuBtn_Click(object sender, EventArgs e)
        {
            if (ListaUredjaja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite uredjaj koji zelite da vidite detaljnije");
                return;
            }

            long serijskiBrojUredjaja = long.Parse(ListaUredjaja.SelectedItems[0].SubItems[0].Text);
            UredjajBasic uredjajBasic = DTOmanagerM.vratiUredjaj(serijskiBrojUredjaja);

            if(uredjajBasic == null)
            {
                MessageBox.Show("Greska prilikom vracanja selektovanog uredjaja");
                return;
            }

            if (String.Compare(uredjajBasic.Tip_uredjaja, "Hub") == 0)
            {
                DetaljiOUredjajuHub detalji = new DetaljiOUredjajuHub(uredjajBasic);
                detalji.ShowDialog();
            }
            else if (String.Compare(uredjajBasic.Tip_uredjaja, "Glavna stanica") == 0)
            {
                DetaljiOUredjajuGS detalji = new DetaljiOUredjajuGS(uredjajBasic);
                detalji.ShowDialog();
            }
            else if (String.Compare(uredjajBasic.Tip_uredjaja, "Komunikacioni cvor") == 0)
            {
                DetaljiOUredjajuKomCvor detalji = new DetaljiOUredjajuKomCvor(uredjajBasic);
                detalji.ShowDialog();
            }
            else
            {
                MessageBox.Show("Greska sa otvaranjem detalja o ovom uredjaju");
                return;
            }
        }
    }
}
