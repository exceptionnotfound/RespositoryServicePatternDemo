using RepositoryServicePatternDemo.Core.Models;
using System.Collections.Generic;

namespace RepositoryServicePatternDemo.Core.Services.Interfaces
{
    public interface IFoodService
    {
        List<FoodItem> GetAllSold();
    }
}
