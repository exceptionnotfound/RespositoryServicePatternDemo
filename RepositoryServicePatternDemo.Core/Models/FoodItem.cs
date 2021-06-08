using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RepositoryServicePatternDemo.Core.Models
{
    public class FoodItem
    {
        public int ID { get; set; }

        [DisplayName("Item Name")]
        public string Name { get; set; }

        [DisplayName("Sale Price")]
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }

        [DisplayName("Unit Price")]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Profit")]
        [DataType(DataType.Currency)]
        public decimal Profit
        {
            get
            {
                return (SalePrice * Quantity) - (UnitPrice * Quantity);
            }
        }
    }
}
