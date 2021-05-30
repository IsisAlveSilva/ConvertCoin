using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeSystem.API.Modal
{
    public class Coin
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal price_usd { get; set; }
    }
}
