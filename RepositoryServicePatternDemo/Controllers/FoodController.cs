using Microsoft.AspNetCore.Mvc;
using RepositoryServicePatternDemo.Core.Services.Interfaces;

namespace RepositoryServicePatternDemo.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public IActionResult Index()
        {
            var itemsSold = _foodService.GetAllSold();
            return View(itemsSold);
        }
    }
}