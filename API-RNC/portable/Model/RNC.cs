using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5.Models
{
    class RNC
    {
        [JsonProperty("rnc")]
        public string rnc { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("comercial_name")]
        public string comercialName { get; set; }

        [JsonProperty("category")]
        public string category { get; set; }

        [JsonProperty("payment_regimen")]
        public string paymentRegimen { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }
    }
}
