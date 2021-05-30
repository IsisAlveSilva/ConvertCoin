using ExchangeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExchangeSystem.Services
{
    public class CoinService : ICoinService
    {
        private IEnumerable<Coin> _Coins { get; set; }
        public IEnumerable<Coin> GetAllCoins()

            
        {
            string url = "http://localhost:23667";

            HttpClient httpClient = new HttpClient();
            try
            {

                var result = httpClient.GetAsync($"{url}/api/coin").Result;
                if (result.IsSuccessStatusCode)
                {
                    var listCoin = JsonSerializer.Deserialize<IEnumerable<Coin>>(result.Content.ReadAsStringAsync().Result);
                    _Coins = listCoin;
                    return listCoin;
                }
                return new List<Coin>();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public CoinViewModel ConvertCurrency(CoinViewModel coin)
        {
            
            if (_Coins.Any() is false)
            {
                _Coins = GetAllCoins();
            }
            var moedaAtual = _Coins.FirstOrDefault(priceCurrent => priceCurrent.name == coin.CurrentCurrency);

            if (moedaAtual == null)
            {
                throw new Exception("não foi encontrado moeda");
            }
            decimal precoEmDolarMoedaConversao = _Coins.FirstOrDefault(valeuInUsd => valeuInUsd.name == coin.CurrencyConversion).price_usd;
            decimal multiplicacao = moedaAtual.price_usd * coin.InputValue;
            coin.ConversionValue = multiplicacao * precoEmDolarMoedaConversao; 
            return coin;
        }

    }
}
