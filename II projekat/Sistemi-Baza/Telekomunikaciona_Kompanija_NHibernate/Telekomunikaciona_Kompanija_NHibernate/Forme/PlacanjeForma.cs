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
    public partial class PlacanjeForma : Form
    {
        public PlacanjeForma()
        {
            InitializeComponent();
        }

        private void PlacanjeForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            placanja.Items.Clear();

            List<PlacanjePregled> placanje =DTOManager.VratiPlacanja();

            foreach(PlacanjePregled p in placanje)
            {
                if(p.TipPlacanja=="Ostvareni protok")
                {
                    ListViewItem item=new ListViewItem(new string[] {p.Id.ToString(), p.TipPlacanja, p.Protok.ToString()});
                    placanja.Items.Add(item);
                }
                else
                {
					ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.TipPlacanja});
					placanja.Items.Add(item);
				}
            }
            placanja.Refresh();
        }

		private void btnDodajPlacanje_Click(object sender, EventArgs e)
		{
			DodajPlacanjeForma forma = new DodajPlacanjeForma();
			forma.ShowDialog();
			PopuniPodacima();
		}

		private void btnIzmeniPlacanje_Click(object sender, EventArgs e)
		{
			if (placanja.SelectedItems.Count == 0)
			{
				MessageBox.Show("Izaberite placanje cije podatke zelite da izmenite!");
				return;
			}

			int id = Int32.Parse(placanja.SelectedItems[0].SubItems[0].Text);
			PlacanjeBasic placanje= DTOManager.VratiPlacanje(id);
            if(placanje.TipPlacanja=="Flat rate")
            {
                FlatRateBasic fr=DTOManager.VratiPlacanjaFR(id);
                IzmeniDetaljeFlatRateForma forma = new IzmeniDetaljeFlatRateForma(fr);
                forma.ShowDialog();
                PopuniPodacima();
            }
            else if(placanje.TipPlacanja=="Ostvareni protok")
            {
                OstavreniProtokBasic op = DTOManager.VratiPlacanjeOP(id);
                IzmeniDetaljeOstvareniProtok forma=new IzmeniDetaljeOstvareniProtok(op);
				forma.ShowDialog();
				PopuniPodacima();
			}
		}

		private void btnObrisiPlacanje_Click(object sender, EventArgs e)
		{
			if (placanja.SelectedItems.Count == 0)
			{
				MessageBox.Show("Izaberite placanje koji zelite da obrisete!");
				return;
			}
			int id = Int32.Parse(placanja.SelectedItems[0].SubItems[0].Text);
			PotvrdiBrisanjePlacanjaForma forma = new PotvrdiBrisanjePlacanjaForma("Da li ste sigurni da zelite da obriste placanje?", id);
			forma.ShowDialog();
			PopuniPodacima();
		}
	}
}
