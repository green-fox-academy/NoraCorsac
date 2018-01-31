using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpringBoot.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpringBoot.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        private CarService carService;

        protected RestController(CarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("search/{brand}")]
        public IActionResult Search([FromRoute]string brand)
        {
            return Json(new { result = "ok", data = carService.GetByBrand(brand) });
        }
    }
}
