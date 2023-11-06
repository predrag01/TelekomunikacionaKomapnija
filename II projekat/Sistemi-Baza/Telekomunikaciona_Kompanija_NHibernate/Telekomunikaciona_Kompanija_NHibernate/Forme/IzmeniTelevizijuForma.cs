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
    public partial class IzmeniTelevizijuForma : Form
    {
        TelevizijaBasic televizija;
        public IzmeniTelevizijuForma()
        {
            InitializeComponent();
        }
        public IzmeniTelevizijuForma(TelevizijaBasic tel)
        {
            InitializeComponent();
            televizija = tel;
        }

        private void IzmeniTelevizijuForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }
        public void PopuniPodacima()
        {
            txbPaket.Text=televizija.Paket;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            televizija.Paket= txbPaket.Text;
            DTOManager.IzmeniTeleviziju(televizija);
            this.Close();
        }
    }
}
