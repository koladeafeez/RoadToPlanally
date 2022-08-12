using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _4_ALEXA_SETTINGS
{


    public class Alexa
    {
    
        private AlexaConfiguration _config { get; set; }
        private AlexaConfiguration Configurations
        {
            get
            {
                return this._config = this._config == null ? new AlexaConfiguration() : this._config;
            }
            set
            {
                this._config = value;
            }
        }



        public void Configure(Action<AlexaConfiguration> setting)
        {
            // invoke configuratons
            setting.Invoke(Configurations);
        }


        public string Talk()
        {
            // return set greeting message
            return Configurations.GreetingMessage;
        }


    }
}
