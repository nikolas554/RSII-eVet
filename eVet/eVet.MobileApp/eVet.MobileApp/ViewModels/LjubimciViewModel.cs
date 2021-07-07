using eVet.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eVet.MobileApp.ViewModels
{
    public class LjubimciViewModel:BaseViewModel
    {
        private readonly APIService _ljubimciService = new APIService("Ljubimci/byKorisnik");
        string _image = string.Empty;
        public string Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        DateTime _datumRodjenja = DateTime.UtcNow;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { SetProperty(ref _datumRodjenja, value); }
        }
        string _rasa = string.Empty;
        public string Rasa
        {
            get { return _rasa; }
            set { SetProperty(ref _rasa, value); }
        }
        string _boja = string.Empty;
        public string Boja
        {
            get { return _boja; }
            set { SetProperty(ref _boja, value); }
        }
        string _mikrocip = string.Empty;
        public string Mikrocip
        {
            get { return _mikrocip; }
            set { SetProperty(ref _mikrocip, value); }
        }


        bool _ImeValidation = false;
        public bool ImeValidation {

            get { return _ImeValidation; }
            set { SetProperty(ref _ImeValidation, value); }
        
        }
        bool _datumRodjenjaValidation = false;
        public bool DatumRodjenjaValidation
        {
            get { return _datumRodjenjaValidation; }
            set { SetProperty(ref _datumRodjenjaValidation, value); }
        }
        bool _rasaValidation = false;
        public bool RasaValidation
        {
            get { return _rasaValidation; }
            set { SetProperty(ref _rasaValidation, value); }
        }
        bool _bojaValidation = false;
        public bool BojaValidation
        {
            get { return _bojaValidation; }
            set { SetProperty(ref _bojaValidation, value); }
        }

        bool _mikrocipValidation = false;
        public bool MikrocipValidation
        {
            get { return _mikrocipValidation; }
            set { SetProperty(ref _mikrocipValidation, value); }
        }
        private bool ValidateForm()
        {
            bool IsValidate = true;
            if (string.IsNullOrWhiteSpace(Ime))
            {
                ImeValidation = true;
                IsValidate = false;
            }
            else
            {
                ImeValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Boja))
            {
                BojaValidation = true;
                IsValidate = false;
            }
            else
            {
                BojaValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Rasa))
            {
                RasaValidation = true;
                IsValidate = false;
            }
            else
            {
                RasaValidation = false;
            }
            if (DatumRodjenja> DateTime.Now)
            {
                DatumRodjenjaValidation = true;
                IsValidate = false;
            }
            else
            {
                DatumRodjenjaValidation= false;
            }

            if (Mikrocip.Length != 15)
            {
                MikrocipValidation = true;
                IsValidate = false;
            }
            else
            {
                MikrocipValidation = false;
            }
            return IsValidate;
        }


        public LjubimciViewModel()
        {
            SnimiCommand = new Command(async () => await Snimi());

        }
        public ICommand SnimiCommand { get; set; }

        public async Task Snimi()
        {
            if (ValidateForm())
            {
                       var request = new LjubimacUpsertRequest
            {
               DatumRodjenja=DatumRodjenja,
               Boja=Boja,
               Ime=Ime,
               Mikrocip=Mikrocip,
               Rasa=Rasa
            };
            var temp = await _ljubimciService.Insert<Model.Ljubimac>(request); 
            if (temp != null)
            {
                await Application.Current.MainPage.DisplayAlert("Info", "Uspješno dodan ljubimac", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Info", "Niste dodali ljubimca", "OK");
            }
            }
     
        }

    }
}
