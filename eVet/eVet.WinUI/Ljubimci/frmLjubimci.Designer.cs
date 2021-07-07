
namespace eVet.WinUI.Ljubimci
{
    partial class frmLjubimci
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
            this.dgvLjubimci = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LjubimacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mikrocip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregledi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLjubimci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLjubimci);
            this.groupBox1.Location = new System.Drawing.Point(32, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ljubimci";
            // 
            // dgvLjubimci
            // 
            this.dgvLjubimci.AllowUserToAddRows = false;
            this.dgvLjubimci.AllowUserToDeleteRows = false;
            this.dgvLjubimci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLjubimci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LjubimacID,
            this.Ime,
            this.KorisnikId,
            this.DatumRodjenja,
            this.Rasa,
            this.Boja,
            this.Mikrocip,
            this.Pregledi});
            this.dgvLjubimci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLjubimci.Location = new System.Drawing.Point(3, 16);
            this.dgvLjubimci.Name = "dgvLjubimci";
            this.dgvLjubimci.ReadOnly = true;
            this.dgvLjubimci.Size = new System.Drawing.Size(868, 275);
            this.dgvLjubimci.TabIndex = 0;
            this.dgvLjubimci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLjubimci_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(35, 18);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(89, 35);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Nazad";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LjubimacID
            // 
            this.LjubimacID.DataPropertyName = "LjubimacID";
            this.LjubimacID.HeaderText = "LjubimacID";
            this.LjubimacID.Name = "LjubimacID";
            this.LjubimacID.ReadOnly = true;
            this.LjubimacID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "KorisnikLjubimacIme";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 200;
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.ReadOnly = true;
            this.KorisnikId.Visible = false;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // Rasa
            // 
            this.Rasa.DataPropertyName = "Rasa";
            this.Rasa.HeaderText = "Rasa";
            this.Rasa.Name = "Rasa";
            this.Rasa.ReadOnly = true;
            // 
            // Boja
            // 
            this.Boja.DataPropertyName = "Boja";
            this.Boja.HeaderText = "Boja";
            this.Boja.Name = "Boja";
            this.Boja.ReadOnly = true;
            // 
            // Mikrocip
            // 
            this.Mikrocip.DataPropertyName = "Mikrocip";
            this.Mikrocip.HeaderText = "Mikrocip";
            this.Mikrocip.Name = "Mikrocip";
            this.Mikrocip.ReadOnly = true;
            // 
            // Pregledi
            // 
            this.Pregledi.HeaderText = "Pregledi";
            this.Pregledi.Name = "Pregledi";
            this.Pregledi.ReadOnly = true;
            this.Pregledi.Text = "Pregledi";
            this.Pregledi.UseColumnTextForButtonValue = true;
            // 
            // frmLjubimci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 437);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLjubimci";
            this.Text = "frmLjubimci";
            this.Load += new System.EventHandler(this.frmLjubimci_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLjubimci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLjubimci;
        private System.Windows.Forms.Button button2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LjubimacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mikrocip;
        private System.Windows.Forms.DataGridViewButtonColumn Pregledi;
    }
}