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
    public partial class LjubimciPrikaz : ContentPage
    {
        LjubimciPrikazViewModel model = null;
        public LjubimciPrikaz()
        {
            InitializeComponent();
            BindingContext = model = new LjubimciPrikazViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var ljubimac = e.SelectedItem as Model.Ljubimac;
            model.LjubimciList.Clear();
            await Navigation.PushAsync(new PreglediDetailPage(ljubimac));


        }
    }
}