using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPBASIC1
{
    public class Order : Product // Inheritance
    {
        public int id;
        public int Quantity { get; set; }

        //public decimal ComputeTotalOrder(decimal Price)
        //{
        //    var total = Price * Quantity;
        //    return total;
        //}
    }
}
