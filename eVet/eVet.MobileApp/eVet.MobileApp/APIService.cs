using System;
using Flurl.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eVet.Model;
using Flurl;
using System.Net.Http;
using Xamarin.Forms;


namespace eVet.MobileApp
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int userid { get; set; }



        private string _route;

#if DEBUG
        private string _apiUrl = "http://localhost:6670/api";
#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.azure.com/api/";
#endif

        public APIService(string route)
        {
            _route = route;
        }
        //public async Task<T> GetPreglede<T>(int id)
        //{
        //    var url = $"{_apiUrl}/{_route}/ljubimac?id={id}";

         

        //        return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        
            
        //}

        public async Task<T> Get<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}";

         
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
               
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
         
    

        }


        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Update<T>(int? id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }


 
    }
}
