using eVet.WinUI.Pregledi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVet.WinUI.Ljubimci
{

    public partial class frmLjubimci : Form
    {
        private readonly APIService _ljubimciService = new APIService("Ljubimci/byKorisnik");
        private int _id;
   private frmPocetna _pocetna=null;
        public frmLjubimci(frmPocetna pocetna, int id)
        {
            InitializeComponent();
            _id = id;
            _pocetna = pocetna;
          
        }

        private async void frmLjubimci_Load(object sender, EventArgs e)
        {
            var list = await _ljubimciService.Get<IList<Model.Ljubimac>>(_id);
            dgvLjubimci.AutoGenerateColumns = false;
            dgvLjubimci.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvLjubimci.RowCount > 0)
            {
                var id = dgvLjubimci.SelectedRows[0].Cells[0].Value;
                var Ime = dgvLjubimci.SelectedRows[0].Cells[1].FormattedValue.ToString();
                var korisnikid = dgvLjubimci.SelectedRows[0].Cells[2].Value;
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmLjubimciDodaj frm = new frmLjubimciDodaj(_id, null);
            frm.Show();
        }

        private void dgvLjubimci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
            if (dgvLjubimci.Columns[e.ColumnIndex].Name == "Pregledi" && e.RowIndex != -1)
            {
                var id = dgvLjubimci.Rows[e.RowIndex].Cells[0].Value;
                var korisnikid = dgvLjubimci.Rows[e.RowIndex].Cells[2].Value;
                var Ime = dgvLjubimci.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                _pocetna.openChildForm(new frmPregledi(_pocetna, (int)id, Ime, (int)korisnikid));
       
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            _pocetna.openChildForm(new frmKorisnici(_pocetna));
        }
    }
}
