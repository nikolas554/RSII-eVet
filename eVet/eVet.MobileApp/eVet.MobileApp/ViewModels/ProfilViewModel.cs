using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eVet.MobileApp.ViewModels
{
    public class ProfilViewModel:BaseViewModel
    {
        private APIService _service = new APIService("Korisnici");
        public ProfilViewModel()
        {
            Title = "Profil";
            InitCommand = new Command(async () => await Init());
        }

        private Model.Korisnik _korisnik;
        public Model.Korisnik Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            Korisnik = await _service.GetById<Model.Korisnik>(APIService.userid);
        }
    }
}
