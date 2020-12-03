using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class CartViewModel
    {
        public List<Product> Products { get; set; }
        public double TotalValue { get; set; }
        public string UserName { get; set; }
    }
}
