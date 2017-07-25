using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Practica5.Models;

namespace Practica5.Services
{
    class ApiRNC : IApiRNC
    {
        public async Task<RNC> GetRNC(string rnc)
        {
            HttpClient client = new HttpClient();

            var result = await client.GetStringAsync("http://api.marcos.do/rnc/" + rnc);
            var resultJson = JsonConvert.DeserializeObject<RNC>(result);

            return resultJson;
        }
    }
}