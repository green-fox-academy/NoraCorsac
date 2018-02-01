using Microsoft.AspNetCore.Mvc;
using SpringBoot.Services;

namespace SpringBoot.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        private CarService carService;

        public RestController(CarService carService)
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
