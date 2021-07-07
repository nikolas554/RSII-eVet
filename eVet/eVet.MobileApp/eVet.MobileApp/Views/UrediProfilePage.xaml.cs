using eVet.MobileApp.ViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eVet.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrediProfilePage : ContentPage
    {
        private UrediProfileViewModel model = null;
        public UrediProfilePage()
        {
            InitializeComponent();
            BindingContext = model = new UrediProfileViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
          
        private async void btnSelectPic_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Error", "This is not support on your device.", "OK");
                return;
            }
            else
            {
                var mediaOption = new PickMediaOptions()
                {
                    PhotoSize = PhotoSize.Small
                };
                _mediaFile = await CrossMedia.Current.PickPhotoAsync();
                if (_mediaFile == null) return;

                Stream stream1 = _mediaFile.GetStream();
                Stream stream2 = _mediaFile.GetStream();
                byte[] resizedImage1 = null;
                byte[] resizedImage2 = null;

                resizedImage1 = ResizeImage(stream1);
                resizedImage2 = ResizeImage(stream2);

                Profilna.Source = ImageSource.FromStream(() => new MemoryStream(resizedImage1));
                model.Korisnik.Slika = resizedImage2;
            }
        }
        private MediaFile _mediaFile;
        protected byte[] ResizeImage(Stream stream)
        {
            byte[] resizedImage = null;
            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                resizedImage = ms.ToArray();
            }

            //if (Device.RuntimePlatform == Device.Android)
            //    resizedImage = DependencyService.Get<IMediaService>().ResizeImage(resizedImage, 500, 500);

            return resizedImage;

        }
    }
}