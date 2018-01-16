using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaBank.Models;
using SimbaBank.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimbaBank.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public static BankAccountViewModel vm = new BankAccountViewModel();

        [HttpGet("simba")]
        public IActionResult Simba()
        {
            var simbax = new BankAccount
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion"
            };
            return View(simbax);
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            return View(vm);
        }

        [HttpPost("addmoney")]
        public IActionResult Addmoney()
        {
            vm.AddMoney();
            return Redirect("list");
        }

        [HttpPost("addaccount")]
        public IActionResult AddAccount(string name, double balance, string type, bool king, bool good)
        {
            vm.AddAccount(name, balance, type, king, good);
            return Redirect("list");
        }
    }
}
