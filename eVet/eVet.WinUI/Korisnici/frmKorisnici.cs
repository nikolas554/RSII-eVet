using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eVet.Model.Request;
using eVet.WinUI.Korisnici;
using eVet.WinUI.Ljubimci;
using Flurl;
using Flurl.Http;

namespace eVet.WinUI
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        private readonly frmPocetna _pocetna;
        public frmKorisnici(frmPocetna pocetna)
        {
            InitializeComponent();
            _pocetna = pocetna;
        }

        private async void btnKorisniciPretraga_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest
            {
                Ime = txtIme.Text,
                Prezime=txtPrezime.Text
            };
            var result = await _apiService.Get<List<Model.Korisnik>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;
        }

        //private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;
        //    frmKorisnicDetalji frm = new frmKorisnicDetalji(int.Parse(id.ToString()));
        //    frm.Show();
        //}

        private void frmKorisnici_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.RowCount > 0)
            {
                var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;
                _pocetna.openChildForm(new frmKorisnicDetalji(_pocetna, (int)id));
            }
          
        }

        //private void btnLjubimci_Click(object sender, EventArgs e)
        //{
        //    if (dgvKorisnici.RowCount > 0)
        //    {
        //        var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;                
        //        frmLjubimci frm = new frmLjubimci((int)id);
        //    frm.MdiParent = this.MdiParent;
        //    frm.WindowState = FormWindowState.Maximized;
        //    frm.Show();
        //    }
        
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            _pocetna.openChildForm(new frmKorisnicDetalji(_pocetna));
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (dgvKorisnici.Columns[e.ColumnIndex].Name == "Ljubimci" && e.RowIndex != -1)
            {
             
             
                var id = dgvKorisnici.Rows[e.RowIndex].Cells[0].Value;

                _pocetna.openChildForm(new frmLjubimci(_pocetna, (int)id));

            }


           else  if (dgvKorisnici.Columns[e.ColumnIndex].Name == "Izmjena" && e.RowIndex != -1)
            {


                var id = dgvKorisnici.Rows[e.RowIndex].Cells[0].Value;

                _pocetna.openChildForm(new frmKorisnicDetalji(_pocetna, (int)id));

            }



        }
    }
}
