using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExchangeRateProvider exchangeRateProvider = GetExchangeRateProvider();
            var exchangeRates = exchangeRateProvider.GetExchangeRates("CAD");
            //operate
        }

        private static IExchangeRateProvider GetExchangeRateProvider()
        {
            int a;
            //app config get value
            a = 1;
            if (a == 1)
                return new ApiExchangeRateProvider();
            if (a == 2)
                return new FileExchangeRateProvider();
            return null;
        }
    }
}
