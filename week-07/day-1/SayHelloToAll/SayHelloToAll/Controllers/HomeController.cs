using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayHelloToAll.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("hello")]
        [Route("")]
        public IActionResult Hello()
        {
            return Content("Hello World!");
        }
    }
}
