using Microsoft.AspNetCore.Mvc;
using SayHelloToAll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayHelloToAll.Controllers
{
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
                Content = "World"
            };
            return View(greeting);
        }
    }
}
