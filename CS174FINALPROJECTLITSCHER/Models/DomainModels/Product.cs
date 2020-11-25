using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class Product
    {
        public int productID { get; set; }        
        
        [Required(ErrorMessage = "Please select a texture.")]
        public string HardnessID { get; set; } //foreign key property
        public Hardness Hardness { get; set; } //navigation property

        [Required(ErrorMessage = "Please select an appearance.")]
        public string AppearanceID { get; set; }  //foreign key property
        public Appearance Appearance { get; set; } //navigation property

        [Required(ErrorMessage = "Please select am image.")]
        public string ImageFile { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(50)]
        public string productName { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(200)]
        public string productDesc { get; set; }
        [Required(ErrorMessage = "Please enter a price.")]
        public double productPrice { get; set; }
        [Required(ErrorMessage = "Please enter a nominal weight.")]
        public double productNominalWeight { get; set; }
        public int quantityOrdered { get; set; }
    }
}
