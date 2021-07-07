using eVet.Model.Request;
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

namespace eVet.WinUI.Reporti
{
    public partial class reportViewerPregledPrometa : Form
    {
        private readonly APIService _serviceRacuni = new APIService("Racun/Vrste");
        private frmPocetna _pocetna = null;

        public reportViewerPregledPrometa(frmPocetna pocetna)
        {
            InitializeComponent();
            _pocetna = pocetna;
        }

        private async void reportViewerPregledPrometa_Load(object sender, EventArgs e)
        {
            var temp = await _serviceRacuni.Get<List<Model.Racun>>(new RacuniSearchRequest
            {

                Datum=dtpDatum.Value
            });
            var datumTemp = dtpDatum.Value.ToString("dd.MM.yyyy");

            bsPregledPrometa.DataSource = temp;
            ReportDataSource rds = new ReportDataSource("VeterinarskaStanicaModel", bsPregledPrometa);
            
            this.rpvPromet.LocalReport.DataSources.Add(rds);
            this.rpvPromet.LocalReport.SetParameters(new ReportParameter("DatumPrometa", datumTemp));
            this.rpvPromet.RefreshReport();
       
        }
    }
}
