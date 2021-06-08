using Microsoft.AspNetCore.Mvc;
using RepositoryServicePatternDemo.Core.Services.Interfaces;

namespace RepositoryServicePatternDemo.Controllers
{
    public class FinancialController : Controller
    {
        private readonly IFinancialsService _financialService;

        public FinancialController(IFinancialsService financialService)
        {
            _financialService = financialService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}