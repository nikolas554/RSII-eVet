using eVet.Model.Request;
using eVet.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;



namespace eVet.MobileApp.ViewModels
{
    public class RezervacijeOdbijeneViewModel:BaseViewModel
    {
        private readonly APIService _rezervacijaService = new APIService("Rezervacije/Vrste");
        public ICommand InitCommand { get; set; }

        public RezervacijeOdbijeneViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Rezervacije> RezervacijeList { get; set; } = new ObservableCollection<Model.Rezervacije>();
        public async Task Init()
        {
            var search = new RezervacijeSearchRequest
            {

                IsKorisnik = true,
                IsStatus = false

            };
            


            var result = await _rezervacijaService.Get<List<Model.Rezervacije>>(search);
            RezervacijeList.Clear();
            foreach (var item in result)
            {
                RezervacijeList.Add(item);
            }


        }
    }
}
