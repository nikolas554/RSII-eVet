using Acr.UserDialogs;
using eVet.Model;
using eVet.Model.Request;
using Prism.Commands;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eVet.MobileApp.ViewModels
{
    public class PlacanjeRacunaViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Racun");
        public INavigation Navigation { get; set; }

        #region Variable

        public Model.Racun Racun { get; set; }

        private Kartica _kartica;
        private TokenService TokenService;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;
        #endregion Variable


        #region Public Property
        private string StripeTestApiKey = "sk_test_51J3LDrBoJltPcP1qWAgizblsSq0q2ehky2pBsYOhfQZS7SDT6nrzRokfvmggjLoH6ZRrPM7MWvs4keiTnm78cozS00rnb21Mgw";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }
        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }
        public bool IsTransactionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        public Kartica Kartica
        {
            get { return _kartica; }
            set { SetProperty(ref _kartica, value); }
        }
        #endregion Public Property

        #region Constructor 

        public PlacanjeRacunaViewModel()
        {
            Kartica = new Kartica();
            Title = "Card Details";
        }
        #endregion Constructor




        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {

            Kartica.ExpMonth = Convert.ToInt64(ExpMonth);
            Kartica.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Izvršavanje uplate...");
                await Task.Run(async () =>
                {
                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token: " + Token);
                    if (token != null)
                    {
                        IsTransactionSuccess = MakePayment(Token);
                    }
                    else
                    {

                        UserDialogs.Instance.Alert("Unsesite ispravne podatke o kartici", null, "OK");
                    }


                });
            }
            catch (Exception ex)
            {
                IsTransactionSuccess = false;
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gateway" + ex.Message);
            }
            finally
            {
                if (IsTransactionSuccess)
                {
                    Console.WriteLine("Payment Gateway" + "Payment successiful");
                    var request = new RacunUpdateRequest
                    {
                        IsPlacen = true
                    };

                    var entity = await _service.Update<Model.Racun>(Racun.RacunId, request);
                    UserDialogs.Instance.Alert("Uspješno oste izvršili uplatu", "OK", "OK");
                    UserDialogs.Instance.HideLoading();


                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Uplata nije izvršena", "Greška", "OK");
                   
                }

            }

        });
        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;
                var options = new ChargeCreateOptions
                {
                    Amount = (long)Racun.Iznos * 100,
                    Currency = "bam",
                    Description = "Uplata na korisnika: " + APIService.Username,
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "eVet@gmail.com"
                };
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payment Gatway (CreateCharge)" + ex.Message);
                throw ex;
            }



          
        }
        private string CreateToken()
        {
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = Kartica.Number,
                        ExpYear = Kartica.ExpYear,
                        ExpMonth = Kartica.ExpMonth,
                        Cvc = Kartica.Cvc,
                        Name = "eVet",
                        AddressCity = "Mostar",
                        AddressCountry = "BiH",
                        Currency = "bam"
                    }
                };
                TokenService = new TokenService();
                stripeToken = TokenService.Create(Tokenoptions);
                return stripeToken.Id;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
