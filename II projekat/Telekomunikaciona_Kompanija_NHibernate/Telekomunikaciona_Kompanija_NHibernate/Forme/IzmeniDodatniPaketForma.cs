using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telekomunikaciona_Kompanija_NHibernate.Entiteti;

namespace Telekomunikaciona_Kompanija_NHibernate.Forme
{
    public partial class IzmeniDodatniPaketForma : Form
    {
        DodatniPaketKanalaBasic paket;
        TelevizijaBasic televizija;
        public IzmeniDodatniPaketForma()
        {
            InitializeComponent();
        }
        public IzmeniDodatniPaketForma(DodatniPaketKanalaBasic p, TelevizijaBasic televizija)
        {
            InitializeComponent();
            paket = p;
            this.televizija = televizija;
        }

        private void IzmeniDodatniPaketForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            txbDodatniPaket.Text = paket.DodatniPaket;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            paket.DodatniPaket = txbDodatniPaket.Text;
            paket.Televizija= televizija;
            DTOManager.IzmeniDodatniPaket(paket);
            this.Close();
        }
    }
}
