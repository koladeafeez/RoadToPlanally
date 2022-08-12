using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ALEXA_SETTINGS
{
    public class AlexaConfiguration
    {
        public string OwnerName { get; set; }
        private string _greetingMessage { get; set; }
        public string GreetingMessage
        {
            get
            {
                if (string.IsNullOrEmpty(this.OwnerName) || string.IsNullOrWhiteSpace(this.OwnerName))
                    return "hello, i am Alexa";
                else
                    return this._greetingMessage.Replace("{OwnerName}", this.OwnerName);
            }
            set
            {
                this._greetingMessage = value;
            }
        }

    }
}