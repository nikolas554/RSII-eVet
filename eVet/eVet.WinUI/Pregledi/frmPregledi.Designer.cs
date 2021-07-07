
namespace eVet.WinUI.Pregledi
{
    partial class frmPregledi
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
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLjubimac = new System.Windows.Forms.Label();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PregledID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LjubimacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LjubimacIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaUslugeNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPregledi);
            this.groupBox1.Location = new System.Drawing.Point(20, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregledi";
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.AllowUserToAddRows = false;
            this.dgvPregledi.AllowUserToDeleteRows = false;
            this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PregledID,
            this.LjubimacID,
            this.Datum,
            this.KorisnikIme,
            this.LjubimacIme,
            this.VrstaUslugeNaziv,
            this.Napomena});
            this.dgvPregledi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregledi.Location = new System.Drawing.Point(3, 16);
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.ReadOnly = true;
            this.dgvPregledi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledi.Size = new System.Drawing.Size(947, 219);
            this.dgvPregledi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klijent:  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLjubimac
            // 
            this.lblLjubimac.AutoSize = true;
            this.lblLjubimac.Location = new System.Drawing.Point(75, 23);
            this.lblLjubimac.Name = "lblLjubimac";
            this.lblLjubimac.Size = new System.Drawing.Size(0, 13);
            this.lblLjubimac.TabIndex = 2;
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(101, 353);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjena.TabIndex = 3;
            this.btnIzmjena.Text = "Izmjeni";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(20, 58);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(92, 35);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Nazad";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // PregledID
            // 
            this.PregledID.DataPropertyName = "PregledID";
            this.PregledID.HeaderText = "PregledID";
            this.PregledID.Name = "PregledID";
            this.PregledID.ReadOnly = true;
            this.PregledID.Visible = false;
            // 
            // LjubimacID
            // 
            this.LjubimacID.DataPropertyName = "LjubimacID";
            this.LjubimacID.HeaderText = "LjubimacID";
            this.LjubimacID.Name = "LjubimacID";
            this.LjubimacID.ReadOnly = true;
            this.LjubimacID.Visible = false;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // KorisnikIme
            // 
            this.KorisnikIme.DataPropertyName = "KorisnikIme";
            this.KorisnikIme.HeaderText = "Ime veterinara";
            this.KorisnikIme.Name = "KorisnikIme";
            this.KorisnikIme.ReadOnly = true;
            this.KorisnikIme.Width = 150;
            // 
            // LjubimacIme
            // 
            this.LjubimacIme.DataPropertyName = "LjubimacIme";
            this.LjubimacIme.HeaderText = "Ime ljubimca";
            this.LjubimacIme.Name = "LjubimacIme";
            this.LjubimacIme.ReadOnly = true;
            this.LjubimacIme.Visible = false;
            // 
            // VrstaUslugeNaziv
            // 
            this.VrstaUslugeNaziv.DataPropertyName = "VrstaUslugeNaziv";
            this.VrstaUslugeNaziv.HeaderText = "Naziv vrste usluge";
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
            this.Napomena.Width = 450;
            // 
            // frmPregledi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 388);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzmjena);
            this.Controls.Add(this.lblLjubimac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPregledi";
            this.Text = "frmPregledi";
            this.Load += new System.EventHandler(this.frmPregledi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLjubimac;
        private System.Windows.Forms.Button btnIzmjena;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PregledID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LjubimacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn LjubimacIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaUslugeNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
    }
}