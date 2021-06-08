using RepositoryServicePatternDemo.Core.Models;
using RepositoryServicePatternDemo.Core.Repositories.Interfaces;
using System.Collections.Generic;

namespace RepositoryServicePatternDemo.Core.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        public List<FoodItem> GetAllSold()
        {
            //In a real project, this is where you would call your database/datastore for this info
            List<FoodItem> items = new List<FoodItem>()
            {
                new FoodItem()
                {
                    ID = 14,
                    Name = "Milk Duds",
                    SalePrice = 4.99M,
                    UnitPrice = 1.69M,
                    Quantity = 43
                },
                new FoodItem()
                {
                    ID = 3,
                    Name = "Sour Gummy Worms",
                    SalePrice = 4.89M,
                    UnitPrice = 1.13M,
                    Quantity = 319
                },
                new FoodItem()
                {
                    ID = 18,
                    Name = "Large Soda",
                    SalePrice = 5.69M,
                    UnitPrice = 0.47M,
                    Quantity = 319
                },
                new FoodItem()
                {
                    ID = 19,
                    Name = "X-Large Soda",
                    SalePrice = 6.19M,
                    UnitPrice = 0.59M,
                    Quantity = 252
                },
                new FoodItem()
                {
                    ID = 1,
                    Name = "Large Popcorn",
                    SalePrice = 5.59M,
                    UnitPrice = 1.12M,
                    Quantity = 217
                }
            };

            return items;
        }
    }
}
