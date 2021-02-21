﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numtimes = 1)
        {
            ViewData["Message"] = $"Hello, {name}! Welcome to Elizabeth's Movie App";
            ViewData["NumTimes"] = numtimes;
            return View();
        }
    }
}
