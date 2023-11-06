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
    public partial class DodajDodatniPaketForma : Form
    {
        TelevizijaBasic televizija;
        public DodajDodatniPaketForma()
        {
            InitializeComponent();
        }

        public DodajDodatniPaketForma(TelevizijaBasic tel)
        {
            InitializeComponent();
            televizija = tel;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodatniPaketKanalaBasic dodatni = new DodatniPaketKanalaBasic();
            dodatni.DodatniPaket = txbDodatniPaket.Text;
            dodatni.Televizija = televizija;
            DTOManager.SacuvajDodatniPaket(dodatni);
            MessageBox.Show("Uspesno ste dodali dodatni paket");
            this.Close();
        }
    }
}
