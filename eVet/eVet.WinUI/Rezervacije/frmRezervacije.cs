using eVet.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVet.WinUI.Rezervacije
{

    public partial class frmRezervacije : Form
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacije/Vrste");
        private readonly APIService _rezervacijeUpdateStatusService = new APIService("Rezervacije/UpdateStatus");
        private readonly frmPocetna _pocetna;
        public frmRezervacije(frmPocetna pocetna)
        {
            InitializeComponent();
            _pocetna = pocetna;
        }
        private async void Prikazi(bool? promjena)
        {
            RezervacijeSearchRequest search = new RezervacijeSearchRequest { };
            search.IsKorisnik = false;
            search.IsStatus = promjena;
            dgvRezervacije.Refresh();
            var result = await _rezervacijeService.Get<List<Model.Rezervacije>>(search);
            dgvRezervacije.AutoGenerateColumns = false;
            dgvRezervacije.DataSource = result;
        }

        private void rbNaCekanju_CheckedChanged(object sender, EventArgs e)
        {

           Prikazi(null);
         
        }

        private void dgvRezervacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbPrihvacene_CheckedChanged(object sender, EventArgs e)
        {
            Prikazi(true);
          
        }

        private void rbOdbijene_CheckedChanged(object sender, EventArgs e)
        {
            Prikazi(false);
        }

        private void frmRezervacije_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<int, string>> list1 = new List<KeyValuePair<int, string>>();

            list1.Insert(0, new KeyValuePair<int, string>(0, "Na čekanju"));
            list1.Insert(1, new KeyValuePair<int, string>(1, "Prihvaćene"));
            list1.Insert(2, new KeyValuePair<int, string>(2, "Odbijene"));

            cmbStatus.DisplayMember = "Value";
            cmbStatus.ValueMember = "Key";
            cmbStatus.DataSource = list1;
        }
        private void Ucitaj()
        {
            int.TryParse(cmbStatus.SelectedValue.ToString(), out int convertStatus);
            if (convertStatus == 0)
            {
                Prikazi(null);
            }
            else if (convertStatus == 1)
            {
                Prikazi(true);
            }
            else if (convertStatus == 2)
            {
                Prikazi(false);
            }
        }
    
        private void btnOdbij_Click(object sender, EventArgs e)
        {
            PromjenaStatusa(false);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PromjenaStatusa(true);
        }
        private async void PromjenaStatusa(bool? promjena)
        {
            if (dgvRezervacije.RowCount > 0)
            {
                try
                {

                    var id = dgvRezervacije.SelectedRows[0].Cells[0].Value;
                    var bog = await _rezervacijeUpdateStatusService.Update<Model.Rezervacije>((int)id, promjena);
                    Ucitaj();

                    MessageBox.Show("Uspješna peomjena statusa", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Greška", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            
            int.TryParse(cmbStatus.SelectedValue.ToString(), out int convertStatus);
            if (convertStatus == 0)
            {
                Prikazi(null);
            }
            else if (convertStatus == 1)
            {
                Prikazi(true);
            }
            else if( convertStatus == 2)
            {
                Prikazi(false);
            }
        }
    }
}
