using Microsoft.Reporting.WinForms;
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
    public partial class reportViewerTopKorisnici : Form
    {
        private readonly APIService _service = new APIService("Korisnici/gettop");
        private readonly frmPocetna _pocetna;
        public reportViewerTopKorisnici(frmPocetna pocetna)
        {
            InitializeComponent();
            _pocetna = pocetna;
        }

        private async void reportViewerTopKorisnici_Load(object sender, EventArgs e)
        {
            var temp = await _service.Get<List<Model.Korisnik>>(null);
            KorisnikBindingSource.DataSource=temp;
            ReportDataSource rds = new ReportDataSource("eVetModel1", KorisnikBindingSource);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();



        }
    }
}
