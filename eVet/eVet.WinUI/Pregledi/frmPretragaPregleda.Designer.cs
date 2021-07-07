
namespace eVet.WinUI.Pregledi
{
    partial class frmPretragaPregleda
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVrstaUsluge = new System.Windows.Forms.ComboBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.PregledID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LjubimacD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikLljubimacIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaUslugeNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregledi = new System.Windows.Forms.GroupBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            this.Pregledi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta usluge";
            // 
            // cmbVrstaUsluge
            // 
            this.cmbVrstaUsluge.FormattingEnabled = true;
            this.cmbVrstaUsluge.Location = new System.Drawing.Point(26, 47);
            this.cmbVrstaUsluge.Name = "cmbVrstaUsluge";
            this.cmbVrstaUsluge.Size = new System.Drawing.Size(416, 21);
            this.cmbVrstaUsluge.TabIndex = 3;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(463, 149);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 4;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.AllowUserToAddRows = false;
            this.dgvPregledi.AllowUserToDeleteRows = false;
            this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PregledID,
            this.LjubimacD,
            this.KorisnikLljubimacIme,
            this.Datum,
            this.KorisnikIME,
            this.VrstaUslugeNaziv,
            this.Napomena});
            this.dgvPregledi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregledi.Location = new System.Drawing.Point(3, 16);
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.ReadOnly = true;
            this.dgvPregledi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledi.Size = new System.Drawing.Size(968, 272);
            this.dgvPregledi.TabIndex = 5;
            // 
            // PregledID
            // 
            this.PregledID.DataPropertyName = "PregledID";
            this.PregledID.HeaderText = "PregledID";
            this.PregledID.Name = "PregledID";
            this.PregledID.ReadOnly = true;
            this.PregledID.Visible = false;
            // 
            // LjubimacD
            // 
            this.LjubimacD.DataPropertyName = "LjubimacID";
            this.LjubimacD.HeaderText = "LjubimacID";
            this.LjubimacD.Name = "LjubimacD";
            this.LjubimacD.ReadOnly = true;
            this.LjubimacD.Visible = false;
            // 
            // KorisnikLljubimacIme
            // 
            this.KorisnikLljubimacIme.DataPropertyName = "KorisnikLljubimacIme";
            this.KorisnikLljubimacIme.HeaderText = "Ime klijenta";
            this.KorisnikLljubimacIme.Name = "KorisnikLljubimacIme";
            this.KorisnikLljubimacIme.ReadOnly = true;
            this.KorisnikLljubimacIme.Width = 150;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // KorisnikIME
            // 
            this.KorisnikIME.DataPropertyName = "KorisnikIme";
            this.KorisnikIME.HeaderText = "Ime veterinara";
            this.KorisnikIME.Name = "KorisnikIME";
            this.KorisnikIME.ReadOnly = true;
            // 
            // VrstaUslugeNaziv
            // 
            this.VrstaUslugeNaziv.DataPropertyName = "VrstaUslugeNaziv";
            this.VrstaUslugeNaziv.HeaderText = "Vrsta usluge";
            this.VrstaUslugeNaziv.Name = "VrstaUslugeNaziv";
            this.VrstaUslugeNaziv.ReadOnly = true;
            this.VrstaUslugeNaziv.Width = 150;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            this.Napomena.Width = 400;
            // 
            // Pregledi
            // 
            this.Pregledi.Controls.Add(this.dgvPregledi);
            this.Pregledi.Location = new System.Drawing.Point(26, 192);
            this.Pregledi.Name = "Pregledi";
            this.Pregledi.Size = new System.Drawing.Size(974, 291);
            this.Pregledi.TabIndex = 6;
            this.Pregledi.TabStop = false;
            this.Pregledi.Text = "Pregledi";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(26, 101);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(416, 20);
            this.txtIme.TabIndex = 7;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(26, 151);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(416, 20);
            this.txtPrezime.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prezime";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Izmjeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPretragaPregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.Pregledi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.cmbVrstaUsluge);
            this.Controls.Add(this.label2);
            this.Name = "frmPretragaPregleda";
            this.Text = "frmPretragaPregleda";
            this.Load += new System.EventHandler(this.frmPretragaPregleda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            this.Pregledi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVrstaUsluge;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.GroupBox Pregledi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PregledID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LjubimacD;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikLljubimacIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaUslugeNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
    }
}