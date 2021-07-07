using eVet.MobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eVet.MobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}