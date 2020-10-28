using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string HardnessID { get; set; }
        public string AppearanceID { get; set; }
        public string ImageFile { get; set; }
        public string productName { get; set; }
        public string productDesc { get; set; }
        public double productPrice { get; set; }
        public double productNominalWeight { get; set; }
        public int quantityOrdered { get; set; }
    }
}
