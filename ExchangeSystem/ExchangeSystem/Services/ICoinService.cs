using ExchangeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeSystem.Services
{
    public interface ICoinService
    {
        IEnumerable<Coin> GetAllCoins();

        CoinViewModel ConvertCurrency(CoinViewModel coin);
    }
}
