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
    public class LjubimacUrediViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Ljubimci");
        public Model.Ljubimac Ljubimac { get; set; }
        bool _ImeValidation = false;
        public bool ImeValidation
        {

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
            if (string.IsNullOrWhiteSpace(Ljubimac.Ime))
            {
                ImeValidation = true;
                IsValidate = false;
            }
            else
            {
                ImeValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Ljubimac.Boja))
            {
                BojaValidation = true;
                IsValidate = false;
            }
            else
            {
                BojaValidation = false;
            }
            if (string.IsNullOrWhiteSpace(Ljubimac.Rasa))
            {
                RasaValidation = true;
                IsValidate = false;
            }
            else
            {
                RasaValidation = false;
            }
            if (Ljubimac.DatumRodjenja > DateTime.Now)
            {
                DatumRodjenjaValidation = true;
                IsValidate = false;
            }
            else
            {
                DatumRodjenjaValidation = false;
            }
            if (Ljubimac.Mikrocip.Length != 15)
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

        public ICommand SacuvajIzmjeneCommand { get; set; }
        private async Task SacuvajIzmjene()
        {
            if (ValidateForm())
            {
                      var request = new LjubimacUpsertRequest()
            {
         DatumRodjenja=Ljubimac.DatumRodjenja,
         Boja=Ljubimac.Boja,
         Ime=Ljubimac.Ime,
         Mikrocip=Ljubimac.Mikrocip,
         Rasa=Ljubimac.Rasa,
         KorisnikId=Ljubimac.KorisnikId,
         Slika=Ljubimac.Slika

            };
            await _service.Update<Model.Ljubimac>(Ljubimac.LjubimacId, request);
            await Application.Current.MainPage.DisplayAlert("Promjena uspješna", "Podaci o ljubimcu usšješno izmjenjeni", "OK");
           
            }
      
        }
        public LjubimacUrediViewModel()
        {
            Title = "Uredi ljubimca";
            SacuvajIzmjeneCommand = new Command(async () => await SacuvajIzmjene());
        }
    }
}
