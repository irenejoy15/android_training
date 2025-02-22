using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPBASIC1
{
    public class Product
    {
        //fields / properties
        //Access Modifier / Data type/ Name of Prop
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU{ get; set; }
        public decimal Price {  get; set; }
        public int Stock { get; set; }
        public string? Dimension {  get; set; }
        public decimal Weight { get; set; } = 0.00m;
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get;set; }

        public Decimal ComputeSellingPrice(decimal markup) {
            var netPrice = Price + markup;
            return netPrice;
        }
    }
}
