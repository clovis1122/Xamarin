using System;
using System.Threading.Tasks;
using RateCentralBankSample.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace RateCentralBankSample.Services
{
    class ApiService : IApiService
    {
        public async Task<Rate> GetDollarRate()
        {
            HttpClient client = new HttpClient();

            var result = await client.GetStringAsync("http://api.marcos.do/central_bank_rates");
            var resultJson = JsonConvert.DeserializeObject<Rate>(result);

            return resultJson;
        }
    }
}
