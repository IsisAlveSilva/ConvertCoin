using ExchangeSystem.API.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeSystem.API.Repository
{
    public interface ICoinService
    {
        IEnumerable<Coin> GetAllCoin();
    }
}
