using eVet.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eVet.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezervacijeZahtjevanePage : ContentPage
    {
        private RezervacijeZahtijevaneViewModel _model = null;
        public RezervacijeZahtjevanePage()
        {
            InitializeComponent();
            BindingContext = _model = new RezervacijeZahtijevaneViewModel();
         
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _model.Init();
        }
    }
}