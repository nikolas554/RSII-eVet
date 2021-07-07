using eVet.WinUI.Ljubimci;
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
    public partial class frmPregledi : Form
    {
        private int _ljubimacid;
        private string _ime;
        private int _korisnikid;
        private readonly APIService _preglediService = new APIService("Pregledi/ljubimac");
        private readonly frmPocetna _pocetna;
        public frmPregledi(frmPocetna pocetna,int ljubimacid, string Ime, int korisnikid)
        {
            InitializeComponent();
            _ljubimacid = ljubimacid;
            _ime = Ime;
            _korisnikid = korisnikid;
            _pocetna = pocetna;
        }

        private async void frmPregledi_Load(object sender, EventArgs e)
        {
            lblLjubimac.Text = _ime;
            var list = await _preglediService.Get<IList<Model.Pregled>>(_ljubimacid);
            dgvPregledi.AutoGenerateColumns = false;
            dgvPregledi.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPregledi.RowCount > 0)
            {
                var id = dgvPregledi.SelectedRows[0].Cells[0].Value;
                frmPregledUnos frm = new frmPregledUnos(_ljubimacid,(int)id);
                frm.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

                frmPregledUnos frm = new frmPregledUnos(_ljubimacid, null);
                frm.Show();
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            _pocetna.openChildForm(new frmLjubimci(_pocetna, _korisnikid));
            //frmLjubimci frm = new frmLjubimci(_korisnikid);
            //frm.MdiParent = frmIndex.ActiveForm;
            //frm.Show();

        }
    }
}

