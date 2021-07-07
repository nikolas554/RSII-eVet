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
    public class RezervacijeZahtijevaneViewModel
    {
        private readonly APIService _rezervacijaService = new APIService("Rezervacije/Vrste");
        public ICommand InitCommand { get; set; }
      
        public RezervacijeZahtijevaneViewModel()
        {
            
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Rezervacije> RezervacijeList { get; set; } = new ObservableCollection<Model.Rezervacije>();
        public async Task Init()
        {
            RezervacijeSearchRequest search = new RezervacijeSearchRequest
            {

                IsKorisnik = true,
                IsStatus = null
            };
            var list = await _rezervacijaService.Get<IList<Model.Rezervacije>>(search);
            RezervacijeList.Clear();
            foreach(var item in list)
            {
                RezervacijeList.Add(item);
            }
            
        }
    }
}
