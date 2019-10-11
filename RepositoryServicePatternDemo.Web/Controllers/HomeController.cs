using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepositoryServicePatternDemo.Core.Services.Interfaces;
using RepositoryServicePatternDemo.Web.Models;

namespace RepositoryServicePatternDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFinancialsService _financialService;

        public HomeController(IFinancialsService financialService)
        {
            _financialService = financialService;
        }

        public IActionResult Index()
        {
            var totalSold = _financialService.GetTotalSold();
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
