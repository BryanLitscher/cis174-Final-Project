using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class CartCustomer
    {
        public int CartCustomerId { get; set; }
        public string CartName { get; set; }
        public string CartEmail { get; set; }

        public ICollection<Cart> Carts {get;set;}  //Navigation Property
    }
}
