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
    public partial class PreglediDetailPage : ContentPage
    {
        private PregledDetailViewModel model;
        public PreglediDetailPage(Model.Ljubimac ljubimac)
        {
            InitializeComponent();
            BindingContext = model = new PregledDetailViewModel
            {
                Ljubimac=ljubimac

            };
           
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
          
        }

        private async void Uredi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LjubimacUrediPage(model.Ljubimac));
        }
    }
}