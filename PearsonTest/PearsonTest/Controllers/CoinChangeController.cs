using Microsoft.AspNetCore.Mvc;
using PearsonTest.Logic.Interfaces.Services;

namespace PearsonTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinChangeController : ControllerBase
    {
        private readonly ICoinChangeService _coinChangeService;

        public CoinChangeController(ICoinChangeService coinChangeService)
        {
            _coinChangeService = coinChangeService;
        }

        [HttpPost("{changeValue}")]
        public IActionResult HowManyCoinsAreNeeded(int changeValue)
        {
            return Ok(_coinChangeService.HowManyCoinsAreNeeded(changeValue));
        }
    }
}
