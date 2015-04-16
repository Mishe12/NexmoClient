using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using RestSharp;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace NexmoClient
{
    public class NexmoCall
    {
        private string baseUrl = "https://api.nexmo.com/tts/json";

        public string MakeCall(Nexmo nex)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            //client.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded");
            StringContent content = new StringContent("{'Content-Type': 'application/x-www-form-urlencoded'");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string parameters = "?api_key=" + nex.ApiKey + "&api_secret=" + nex.ApiSecret + "&to=" + nex.Phone + "&text=" + nex.Message.Replace(' ', '+');
            HttpResponseMessage response = client.PostAsync(baseUrl + parameters, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return "Success!";
            }
            else
            {
                return response.StatusCode + ": " + response.ReasonPhrase;
            }
            
        }
    }
}
