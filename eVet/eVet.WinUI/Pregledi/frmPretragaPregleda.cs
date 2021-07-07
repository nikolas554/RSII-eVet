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

namespace eVet.WinUI.Pregledi
{
    public partial class frmPretragaPregleda : Form
    {
        APIService _vrsteUslugaService = new APIService("VrstaUsluge");
        APIService _preglediService = new APIService("Pregledi");
        private frmPocetna _pocetna = null;
        public frmPretragaPregleda(frmPocetna pocetna)
        {
            InitializeComponent();
            _pocetna = pocetna;
        }

        private async void frmPretragaPregleda_Load(object sender, EventArgs e)
        {
            var list = await _vrsteUslugaService.Get<List<Model.VrstaUsluge>>(null);
            list.Insert(0, new Model.VrstaUsluge());
            cmbVrstaUsluge.DisplayMember = "Naziv";
            cmbVrstaUsluge.ValueMember = "VrstaUslugeID";
            cmbVrstaUsluge.DataSource = list;



        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            int.TryParse(cmbVrstaUsluge.SelectedValue.ToString(), out int convertVrstaUsluge);
            PregledSearchRequest search = new PregledSearchRequest()
            {
                VrstaUslugeID = convertVrstaUsluge,
                Ime = txtIme.Text,
                Prezime=txtPrezime.Text
            };
            var list = await _preglediService.Get<IList<Model.Pregled>>(search);
            dgvPregledi.AutoGenerateColumns = false;
            dgvPregledi.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dgvPregledi.RowCount > 0)
            {
                var _ljubimacid = dgvPregledi.SelectedRows[0].Cells[1].Value;
                var id = dgvPregledi.SelectedRows[0].Cells[0].Value;
                frmPregledUnos frm = new frmPregledUnos((int)_ljubimacid, (int)id);
                frm.Show();
            }
        }
    }
}
