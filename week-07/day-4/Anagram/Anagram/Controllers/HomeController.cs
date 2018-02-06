using Anagram.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anagramm.Cotrollers
{
    [Route("")]
    public class HomeController : Controller
    {
        Anagramma anagramms;

        public HomeController(Anagramma anagramms)
        {
            this.anagramms = anagramms;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Checker(Anagramma anagrammas)
        {
            anagramms.Word1 = anagrammas.Word1;
            anagramms.Word2 = anagrammas.Word2;

            return RedirectToAction("Result");
        }

        [HttpGet("Result")]
        public IActionResult Result()
        {
            return View(anagramms);
        }
    }
}