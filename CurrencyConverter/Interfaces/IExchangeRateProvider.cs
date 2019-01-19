using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    interface IExchangeRateProvider
    {
        Dictionary<string, float> GetExchangeRates(string baseCurrency);
    }

}
