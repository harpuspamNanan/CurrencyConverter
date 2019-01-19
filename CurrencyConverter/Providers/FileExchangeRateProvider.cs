using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class FileExchangeRateProvider : IExchangeRateProvider
    {
        public Dictionary<string, float> GetExchangeRates(string baseCurrency)
        {
            return new Dictionary<string, float>();
        }
    }
}
