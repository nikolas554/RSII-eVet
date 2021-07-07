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

namespace eVet.WinUI.Korisnici
{
    public partial class frmKorisnicDetalji : Form
    {
        APIService _service= new APIService("Korisnici");
        APIService _ulogeService = new APIService("Uloge");
        private int? _id = null;
        private readonly frmPocetna _pocetna;
        public frmKorisnicDetalji(frmPocetna pocetna, int? KorisnikId=null)
        {
            InitializeComponent();
            _id = KorisnikId;
            _pocetna = pocetna;

        }

        private async void frmKorisnicDetalji_Load(object sender, EventArgs e)
        {
            var ulogeList = await _ulogeService.Get<List<Model.Uloge>>(null);
            clbRole.DataSource = ulogeList;
            clbRole.DisplayMember = "Naziv";


            if (_id.HasValue)
            {
                var korisnik = await _service.GetById<Model.Korisnik>(_id);
                txtPrezime.Text = korisnik.Prezime;
                txtMobilni.Text = korisnik.Mobilni;
                txtAdresa.Text = korisnik.Adresa;
                txtDatumRodjenja.Value = korisnik.DatumRodjenja;
                txtKorisnickoIme.Text = korisnik.KorisnickoIme;
                txtIme.Text = korisnik.Ime;

                var request = new UlogeSearchRequest { KorisnikId = korisnik.KorisnikId };
                var korisnikUloge = await _ulogeService.Get<List<Model.Uloge>>(request);
                var UlogeInt = korisnikUloge.Select(x => x.UlogaId);
                for (int i = 0; i < clbRole.Items.Count; i++)
                {
                    var item = (clbRole.Items[i] as Model.Uloge).UlogaId;
                    if (UlogeInt.Contains(item))
                    {
                        clbRole.SetItemChecked(i, true);
                    }
                }
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                var roleList = clbRole.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();
                var request = new KorisniciInsertRequest()
                {
                    Adresa = txtAdresa.Text,
                    DatumRodjenja = txtDatumRodjenja.Value,
                    Ime = txtIme.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Mobilni = txtMobilni.Text,
                    Prezime = txtPrezime.Text,
                    Password = txtLozinka.Text,
                    PasswordConfirmation = txtPotvrda.Text,
                    Uloge = roleList
                };
                Model.Korisnik entity = null;
                if (!_id.HasValue)
                {
                    entity = await _service.Insert<Model.Korisnik>(request);
                }
                else
                {
                    entity = await _service.Update<Model.Korisnik>(_id.Value, request);
                }

                if (entity != null)
                {
                    MessageBox.Show("Uspješno izvršeno");
                    _pocetna.openChildForm(new frmKorisnici(_pocetna));
                }
              

            }

        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtIme.Text.Length < 3)
            {
                errorProvider.SetError(txtIme, "Polje Ime je obavezno");
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtPrezime.Text.Length < 3)
            {
                errorProvider.SetError(txtPrezime, "Polje prezime mora sadržavati minimalno 3 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void clbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtKorisnickoIme.Text.Length < 4)
            {
                errorProvider.SetError(txtKorisnickoIme, "Polje korisnicko ime mora sadržavati najmanje 4 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLozinka.Text) || txtLozinka.Text.Length < 4)
            {
                errorProvider.SetError(txtLozinka, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtLozinka.Text.Length < 4)
            {
                errorProvider.SetError(txtLozinka, "Polje password mora sadržavati najmanje 4 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLozinka, null);
            }
        }

        private void txtPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPotvrda.Text) || txtPotvrda.Text.Length < 4)
            {
                errorProvider.SetError(txtPotvrda, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtPotvrda.Text.Length < 4)
            {
                errorProvider.SetError(txtPotvrda, "Polje potvrda lozinke mora sadržavati najmanje 4 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPotvrda, null);
            }
        }
    }
}
