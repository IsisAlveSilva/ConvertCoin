using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeSystem.Models
{
    public class CoinViewModel
    {
        public decimal InputValue { get; set; }
        public decimal ConversionValue { get; set; }
        public string CurrencyConversion { get; set; }
        public string CurrentCurrency { get; set; }
        public IEnumerable<TypeCoin> CoinType { get; set; }

       
    }
    public class TypeCoin
    {
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
