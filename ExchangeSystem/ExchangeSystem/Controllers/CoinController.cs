using ExchangeSystem.Models;
using ExchangeSystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExchangeSystem.Controllers
{
    [ApiController]
    [Route("exchange/coin")]
    public class CoinController : Controller
    {
        static readonly private ICoinService _service = new CoinService();

        [HttpGet]
        public IActionResult Index()
        {
            var listCoin = _service.GetAllCoins();
            CoinViewModel coinViewModel = new CoinViewModel();
            coinViewModel.CoinType = listCoin.Select(c => new TypeCoin
            {
                Type = c.name,
                Name = c.name
            }).ToList();

            ViewBag.TypesCoin = coinViewModel.CoinType.Select(c => new SelectListItem

            {
                Text = c.Name,
                Value = c.Type


            });
            return View(coinViewModel);
        }
        [HttpPost]
        public IActionResult Send([FromForm] CoinViewModel coin)
        {
           var convert = _service.ConvertCurrency(coin);
            
            return View("Index", convert);
        }
    }
}
