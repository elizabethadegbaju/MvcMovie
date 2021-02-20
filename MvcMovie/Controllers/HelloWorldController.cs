using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is the welcome default action...";
        }
        public string Welcome()
        {
            return "This is the welcome action method!";
        }
    }
}
