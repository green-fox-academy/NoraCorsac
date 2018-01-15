using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Home()
        {
            return View();
        }

        [Route("Info")]
        public IActionResult Info()
        {
            return View("Info");
        }

        [HttpGet("About")]
        public IActionResult About()
        {
            return RedirectToAction("Info");
        }

        [Route("Code")]
        public IActionResult Code()
        {
            return View("Info");
        }

        [HttpGet("Razor")]
        public IActionResult Razor()
        {
            return View("Code");
        }
    }
}
