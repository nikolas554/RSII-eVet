using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eVet.MobileApp.ViewModels
{
    public class PregledDetailViewModel
    {
        private readonly APIService _pregledService = new APIService("Pregledi/ljubimac");
        public Model.Ljubimac Ljubimac{ get; set; }
        public PregledDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }
        public ICommand InitCommand { get; set; }
        public ObservableCollection<Model.Pregled> PregledList { get; set; } = new ObservableCollection<Model.Pregled>();
        public async Task Init()
        {
            var list = await _pregledService.Get<IList<Model.Pregled>>(Ljubimac.LjubimacId);
            PregledList.Clear();
            foreach (var item in list)
            {
                PregledList.Add(item);
            }

        }

    }
}
