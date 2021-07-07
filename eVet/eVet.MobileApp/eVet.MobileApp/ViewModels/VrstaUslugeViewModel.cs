using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eVet.MobileApp.ViewModels
{
    public class VrstaUslugeViewModel
    {
        private readonly APIService _service = new APIService("Preporuke");
        public VrstaUslugeViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        public ObservableCollection<Model.VrstaUsluge> VrstaUslugesList { get; set; } = new ObservableCollection<Model.VrstaUsluge>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
           
            var list = await _service.Get<IEnumerable<Model.VrstaUsluge>>(APIService.userid);
            VrstaUslugesList.Clear();
            foreach (var vrstausluge in list)
            {
                VrstaUslugesList.Add(vrstausluge);
            }
        }
    }
}
