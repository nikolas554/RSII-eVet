using eVet.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eVet.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());

        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }

        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        public ICommand LoginCommand { get; set; }
       

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            try
            {
                var list= await _service.Get<List<Model.Korisnik>>(null);
                foreach (var findUsername in list)
                {
                    if (findUsername.KorisnickoIme.Equals(APIService.Username))
                    {
                        APIService.userid = findUsername.KorisnikId;
                    }
                }
                Application.Current.MainPage = new AppShell();
            }
            catch (Exception)
            {
                IsBusy = false;
                Password = string.Empty;
                await Application.Current.MainPage.DisplayAlert("Greska", "Niste unijeli ispravne login podatke", "OK");
            }
        }

    }
}
