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
    public partial class RezervacijeOdbijenePage : ContentPage
    {
        private RezervacijeOdbijeneViewModel _model = null;
        public RezervacijeOdbijenePage()
        {
            InitializeComponent();
            BindingContext = _model = new RezervacijeOdbijeneViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _model.Init();
        }
    }
}