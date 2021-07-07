using eVet.MobileApp.Views;
using eVet.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eVet.MobileApp.ViewModels
{
    public class UrediProfileViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        string _password = string.Empty;
        bool _imeValidate = false;
        public bool ImeValidation
        {
            get { return _imeValidate; }
            set { SetProperty(ref _imeValidate, value); }
        }

        bool _prezimeValidate = false;
        public bool PrezimeValidation
        {
            get { return _prezimeValidate; }
            set { SetProperty(ref _prezimeValidate, value); }
        }
        bool _korisnickoimeValidate = false;
        public bool KorisnickoimeValidation
        {
            get { return _korisnickoimeValidate; }
            set { SetProperty(ref _korisnickoimeValidate, value); }
        }
        bool _passwordValidate = false;
        public bool PasswordValidation
        {
            get { return _passwordValidate; }
            set { SetProperty(ref _passwordValidate, value); }
        }
        bool _confirmpasswordValidate = false;
        public bool ConfirmPasswordValidation
        {
            get { return _confirmpasswordValidate; }
            set { SetProperty(ref _confirmpasswordValidate, value); }
        }
        bool _mobilniValidate = false;
        public bool MobilniValidation
        {
            get { return _mobilniValidate; }
            set { SetProperty(ref _mobilniValidate, value); }
        }
        bool _datumrodjenjaValidate = false;
        public bool DatumrodjenjaValidation
        {
            get { return _datumrodjenjaValidate; }
            set { SetProperty(ref _datumrodjenjaValidate, value); }
        }

        public string password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _confirmPassword = string.Empty;
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { SetProperty(ref _confirmPassword, value); }
        }
        Model.Korisnik _korisnik= null;
        public Model.Korisnik Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }
        public UrediProfileViewModel()
        {
            Title = "Uredi profil";
            InitCommand = new Command(async () => await Init());
            SacuvajIzmjeneCommand = new Command(async () => await SacuvajIzmjene());
        }
        private bool ValidateForm()
        {
            bool IsValidated = true;
            if (string.IsNullOrWhiteSpace(Korisnik.Ime) || Korisnik.Ime.Length >= 50 || Korisnik.Ime.Length < 2)
            {
                IsValidated = false;
                ImeValidation = true;
            }
            else
            {
                ImeValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Korisnik.Prezime) || Korisnik.Prezime.Length >= 50 || Korisnik.Prezime.Length < 2)
            {
                IsValidated = false;
                PrezimeValidation = true;
            }
            else
            {
                PrezimeValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Korisnik.KorisnickoIme) || Korisnik.KorisnickoIme.Length >= 50 || Korisnik.KorisnickoIme.Length < 4)
            {
                IsValidated = false;
                KorisnickoimeValidation = true;
            }
            else
            {
                KorisnickoimeValidation = false;
            }
            if (string.IsNullOrWhiteSpace(password) || password.Length >= 50 || password.Length < 4)
            {
                IsValidated = false;
                PasswordValidation = true;
            }
            else
            {
                PasswordValidation = false;
            }
            if (string.IsNullOrWhiteSpace(ConfirmPassword) || ConfirmPassword.Length >= 50 || ConfirmPassword.Length < 4)
            {
                IsValidated = false;
                ConfirmPasswordValidation = true;
            }
            else
            {
                ConfirmPasswordValidation = false;
            }
            if (Korisnik.DatumRodjenja >= DateTime.Now)
            {
                IsValidated = false;
                DatumrodjenjaValidation = true;
            }
            else
            {
                DatumrodjenjaValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Korisnik.Mobilni) || Korisnik.Mobilni.Length >= 50)
            {
                IsValidated = false;
                MobilniValidation = true;
            }
            else
            {
                MobilniValidation = false;
            }
            return IsValidated;
        }
        public ICommand InitCommand { get; set; }
        public ICommand SacuvajIzmjeneCommand { get; set; }
        private async Task SacuvajIzmjene()
        {
            if (ValidateForm())
            {
                var request = new KorisniciInsertRequest()
                {
                    DatumRodjenja = _korisnik.DatumRodjenja,
                    Adresa = _korisnik.Adresa,
                    Ime = _korisnik.Ime,
                    KorisnickoIme = _korisnik.KorisnickoIme,
                    Mobilni = _korisnik.Mobilni,
                    Prezime = _korisnik.Prezime,
                    Slika = _korisnik.Slika,
                    Password = password,
                    PasswordConfirmation = ConfirmPassword

                };
                await _service.Update<Model.Korisnik>(APIService.userid, request);
                await Application.Current.MainPage.DisplayAlert("Promjena uspješna", "Prijavite se ponovo", "OK");
                Application.Current.MainPage = new LoginPage();
            }
          
        }

        public async Task Init()
        {
            Korisnik = await _service.GetById<Model.Korisnik>(APIService.userid);
        }
    }
}
