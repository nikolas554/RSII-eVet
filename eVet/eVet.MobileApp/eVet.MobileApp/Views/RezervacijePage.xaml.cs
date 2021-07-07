using eVet.MobileApp.ViewModels;
using eVet.Model.Request;
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
    public partial class RezervacijePage : ContentPage
    {
 
        private RezervacijeViewModel _model;
        public RezervacijePage()
        {
            InitializeComponent();
            this.BindingContext = _model = new RezervacijeViewModel();
        }
        protected override async void OnAppearing()
        {

            base.OnAppearing();
            await _model.Init();
        }
   
    }
}