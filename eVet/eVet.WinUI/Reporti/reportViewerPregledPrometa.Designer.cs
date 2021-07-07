
namespace eVet.WinUI.Reporti
{
    partial class reportViewerPregledPrometa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rpvPromet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.bsPregledPrometa = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsPregledPrometa)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvPromet
            // 
            this.rpvPromet.LocalReport.ReportEmbeddedResource = "eVet.WinUI.Reporti.rptPregledPrometa.rdlc";
            this.rpvPromet.Location = new System.Drawing.Point(55, 103);
            this.rpvPromet.Name = "rpvPromet";
            this.rpvPromet.ServerReport.BearerToken = null;
            this.rpvPromet.Size = new System.Drawing.Size(979, 438);
            this.rpvPromet.TabIndex = 0;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(467, 37);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 1;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.reportViewerPregledPrometa_Load);
            // 
            // reportViewerPregledPrometa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 616);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.rpvPromet);
            this.Name = "reportViewerPregledPrometa";
            this.Text = "reportViewerPregledPrometa";
            this.Load += new System.EventHandler(this.reportViewerPregledPrometa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPregledPrometa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPromet;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.BindingSource bsPregledPrometa;
    }
}