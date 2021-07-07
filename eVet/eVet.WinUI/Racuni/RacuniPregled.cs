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

namespace eVet.WinUI.Racuni
{
    public partial class RacuniPregled : Form
    {
        APIService _racunService = new APIService("Racun");
        private readonly frmPocetna _pocetna;
        public RacuniPregled(frmPocetna pocetna)
        {
            InitializeComponent();
            _pocetna = pocetna;
        
        }

        private void RacuniPregled_Load(object sender, EventArgs e)
        {

            List<KeyValuePair<int, string>> list1 = new List<KeyValuePair<int, string>>();

            list1.Insert(0, new KeyValuePair<int, string>(0, ""));
            list1.Insert(1, new KeyValuePair<int, string>(1, "Plaćeni"));
            list1.Insert(2, new KeyValuePair<int, string>(2, "Neplaćeni"));

            cmbStatus.DisplayMember = "Value";
            cmbStatus.ValueMember = "Key";
            cmbStatus.DataSource = list1;
        }
        private async void Ucitaj()
        {
            int.TryParse(cmbStatus.SelectedValue.ToString(), out int convertStatus);
            RacuniSearchRequest search = new RacuniSearchRequest()
            {
                Status = convertStatus,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text
            };
            var list = await _racunService.Get<List<Model.Racun>>(search);
            dgvRacuni.AutoGenerateColumns = false;
            dgvRacuni.DataSource = list;
        }
        private void btnTrazi_Click(object sender, EventArgs e)
        {


            Ucitaj();
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dgvRacuni.RowCount > 0)
            {
                var id = dgvRacuni.SelectedRows[0].Cells[0].Value;


                var temp = await _racunService.Update<Model.Racun>((int)id, new RacunUpdateRequest { IsPlacen = true });
                Ucitaj();
                frmRacunReport frm = new frmRacunReport((int)id);
                frm.Show();
            }
     
        }
    }
}
