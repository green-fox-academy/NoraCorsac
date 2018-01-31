using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpringBoot.Services;
using SpringBoot.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpringBoot.Controllers
{
    [Route("")]
    public class CarController : Controller
    {
        private CarService carService;

        public CarController(CarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery]FilterOptions filterOptions)
        {
            return View(carService.GetFilteredList(filterOptions));
        }

        [HttpGet("search/{brand}")]
        public IActionResult SearchBrand([FromRoute]string brand)
        {
            return View("Search", carService.GetByBrand(brand));
        }
    }
}
