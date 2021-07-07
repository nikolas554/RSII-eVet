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
    public partial class frmLijekovi : Form
    {
        private readonly APIService _apiService = new APIService("Lijek");
        public frmLijekovi()
        {
            InitializeComponent();
        }

        private async void txtPretraga_Click(object sender, EventArgs e)
        {
            var search = new LijekSearchRequest { 
            Naziv=txtLijekoviPretraga.Text
            
            };

            var result = await _apiService.Get<List<Model.Lijek>>(search);
            dgvLijekovi.AutoGenerateColumns = false;
            dgvLijekovi.DataSource = result;
        }

        private void frmLijekovi_Load(object sender, EventArgs e)
        {

        }
    }
}
