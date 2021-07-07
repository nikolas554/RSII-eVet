using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eVet.MobileApp.ViewModels
{
    public class LjubimciPrikazViewModel
    {
        private readonly APIService _ljubimciService = new APIService("Ljubimci/byKorisnik");
        public LjubimciPrikazViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Ljubimac> LjubimciList { get; set; } = new ObservableCollection<Model.Ljubimac>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _ljubimciService.Get<IList<Model.Ljubimac>>(null);
            LjubimciList.Clear();
            foreach (var ljubimac in list)
            {
                LjubimciList.Add(ljubimac);
            }
        }
    }
}
