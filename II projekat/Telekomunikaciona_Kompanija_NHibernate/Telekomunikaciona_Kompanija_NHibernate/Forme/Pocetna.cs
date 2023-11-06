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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uredjaji forma=new Uredjaji();
            forma.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Korisnici forma = new Korisnici();
            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelevizijaForma forma = new TelevizijaForma();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelefonijaForma forma = new TelefonijaForma();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InternetForma forma = new InternetForma();
            forma.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PlacanjeForma forma = new PlacanjeForma();
            forma.ShowDialog();
        }
    }
}
