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
    public partial class RacuniPage : ContentPage
    {
        private RacuniViewModel model = null;
        public RacuniPage()
        {
            InitializeComponent();
            BindingContext = model = new RacuniViewModel();
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Racun_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
        
                var racun = e.SelectedItem as Model.Racun;
           
                await Navigation.PushAsync(new PlacanjeRacuna(racun));
                //await this.Navigation.PushAsync(new PlacanjeRacuna((e.SelectedItem as Model.Racun)));
          
        }



    }
}