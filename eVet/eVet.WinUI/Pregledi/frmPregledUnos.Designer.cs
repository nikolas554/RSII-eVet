
namespace eVet.WinUI.Pregledi
{
    partial class frmPregledUnos
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
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.cmbVrsteUsluga = new System.Windows.Forms.ComboBox();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.clbDijagnoze = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.clbLijekovi = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(31, 141);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(486, 153);
            this.txtNapomena.TabIndex = 0;
            this.txtNapomena.Validating += new System.ComponentModel.CancelEventHandler(this.txtNapomena_Validating);
            // 
            // cmbVrsteUsluga
            // 
            this.cmbVrsteUsluga.FormattingEnabled = true;
            this.cmbVrsteUsluga.Location = new System.Drawing.Point(31, 90);
            this.cmbVrsteUsluga.Name = "cmbVrsteUsluga";
            this.cmbVrsteUsluga.Size = new System.Drawing.Size(334, 21);
            this.cmbVrsteUsluga.TabIndex = 1;
            this.cmbVrsteUsluga.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVrsteUsluga_Validating);
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(31, 38);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 20);
            this.dtDatum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum pregleda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vrsta pregleda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Napomena";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(442, 685);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // clbDijagnoze
            // 
            this.clbDijagnoze.FormattingEnabled = true;
            this.clbDijagnoze.Location = new System.Drawing.Point(31, 328);
            this.clbDijagnoze.Name = "clbDijagnoze";
            this.clbDijagnoze.Size = new System.Drawing.Size(486, 139);
            this.clbDijagnoze.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Popust";
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(265, 38);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(100, 20);
            this.txtPopust.TabIndex = 8;
            this.txtPopust.Validating += new System.ComponentModel.CancelEventHandler(this.txtPopust_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // clbLijekovi
            // 
            this.clbLijekovi.FormattingEnabled = true;
            this.clbLijekovi.Location = new System.Drawing.Point(31, 503);
            this.clbLijekovi.Name = "clbLijekovi";
            this.clbLijekovi.Size = new System.Drawing.Size(486, 154);
            this.clbLijekovi.TabIndex = 10;
            // 
            // frmPregledUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 726);
            this.Controls.Add(this.clbLijekovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.clbDijagnoze);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.cmbVrsteUsluga);
            this.Controls.Add(this.txtNapomena);
            this.Name = "frmPregledUnos";
            this.Text = "frmPregledUnos";
            this.Load += new System.EventHandler(this.frmPregledUnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.ComboBox cmbVrsteUsluga;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.CheckedListBox clbDijagnoze;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckedListBox clbLijekovi;
    }
}