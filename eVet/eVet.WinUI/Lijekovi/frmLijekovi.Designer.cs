
namespace eVet.WinUI.Lijekovi
{
    partial class frmLijekovi
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
            this.txtLijekoviPretraga = new System.Windows.Forms.TextBox();
            this.txtPretraga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.LijekID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLijekoviPretraga
            // 
            this.txtLijekoviPretraga.Location = new System.Drawing.Point(24, 26);
            this.txtLijekoviPretraga.Name = "txtLijekoviPretraga";
            this.txtLijekoviPretraga.Size = new System.Drawing.Size(767, 20);
            this.txtLijekoviPretraga.TabIndex = 0;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(806, 26);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(75, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.Text = "Pretraga";
            this.txtPretraga.UseVisualStyleBackColor = true;
            this.txtPretraga.Click += new System.EventHandler(this.txtPretraga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLijekovi);
            this.groupBox1.Location = new System.Drawing.Point(24, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lijekovi";
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.AllowUserToAddRows = false;
            this.dgvLijekovi.AllowUserToDeleteRows = false;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LijekID,
            this.Naziv,
            this.Cijena});
            this.dgvLijekovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLijekovi.Location = new System.Drawing.Point(3, 16);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.ReadOnly = true;
            this.dgvLijekovi.Size = new System.Drawing.Size(851, 272);
            this.dgvLijekovi.TabIndex = 0;
            // 
            // LijekID
            // 
            this.LijekID.DataPropertyName = "LijekID";
            this.LijekID.HeaderText = "LijekID";
            this.LijekID.Name = "LijekID";
            this.LijekID.ReadOnly = true;
            this.LijekID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // frmLijekovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.txtLijekoviPretraga);
            this.Name = "frmLijekovi";
            this.Text = "frmLijekovi";
            this.Load += new System.EventHandler(this.frmLijekovi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLijekoviPretraga;
        private System.Windows.Forms.Button txtPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LijekID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}