using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class AdminCartViewModel
    {
        public List<Cart> carts { get; set; }

        public  IDictionary<int, CartCustomer> customerInformation { get; set; }
    }
}
