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
        private string _message;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }        

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string ApiKey
        {
            get { return _apiKey; }
            set { _apiKey = value; }
        }

        public string ApiSecret
        {
            get { return _apiSecret; }
            set { _apiSecret = value; }
        }

        public Nexmo(string key, string secret)
        {
            this._apiKey = key;
            this._apiSecret = secret;
        }
    }
}
