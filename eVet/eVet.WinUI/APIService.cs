using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eVet.Model;
using eVet.Model.Request;
using Flurl;
using Flurl.Http;

namespace eVet.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int userid { get; set; }

        private string _route;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Update<T>(int id, object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
