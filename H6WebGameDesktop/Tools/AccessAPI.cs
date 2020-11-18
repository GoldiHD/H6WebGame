using H6WebGameDesktop.Entity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace H6WebGameDesktop.Tools
{
    class AccessAPI
    {
        public async Task<bool> LoginIntoProfile(string username, string password)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(SingleTon.APIIP + "/api/auth/login?username="+username+ "&password="+password).ConfigureAwait(false);
                if(response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    SingleTon.GetCurrentUser().SetData(JObject.Parse(json).ToObject<User>());
                    return true;
                }
                else
                {
                    Console.WriteLine(response.ReasonPhrase);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }

        public async Task<bool> CreateAccount(string username, string password)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(SingleTon.APIIP + "/api/auth/createaccount?username=" + username + "&password=" + password).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }
    }
}
