using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CS174FINALPROJECTLITSCHER.Models
{ 
    public class Cart
    {
        public int CartId { get; set; }
        public int CartCustomerId  { get; set; }      //foreigh key property
        public CartCustomer cartCustomer { get; set; }   //navigation property
        public DateTime CartDateTime { get; set; }

        public ICollection<CartItem> carts { get; set; }  //navigation property
    }
}
