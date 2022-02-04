using Globalization.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Localization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Globalization.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHtmlLocalizer<HomeController> localizer;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , IHtmlLocalizer<HomeController> localizer)
        {
            _logger = logger;
            this.localizer= localizer;
        }

        public IActionResult Index()
        {
            var test = localizer["Hello World"];
            ViewData["Hello World"] = test;
            return View();
        }
        public IActionResult Info()
        {
            var Example = localizer["Employee Name"];
            ViewData["Employee Name"] = Example;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
