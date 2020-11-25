using System;
using System.ComponentModel.DataAnnotations;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }  //foreign key property
        public Cart Cart { get; set; }   //navigation property
        [StringLength(200)]
        public string CartItemDescription { get; set; }

        public int CartItemQuantity { get; set; }
        public double CartItemUnitPrice { get; set; }

    }
}
