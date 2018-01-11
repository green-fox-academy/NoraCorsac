﻿using Microsoft.AspNetCore.Mvc;
using SayHelloToAll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SayHelloToAll.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public static int Counter { get; set; } = 0;
        public static int Webcounter { get; set; } = 0;

        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting/{name}")]
        public IActionResult Greeting([FromRoute] string name)
        {
            Webcounter++;
            var hello = new Greeting(Webcounter, name);
            return new JsonResult(hello);
        }
    }
}
