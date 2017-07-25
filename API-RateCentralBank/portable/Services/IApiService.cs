using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RateCentralBankSample.Models;

namespace RateCentralBankSample.Services
{
    interface IApiService
    {
        Task<Rate> GetDollarRate();
    }
}
