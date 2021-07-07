
namespace eVet.WinUI.Ljubimci
{
    partial class frmLjubimciDodaj
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRasa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.txtMikrocip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(36, 41);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(348, 20);
            this.txtIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(36, 108);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(348, 20);
            this.dtpDatumRodjenja.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum rođenja";
            // 
            // txtRasa
            // 
            this.txtRasa.Location = new System.Drawing.Point(36, 171);
            this.txtRasa.Name = "txtRasa";
            this.txtRasa.Size = new System.Drawing.Size(348, 20);
            this.txtRasa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rasa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Boja";
            // 
            // txtBoja
            // 
            this.txtBoja.Location = new System.Drawing.Point(36, 229);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(348, 20);
            this.txtBoja.TabIndex = 7;
            // 
            // txtMikrocip
            // 
            this.txtMikrocip.Location = new System.Drawing.Point(36, 290);
            this.txtMikrocip.Name = "txtMikrocip";
            this.txtMikrocip.Size = new System.Drawing.Size(348, 20);
            this.txtMikrocip.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mikročip";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(309, 331);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 10;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // frmLjubimciDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 415);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMikrocip);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Name = "frmLjubimciDodaj";
            this.Text = "frmLjubimciDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.TextBox txtMikrocip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSnimi;
    }
}