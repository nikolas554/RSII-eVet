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
    public partial class RezervacijeMenu : ContentPage
    {
        public RezervacijeMenu()
        {
            InitializeComponent();
        }
        async void DodajRezervacijuButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RezervacijePage());
        }
        async void ZahtjevaneRezervacijeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RezervacijeZahtjevanePage());
        }
        async void OdobreneRezervacijeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RezervacijeOdobrenePage());
        }
        async void OdbijeneRezervacijeButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RezervacijeOdbijenePage());
        }
    }
}