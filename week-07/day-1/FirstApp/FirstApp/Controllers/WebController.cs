using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static long Counter = 0;

        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            Counter++;
            var greeting = new Greeting()
            {
                Id = Counter,
                Content = name
            };
            return View(greeting);
        }
    }
}