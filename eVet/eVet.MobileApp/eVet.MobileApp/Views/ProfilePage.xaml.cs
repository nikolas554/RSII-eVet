using eVet.MobileApp.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eVet.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    { 
        private ProfilViewModel model;
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = model = new ProfilViewModel();
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        async void UrediProfileButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UrediProfilePage());
        }
    }
}