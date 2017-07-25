using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCentralBankSample.Models
{
    public class RNC
    {
        [JsonProperty("rnc")]
        public string rnc { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("commercial_name")]

        public string comercial_name { get; set; }
        [JsonProperty("category")]
    
        public string category { get; set; }
        [JsonProperty("payment_regimen")]
        public string payment_regimen { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
    }
}
