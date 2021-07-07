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
    public partial class LjubimciView : ContentPage
    {
        public LjubimciView()
        {
            InitializeComponent();
        }
        async void PregledLjubimacaButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LjubimciPrikaz());
        }
        async void DodajLjubimcaButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LjubimciPage());
        }
    }
}