using eVet.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVet.WinUI.Ljubimci
{
    public partial class frmLjubimciDodaj : Form
    {

        private  APIService _ljubimci= new APIService("Ljubimci");
        private int _klijentid;
        private int? _id;
        public frmLjubimciDodaj(int klijentid, int ? id=null)
        {
            _klijentid = klijentid;
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new LjubimacUpsertRequest()
            {
                Boja = txtBoja.Text,
                DatumRodjenja = dtpDatumRodjenja.Value,
                Ime = txtIme.Text,
                Mikrocip = txtMikrocip.Text,
                Rasa = txtRasa.Text,
                KorisnikId=_klijentid
               

            };
            Model.Ljubimac entity = null;
            if (!_id.HasValue)
            {
                entity = await _ljubimci.Insert<Model.Ljubimac>(request);

                if (entity != null)
                {
                    MessageBox.Show("Uspješno ste dodali pregled");

                }
                else
                {
                    MessageBox.Show("Greška");
                }




            }
          
        }
    }
}
