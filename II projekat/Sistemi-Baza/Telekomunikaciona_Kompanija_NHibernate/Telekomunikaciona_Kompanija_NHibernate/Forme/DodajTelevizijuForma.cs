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
    public partial class DodajTelevizijuForma : Form
    {
        public DodajTelevizijuForma()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            TelevizijaBasic t=new TelevizijaBasic();
            t.TipIUsluge = "Televizija";
            t.Paket=txbPaket.Text;
            DTOManager.SacuvajTeleviziju(t);
            this.Close();
        }
    }
}
