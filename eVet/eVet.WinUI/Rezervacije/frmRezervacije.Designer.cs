
namespace eVet.WinUI.Rezervacije
{
    partial class frmRezervacije
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.RezervacijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaUslugeNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRezervacije);
            this.groupBox1.Location = new System.Drawing.Point(28, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacije";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaId,
            this.KlijentIme,
            this.VrstaUslugeNaziv,
            this.Datum,
            this.TerminIme,
            this.Napomena});
            this.dgvRezervacije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRezervacije.Location = new System.Drawing.Point(3, 16);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(1038, 324);
            this.dgvRezervacije.TabIndex = 0;
            this.dgvRezervacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervacije_CellContentClick);
            // 
            // btnOdobri
            // 
            this.btnOdobri.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOdobri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdobri.Location = new System.Drawing.Point(847, 88);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(108, 51);
            this.btnOdobri.TabIndex = 4;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = false;
            this.btnOdobri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdbij
            // 
            this.btnOdbij.BackColor = System.Drawing.Color.LightCoral;
            this.btnOdbij.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdbij.Location = new System.Drawing.Point(961, 88);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(108, 51);
            this.btnOdbij.TabIndex = 5;
            this.btnOdbij.Text = "Odbij";
            this.btnOdbij.UseVisualStyleBackColor = false;
            this.btnOdbij.Click += new System.EventHandler(this.btnOdbij_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(31, 80);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(356, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(407, 78);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 7;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // RezervacijaId
            // 
            this.RezervacijaId.DataPropertyName = "RezervacijaId";
            this.RezervacijaId.HeaderText = "RezervacijaId";
            this.RezervacijaId.Name = "RezervacijaId";
            this.RezervacijaId.ReadOnly = true;
            this.RezervacijaId.Visible = false;
            // 
            // KlijentIme
            // 
            this.KlijentIme.DataPropertyName = "KlijentIme";
            this.KlijentIme.HeaderText = "Klijent";
            this.KlijentIme.Name = "KlijentIme";
            this.KlijentIme.ReadOnly = true;
            this.KlijentIme.Width = 250;
            // 
            // VrstaUslugeNaziv
            // 
            this.VrstaUslugeNaziv.DataPropertyName = "VrstaUslugeNaziv";
            this.VrstaUslugeNaziv.HeaderText = "Vrsta usluge";
            this.VrstaUslugeNaziv.Name = "VrstaUslugeNaziv";
            this.VrstaUslugeNaziv.ReadOnly = true;
            this.VrstaUslugeNaziv.Width = 150;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // TerminIme
            // 
            this.TerminIme.DataPropertyName = "TerminIme";
            this.TerminIme.HeaderText = "Termin";
            this.TerminIme.Name = "TerminIme";
            this.TerminIme.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            this.Napomena.Width = 300;
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 570);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnOdbij);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRezervacije";
            this.Text = "frmRezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaUslugeNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
    }
}