using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class BankAccount : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Simba")]
        public IActionResult Simba()
        {
            BankAccount account = new BankAccount("Simba", "2000", "Lion");
            return View(account);
        }
    }
}
