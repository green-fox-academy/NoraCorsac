using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        Greet Greeting;

        public HomeController(Greet greet)
        {
            Greeting = greet;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Addname(Greet greet)
        {
            Greeting.Name = greet.Name;
            return RedirectToAction("Hello");
        }

        [HttpPost("Hello")]
        public IActionResult Hello(Greet G)
        {
            Greeting.Name = G.Name;
            return View(G);
        }        
    }
}
