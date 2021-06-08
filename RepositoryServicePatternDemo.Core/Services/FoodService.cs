using RepositoryServicePatternDemo.Core.Models;
using RepositoryServicePatternDemo.Core.Repositories.Interfaces;
using RepositoryServicePatternDemo.Core.Services.Interfaces;
using System.Collections.Generic;

namespace RepositoryServicePatternDemo.Core.Services
{
    public class FoodService : IFoodService 
    {
        private readonly IFoodRepository _foodRepo;

        public FoodService(IFoodRepository foodRepo)
        {
            _foodRepo = foodRepo;
        }

        public List<FoodItem> GetAllSold() => _foodRepo.GetAllSold();
    }
}
