using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RepositoryServicePatternDemo.Core.Models
{
    public class Ticket
    {
        public int ID { get; set; }

        [DisplayName("Movie Name")]
        public string MovieName { get; set; }

        [DisplayName("Sale Price")]
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }
        /// <summary>
        /// Must be between 0 and 1
        /// </summary>
        [DisplayName("Studio Percentage")]
        public decimal StudioCutPercentage { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        [DisplayName("Total Profit")]
        [DataType(DataType.Currency)]
        public decimal Profit
        {
            get
            {
                return (Quantity * SalePrice) - (StudioCutPercentage * (Quantity * SalePrice));
            }
        }

        [DisplayName("Profit Per Item")]
        [DataType(DataType.Currency)]
        public decimal ProfitPerItem
        {
            get
            {
                return SalePrice - (StudioCutPercentage * SalePrice);
            }
        }
    }
}
