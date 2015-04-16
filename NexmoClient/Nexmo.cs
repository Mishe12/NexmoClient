using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexmoClient
{
    public class Nexmo
    {
        private string _apiKey;
        private string _apiSecret;
        private string phone;
        private string message;

        public Nexmo(string key, string secret)
        {
            this._apiKey = key;
            this._apiSecret = secret;
        }

        public void PhoneNumber(string number)
        {
            this.phone = number;
        }

        public void SendMessage(string message)
        {
            this.message = message;
        }
    }
}
