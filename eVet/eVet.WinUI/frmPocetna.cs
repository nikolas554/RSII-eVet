using eVet.WinUI.Korisnici;
using eVet.WinUI.Pregledi;
using eVet.WinUI.Racuni;
using eVet.WinUI.Reporti;
using eVet.WinUI.Rezervacije;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVet.WinUI
{
    public partial class frmPocetna : Form
    {
        public frmPocetna()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelIzvjestajiSubMenu.Visible = false;
            panelKorisniciSubmenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelIzvjestajiSubMenu.Visible == true)
                panelIzvjestajiSubMenu.Visible = false;
            if (panelKorisniciSubmenu.Visible == true)
                panelKorisniciSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnKorisnic_Click(object sender, EventArgs e)
        {

            showSubMenu(panelKorisniciSubmenu);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKorisnici(this));
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKorisnicDetalji(this));
            hideSubMenu();
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            showSubMenu(panelIzvjestajiSubMenu);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new reportViewerPregledPrometa(this));
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new reportViewerTopKorisnici(this));
            hideSubMenu();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {

        }
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRezervacije(this));
        }

        private void btnPregledi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPretragaPregleda(this));
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            openChildForm(new RacuniPregled(this));
        }
    }
}
