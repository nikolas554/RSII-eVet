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
    public class RacuniViewModel:BaseViewModel
    {
        private readonly APIService _service= new APIService("Racun");

        public RacuniViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }

        bool _praznaLista = false;
        public bool IsPraznaLIsta
        {
            get { return _praznaLista; }
            set { SetProperty(ref _praznaLista, value); }
        }

        public ObservableCollection<Model.Racun> RacuniList { get; set; } = new ObservableCollection<Model.Racun>();

        public async Task Init()
        {
            IsPraznaLIsta = false;
            var request = new RacuniSearchRequest();
            request.IsUplatio = false;
            request.Neplaceni = true;
            request.KlijentId = APIService.userid;
            var list = await _service.Get<List<Model.Racun>>(request);
            RacuniList.Clear();
            foreach (var racun in list)
            {
                RacuniList.Add(racun);
            }
            if (RacuniList.Count == 0)
            {
                IsPraznaLIsta = true;
            }
            

        }
    }
}
