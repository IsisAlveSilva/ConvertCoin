using ExchangeSystem.API.Modal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace ExchangeSystem.API.Repository
{
    public class CoinService : ICoinService
    {
        public IEnumerable <Coin> GetAllCoin()
        {
                string url = "https://api.coinlore.net";

                HttpClient httpClient = new HttpClient();
                try
                {

                    var result = httpClient.GetAsync($"{url}/api/coin/markets/?id=90").Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var listCoin = JsonSerializer.Deserialize<IEnumerable<Coin>>(result.Content.ReadAsStringAsync().Result);

                        return listCoin;
                    }
                    return new List<Coin>();
                }
                catch (Exception)
                {
                    throw new Exception();
                }


        }
    }
}
