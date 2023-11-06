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
    public partial class InternetForma : Form
    {
        public InternetForma()
        {
            InitializeComponent();
        }

        private void InternetForma_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        public void PopuniPodacima()
        {
            interneti.Items.Clear();
            List<InternetPregled> podaci = DTOManager.VratiInternete();

            foreach (InternetPregled p in podaci)
            {
                if (p.FlagPrepaid)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.TipInterneta, p.DatumPoslednjeUplate.ToShortDateString(), p.StanjeRacuna.ToString()});
                    interneti.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(), p.TipInterneta, "", "", });
                    interneti.Items.Add(item);
                }
            }
            interneti.Refresh();
        }

        private void btnDodajInternet_Click(object sender, EventArgs e)
        {
            DodajInternetForma forma=new DodajInternetForma();
            forma.ShowDialog();
            PopuniPodacima();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

		private void btnIzmeniNet_Click(object sender, EventArgs e)
		{
			if (interneti.SelectedItems.Count == 0)
			{
				MessageBox.Show("Izaberite internet cije podatke zelite da izmenite!");
				return;
			}

			int id = Int32.Parse(interneti.SelectedItems[0].SubItems[0].Text);
			InternetBasic internet = DTOManager.VratiInternet(id);
			IzmeniInternetForma forma = new IzmeniInternetForma(internet);
			forma.ShowDialog();
			PopuniPodacima();
		}

		private void btnObrisiNet_Click(object sender, EventArgs e)
		{
			if (interneti.SelectedItems.Count == 0)
			{
				MessageBox.Show("Izaberite internet koji zelite da obrisete!");
				return;
			}
			int id = Int32.Parse(interneti.SelectedItems[0].SubItems[0].Text);
			PotvrdiBrisanjeInternetaForma forma = new PotvrdiBrisanjeInternetaForma("Da li ste sigurni da zelite da obriste internet?", id);
			forma.ShowDialog();
            PopuniPodacima();
		}

		private void btnDetaljiPlacanja_Click(object sender, EventArgs e)
		{
			if (interneti.SelectedItems.Count == 0)
			{
				MessageBox.Show("Izaberite internet za koji zelite da videte detalje placanja!");
				return;
			}
			int id = Int32.Parse(interneti.SelectedItems[0].SubItems[0].Text);
            InternetBasic net=DTOManager.VratiInternet(id);
            if (net.Placanje.TipPlacanja == "Ostvareni protok")
            {
                OstavreniProtokBasic placanje = DTOManager.VratiPlacanjeOP(net.Placanje.Id);
				DetaljiOstvareniPtotokForma forma = new DetaljiOstvareniPtotokForma(placanje);
                forma.ShowDialog();
                PopuniPodacima();
            }
            else
            {
                FlatRateBasic placanje = DTOManager.VratiPlacanjaFR(net.Placanje.Id);
                DetaljiFlatRateForma forma =new DetaljiFlatRateForma(placanje);
                forma.ShowDialog();
				PopuniPodacima();
			}
		}
	}
}
