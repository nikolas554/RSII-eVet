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
    public class RezervacijeViewModel:BaseViewModel
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacije");
        private readonly APIService _terminiService = new APIService("Termin");
        private readonly APIService _vrstauslugeService = new APIService("VrstaUsluge");
        private readonly APIService _ljubimciService = new APIService("Ljubimci/byKorisnik");
        public ObservableCollection<Model.Termini> Termini { get; set; } = new ObservableCollection<Model.Termini>();
        public ObservableCollection<Model.VrstaUsluge> VrstaUsluge { get; set; } = new ObservableCollection<Model.VrstaUsluge>();
        public ObservableCollection<Model.Ljubimac> Ljubimci { get; set; } = new ObservableCollection<Model.Ljubimac>();

        Model.Termini _selectedTermini = null;
        public Model.Termini SelectedTermini
        {
            get { return _selectedTermini; }
            set { SetProperty(ref _selectedTermini, value); }

        }

        Model.VrstaUsluge _selectedVrsteUsluga = null;
        public Model.VrstaUsluge SelectedVrsteUsluga
        {
            get { return _selectedVrsteUsluga; }
            set { SetProperty(ref _selectedVrsteUsluga, value); }

        }
        Model.Ljubimac _selectedLjubimac = null;
        public Model.Ljubimac SelectedLjubimac
        {
            get { return _selectedLjubimac; }
            set { SetProperty(ref _selectedLjubimac, value); }

        }


        string _napomena = string.Empty;
        public string Napomena
        {
            get { return _napomena; }
            set { SetProperty(ref _napomena, value); }
        }
        DateTime _datumRezervacije = DateTime.UtcNow;
        public DateTime DatumRezervacije
        {
            get { return _datumRezervacije; }
            set { SetProperty(ref _datumRezervacije, value); }
        }
        public ICommand InitCommand { get; set; }
        public ICommand SnimiCommand { get; set; }
        public RezervacijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SnimiCommand= new Command(async () => await Snimi());

        }


        bool _datumValidation = false;
        public bool DatumValidation
        {
            get { return _datumValidation; }
            set { SetProperty(ref _datumValidation, value); }
        }

        bool _terminValidation = false;
        public bool TerminValidation
        {
            get { return _terminValidation; }
            set { SetProperty(ref _terminValidation, value); }
        }
        bool _vrstauslugaValidation = false;
        public bool VrstaUslugaValidation
        {
            get { return _vrstauslugaValidation; }
            set { SetProperty(ref _vrstauslugaValidation, value); }
        }
        bool _ljubimacValidation = false;
        public bool LjubimacValidation
        {
            get { return _ljubimacValidation; }
            set { SetProperty(ref _ljubimacValidation, value); }
        }


        private bool ValidateForm()
        {
            bool IsValidate = true;
            if (DatumRezervacije <= DateTime.Now)
            {
                DatumValidation = true;
                IsValidate = false;
            }
            else
            {
                DatumValidation = false;
            }

            if (SelectedTermini == null)
            {
                TerminValidation = true;
                IsValidate = false;
            }
            else
            {
                TerminValidation = false;
            }

            if (SelectedVrsteUsluga == null)
            {
                VrstaUslugaValidation = true;
                IsValidate = false;
            }
            else
            {
                VrstaUslugaValidation =false;
            }

            if (SelectedLjubimac == null)
            {
                LjubimacValidation = true;
                IsValidate = false;
            }
            else
            {
               LjubimacValidation = false;
            }
            return IsValidate;
        }


        public async Task Snimi()
        {
            if (ValidateForm())
            {
                var request = new RezervacijeUpsertRequest
                {
                    Datum = _datumRezervacije,
                    Napomena = _napomena,
                    LjubimacId = _selectedLjubimac.LjubimacId,
                    VrstaUslugeId = _selectedVrsteUsluga.VrstaUslugeId,
                    TerminId = _selectedTermini.TerminId
                };
                var temp = await _rezervacijeService.Insert<Model.Rezervacije>(request);
                if (temp != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Info", "Uspješno dodana rezervacija", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Info", "Niste dodali rezervaciju", "OK");
                }
            }
        }
        public async Task Init()
        {
            var termini = await _terminiService.Get<IList<Model.Termini>>(null);
            var vrstausluge = await _vrstauslugeService.Get<IList<Model.VrstaUsluge>>(null);
            var ljubimci = await _ljubimciService.Get<IList<Model.Ljubimac>>(null);
            Termini.Clear();
            VrstaUsluge.Clear();
            Ljubimci.Clear();
            foreach (var item in termini)
            {
                Termini.Add(item);
            }
            foreach (var item in vrstausluge)
            {
                VrstaUsluge.Add(item);
            }
            foreach (var item in ljubimci)
            {
                Ljubimci.Add(item);
            }
        }
   
    }
}
