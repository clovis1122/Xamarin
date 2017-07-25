using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica5.Models;

namespace Practica5.Services
{
    interface IApiRNC
    {
        Task<RNC> GetRNC(string rnc);
    }
}