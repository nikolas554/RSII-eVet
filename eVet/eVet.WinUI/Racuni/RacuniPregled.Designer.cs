
namespace eVet.WinUI.Racuni
{
    partial class RacuniPregled
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
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RacunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezimeLjubimac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaUsluge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPlacen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRacuni);
            this.groupBox1.Location = new System.Drawing.Point(29, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Racuni";
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToAddRows = false;
            this.dgvRacuni.AllowUserToDeleteRows = false;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RacunId,
            this.ImePrezimeLjubimac,
            this.DatumIzdavanja,
            this.CijenaUsluge,
            this.Popust,
            this.Iznos,
            this.IsPlacen});
            this.dgvRacuni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRacuni.Location = new System.Drawing.Point(3, 16);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(924, 270);
            this.dgvRacuni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Staus uplate";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(29, 25);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(303, 20);
            this.txtIme.TabIndex = 3;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(29, 73);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(303, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(29, 129);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(303, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(356, 129);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 6;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Naplati i štampaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RacunId
            // 
            this.RacunId.DataPropertyName = "RacunId";
            this.RacunId.HeaderText = "RacunId";
            this.RacunId.Name = "RacunId";
            this.RacunId.ReadOnly = true;
            this.RacunId.Visible = false;
            // 
            // ImePrezimeLjubimac
            // 
            this.ImePrezimeLjubimac.DataPropertyName = "ImePrezimeLjubimac";
            this.ImePrezimeLjubimac.HeaderText = "Klijent";
            this.ImePrezimeLjubimac.Name = "ImePrezimeLjubimac";
            this.ImePrezimeLjubimac.ReadOnly = true;
            this.ImePrezimeLjubimac.Width = 250;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.HeaderText = "Datum Izdavanja";
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            this.DatumIzdavanja.Width = 150;
            // 
            // CijenaUsluge
            // 
            this.CijenaUsluge.DataPropertyName = "CijenaUsluge";
            this.CijenaUsluge.HeaderText = "Cijena usluge";
            this.CijenaUsluge.Name = "CijenaUsluge";
            this.CijenaUsluge.ReadOnly = true;
            // 
            // Popust
            // 
            this.Popust.DataPropertyName = "Popust";
            this.Popust.HeaderText = "Popust %";
            this.Popust.Name = "Popust";
            this.Popust.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "Iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // IsPlacen
            // 
            this.IsPlacen.DataPropertyName = "IsPlacen";
            this.IsPlacen.HeaderText = "Plaćen";
            this.IsPlacen.Name = "IsPlacen";
            this.IsPlacen.ReadOnly = true;
            this.IsPlacen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsPlacen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RacuniPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RacuniPregled";
            this.Text = "RacuniPregled";
            this.Load += new System.EventHandler(this.RacuniPregled_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezimeLjubimac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPlacen;
    }
}