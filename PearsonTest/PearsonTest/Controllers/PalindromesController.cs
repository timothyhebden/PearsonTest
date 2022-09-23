using Microsoft.AspNetCore.Mvc;
using PearsonTest.DTOs;
using PearsonTest.Logic.Interfaces.Services;

namespace PearsonTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromesController : ControllerBase
    {
        private readonly IPalindromesService _palindromesService;

        public PalindromesController(IPalindromesService palindromesService)
        {
            _palindromesService = palindromesService;
        }

        [HttpPost("IsWordPalindrome")]
        public IActionResult IsWordPalindrome([FromBody] PalindromeInput input)
        {
            return Ok(_palindromesService.IsWordPalindrome(input));
        }
    }
}
