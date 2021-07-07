
namespace eVet.WinUI
{
    partial class frmIndex
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijekoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noviLijekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledRezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPrometaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.lijekoviToolStripMenuItem,
            this.terminiToolStripMenuItem,
            this.preglediToolStripMenuItem,
            this.računiToolStripMenuItem,
            this.izvještajiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1177, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // lijekoviToolStripMenuItem
            // 
            this.lijekoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.noviLijekToolStripMenuItem});
            this.lijekoviToolStripMenuItem.Name = "lijekoviToolStripMenuItem";
            this.lijekoviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.lijekoviToolStripMenuItem.Text = "Lijekovi";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // noviLijekToolStripMenuItem
            // 
            this.noviLijekToolStripMenuItem.Name = "noviLijekToolStripMenuItem";
            this.noviLijekToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.noviLijekToolStripMenuItem.Text = "Novi lijek";
            this.noviLijekToolStripMenuItem.Click += new System.EventHandler(this.noviLijekToolStripMenuItem_Click);
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledRezervacijaToolStripMenuItem});
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.terminiToolStripMenuItem.Text = "Rezervacije";
            // 
            // pregledRezervacijaToolStripMenuItem
            // 
            this.pregledRezervacijaToolStripMenuItem.Name = "pregledRezervacijaToolStripMenuItem";
            this.pregledRezervacijaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pregledRezervacijaToolStripMenuItem.Text = "Pregled rezervacija";
            this.pregledRezervacijaToolStripMenuItem.Click += new System.EventHandler(this.pregledRezervacijaToolStripMenuItem_Click);
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem2});
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            // 
            // pretragaToolStripMenuItem2
            // 
            this.pretragaToolStripMenuItem2.Name = "pretragaToolStripMenuItem2";
            this.pretragaToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.pretragaToolStripMenuItem2.Text = "Obavljeni pregledi";
            this.pretragaToolStripMenuItem2.Click += new System.EventHandler(this.pretragaToolStripMenuItem2_Click);
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem3});
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            // 
            // pretragaToolStripMenuItem3
            // 
            this.pretragaToolStripMenuItem3.Name = "pretragaToolStripMenuItem3";
            this.pretragaToolStripMenuItem3.Size = new System.Drawing.Size(118, 22);
            this.pretragaToolStripMenuItem3.Text = "Pretraga";
            this.pretragaToolStripMenuItem3.Click += new System.EventHandler(this.pretragaToolStripMenuItem3_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledPrometaToolStripMenuItem,
            this.top10ToolStripMenuItem});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // pregledPrometaToolStripMenuItem
            // 
            this.pregledPrometaToolStripMenuItem.Name = "pregledPrometaToolStripMenuItem";
            this.pregledPrometaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pregledPrometaToolStripMenuItem.Text = "Pregled prometa";
            this.pregledPrometaToolStripMenuItem.Click += new System.EventHandler(this.pregledPrometaToolStripMenuItem_Click);
            // 
            // top10ToolStripMenuItem
            // 
            this.top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
            this.top10ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.top10ToolStripMenuItem.Text = "Top 10";
            this.top10ToolStripMenuItem.Click += new System.EventHandler(this.top10ToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 515);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1177, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 537);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndex";
            this.Text = "frmINdex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijekoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noviLijekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledRezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPrometaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10ToolStripMenuItem;
    }
}



