using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace NexmoClient
{
    class NexmoCall
    {
        private string baseUrl = "https://api.nexmo.com/tts/json";

        public void MakeCall(Nexmo nex)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("?api_key={key}&api_secret={secret}&to={phone}&text={message}");
            request.AddParameter("key", nex.ApiKey);
            request.AddParameter("secret", nex.ApiSecret);
            request.AddParameter("phone", nex.Phone);
            request.AddParameter("message", nex.Message.Replace(' ', '+'));
            client.Execute(request);
        }
    }
}
