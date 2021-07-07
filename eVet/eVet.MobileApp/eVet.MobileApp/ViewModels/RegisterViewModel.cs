using eVet.MobileApp.Views;
using eVet.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eVet.MobileApp.ViewModels
{
    public class RegisterViewModel:BaseViewModel
    {
        private APIService _korisniciService = new APIService("Korisnici/register");
        public ICommand Submit { get; set; }
        public RegisterViewModel()
        {
            Submit = new Command(async () => await Register());
        }
        string _korisnickoime = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoime; }
            set { SetProperty(ref _korisnickoime, value); }
        }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime  = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _confirmpassword = string.Empty;
        public string ConfirmPassword
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        DateTime _datumrodjenja = DateTime.UtcNow;
        public DateTime DatumRodjenja
        {
            get { return _datumrodjenja; }
            set { SetProperty(ref _datumrodjenja, value); }
        }
        string _mobilni = string.Empty;
        public string Mobilni
        {
            get { return _mobilni; }
            set { SetProperty(ref _mobilni, value); }
        }

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



        private bool ValidateForm()
        {
            bool IsValidated = true;
            if (string.IsNullOrWhiteSpace(Ime) || Ime.Length >= 50 || Ime.Length<2)
            {
                IsValidated = false;
                ImeValidation = true;
            }
            else
            {
                ImeValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Prezime) || Prezime.Length >= 50 || Prezime.Length<2)
            {
                IsValidated = false;
                PrezimeValidation = true;
            }
            else
            {
                PrezimeValidation = false;
            }
            if (string.IsNullOrWhiteSpace(KorisnickoIme) || KorisnickoIme.Length >= 50 || KorisnickoIme.Length<4)
            {
                IsValidated = false;
                KorisnickoimeValidation = true;
            }
            else
            {
                KorisnickoimeValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Password) || Password.Length >= 50 || Password.Length<4)
            {
                IsValidated = false;
                PasswordValidation = true;
            }
            else
            {
                PasswordValidation = false;
            }
            if (string.IsNullOrWhiteSpace(ConfirmPassword) || ConfirmPassword.Length >= 50 || ConfirmPassword.Length<4)
            {
                IsValidated = false;
                ConfirmPasswordValidation = true;
            }
            else
            {
                ConfirmPasswordValidation = false;
            }
            if (DatumRodjenja >= DateTime.Now)
            {
                IsValidated = false;
                DatumrodjenjaValidation = true;
            }
            else
            {
                DatumrodjenjaValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Mobilni) || Mobilni.Length >= 50)
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

        async Task Register()
        {
            if (ValidateForm())
            {
                try
                {
                    if (ConfirmPassword != Password)
                    {
                        throw new Exception("Passwordi se ne slažu");
                    }
                    var request = new KorisniciInsertRequest()
                    {
                        DatumRodjenja = DatumRodjenja,
                        Ime = Ime,
                        Prezime = Prezime,
                        Password = Password,
                        PasswordConfirmation = ConfirmPassword,
                        KorisnickoIme = KorisnickoIme,
                        Mobilni = Mobilni

                    };
                    await _korisniciService.Insert<Model.Korisnik>(request);
                    await Application.Current.MainPage.DisplayAlert("Registracija uspješna ", "Uspješno ste se registrovali", "OK");
                    Application.Current.MainPage = new LoginPage();

                }
                catch
                {

                    await Application.Current.MainPage.DisplayAlert("Error", "Dogodila se greška", "OK");
                }
            }
          
        }
    }
}
