using ExchangeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeSystem.Repository
{
    public interface ICoinRepository
    {
        IEnumerable<Coin> GetAllCoin();
      
    }
}
