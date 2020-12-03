using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class Appearance
    {
        [MaxLength(10)]
        [Required(ErrorMessage = "Please enter a appearance id.")]
        public string  AppearanceID { get; set; }

        [Required(ErrorMessage = "Please enter a value.")]
        public string Color { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
