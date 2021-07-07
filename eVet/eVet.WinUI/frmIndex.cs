using eVet.WinUI.Korisnici;
using eVet.WinUI.Lijekovi;
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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmKorisnici frm = new frmKorisnici();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmKorisnicDetalji frm = new frmKorisnicDetalji();
            //frm.Show();
        }

        private void noviLijekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLijekoviDetalji frm = new frmLijekoviDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLijekovi frm = new frmLijekovi();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void pregledRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRezervacije frm = new frmRezervacije();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void pretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //frmPretragaPregleda frm = new frmPretragaPregleda();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void pretragaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //RacuniPregled frm = new RacuniPregled();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void pregledPrometaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reportViewerPregledPrometa frm = new reportViewerPregledPrometa();
            //frm.Show();
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reportViewerTopKorisnici frm = new reportViewerTopKorisnici(this);
            //frm.Show();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {

        }
    }
}
