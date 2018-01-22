using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;

namespace Frontend.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input != null)
            {
                return Json(new { received = input, result = input * 2 });
            }
            return Json(new { error = "Please provide an input!" });
        }

        [HttpGet("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (title == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            //if (appendable != null)

            return Json(new { appended = appendable + "a" });
        }

        [HttpGet("appenda")]
        public IActionResult AppendA()
        {
            return NotFound();
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil([FromRoute] string what, [FromBody] Item number)
        {
            
            if (number.until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            else
            {
                if (what.Equals("sum"))
                {
                    int sumNumber = 0;
                    for (int i = 0; i < number.until + 1; i++)
                    {
                        sumNumber += i;
                    }
                    return Json(new { result = sumNumber });
                }
                if (what.Equals("factor"))
                {
                    int factorNumber = 1;
                    for (int i = 1; i < number.until + 1; i++)
                    {
                        factorNumber *= i;
                    }
                    return Json(new { result = factorNumber });
                }
            }
            return Json(new { error = "Please provide a number!" });
        }
    }
}
