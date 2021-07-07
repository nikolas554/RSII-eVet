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

namespace eVet.WinUI.Lijekovi
{
    public partial class frmLijekoviDetalji : Form
    {
        private readonly APIService _vrsteLijekova = new APIService("VrsteLijekova");
        private readonly APIService _lijekoviService = new APIService("Lijek");
        public frmLijekoviDetalji()
        {
            InitializeComponent();
        }

        private void cmbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmLijekoviDetalji_Load(object sender, EventArgs e)
        {
            
        }
 

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new LijekUpsertRequest()
            {
           Cijena=int.Parse(txtCijena.Text),
           Naziv=txtNaziv.Text,
            };
            var entity = await _lijekoviService.Insert<Model.Lijek>(request);

            if (entity != null)
            {
                MessageBox.Show("Uspješno izvršeno");
            }
        }
    }
}
