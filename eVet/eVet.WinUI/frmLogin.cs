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
    public partial class frmLogin : Form
    {

        APIService _service = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;
                List<Model.Korisnik> list = await _service.Get<List<Model.Korisnik>>(null);
                foreach (var findUsername in list)
                {
                    
                    if (findUsername.KorisnickoIme.Equals(APIService.Username, StringComparison.CurrentCultureIgnoreCase))
                    {
                        APIService.userid = findUsername.KorisnikId;
                    }
                }
                //await _service.Get<dynamic>(null);
                frmPocetna frm = new frmPocetna();
                frm.Show();
            }
            catch (Exception ex) {
              
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
        }
    }
}
