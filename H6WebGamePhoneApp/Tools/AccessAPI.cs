using H6WebGamePhoneApp.Entity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace H6WebGamePhoneApp.Tools
{
    public class AccessAPI
    {
        public async Task<bool> LoginIntoProfile(string username, string password)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(SingleTon.APIIP + "/api/auth/login?username=" + username + "&password=" + password).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }

        public async Task<List<Message>> GetMessages(int id)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", SingleTon.GetCurrentUser().token);
            List<Message> messages = new List<Message>();
            try
            {
                HttpResponseMessage response = await client.GetAsync(SingleTon.APIIP + "/api/chat/get?id=" + id);
                if(response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    JArray JMessages = JArray.Parse(json);
                    foreach(JToken element in JMessages)
                    {
                        messages.Add(element.ToObject<Message>());
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return messages;
        }

        public async Task SendMessage(string messageContent)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", SingleTon.GetCurrentUser().token);
            try
            {

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
