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
    public partial class TelefonijaForma : Form
    {
        public TelefonijaForma()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelefonijaForma_Load(object sender, EventArgs e)
        {
            this.Text = "Telefonija";
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            telefonije.Items.Clear();
            List<TelefonijaPregled> podaci = DTOManager.vratiTelefonije();

            foreach (TelefonijaPregled p in podaci)
            {
                if(p.BrojTelefona2==0)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.TipUsluge, p.BrojTelefona1.ToString(), p.PotroseniMinuti1.ToString() });
                    telefonije.Items.Add(item);
                }
                else if(p.BrojTelefona3==0) 
                {
                    ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.TipUsluge, p.BrojTelefona1.ToString(), p.PotroseniMinuti1.ToString(), p.BrojTelefona2.ToString(), p.PotroseniMinuti2.ToString() });
                    telefonije.Items.Add(item);
                }
                else if(p.BrojTelefona4==0)
                {
					ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.TipUsluge, p.BrojTelefona1.ToString(), p.PotroseniMinuti1.ToString(), p.BrojTelefona2.ToString(), p.PotroseniMinuti2.ToString(), p.BrojTelefona3.ToString(), p.PotroseniMinuti3.ToString() });
					telefonije.Items.Add(item);
				}
                else
                {
					ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.TipUsluge, p.BrojTelefona1.ToString(), p.PotroseniMinuti1.ToString(), p.BrojTelefona2.ToString(), p.PotroseniMinuti2.ToString(), p.BrojTelefona3.ToString(), p.PotroseniMinuti3.ToString(), p.BrojTelefona4.ToString(), p.PotroseniMinuti4.ToString() });
					telefonije.Items.Add(item);
				}
            }
            telefonije.Refresh();
        }

        private void btnDodajTelefoniju_Click(object sender, EventArgs e)
        {
            DodajTelefonijuForma forma = new DodajTelefonijuForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnIZmeniTelefoniju_Click(object sender, EventArgs e)
        {
            if (telefonije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite telefoniju cije podatke zelite da izmenite!");
                return;
            }

            int id = Int32.Parse(telefonije.SelectedItems[0].SubItems[0].Text);
            TelefonijaBasic telefonija= DTOManager.VratiTelefoniju(id);
            IzmeniTelefonijuForma forma = new IzmeniTelefonijuForma(telefonija);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisiTelefoniju_Click(object sender, EventArgs e)
        {
            if (telefonije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite telefoniju koje zelite da obrisete!");
                return;
            }

            int id = Int32.Parse(telefonije.SelectedItems[0].SubItems[0].Text);
			PotvrdiBrisanjeTelefonijeForma forma = new PotvrdiBrisanjeTelefonijeForma("Da li ste sigurni da zelite da obriste telefoniju?", id);
			forma.ShowDialog();
			popuniPodacima();
		}
    }
}
