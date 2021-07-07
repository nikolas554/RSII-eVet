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

namespace eVet.WinUI.Racuni
{
    public partial class frmRacunReport : Form
    {
        private readonly APIService _service = new APIService("Racun");
        private int _id;
        public frmRacunReport(int racunId)
        {
            InitializeComponent();
            _id = racunId;
        }

        private async void frmRacunReport_Load(object sender, EventArgs e)
        {
            var temp = await _service.Get<List<Model.Racun>>(new RacuniSearchRequest { RacunId = _id });
            RacunBindingSource.DataSource = temp;
            ReportDataSource rds = new ReportDataSource("eVetModel", RacunBindingSource);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
