using ExchangeSystem.API.Modal;
using ExchangeSystem.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExchangeSystem.API.Controllers
{
    [ApiController]
   [Route("api/[controller]")]
    public class CoinController : Controller
    {
        static readonly private ICoinService repository = new CoinService();

        [HttpGet]
        public IActionResult Index()
        {
            var coins = repository.GetAllCoin();
            return Ok(coins) ;
        }
    }
}
