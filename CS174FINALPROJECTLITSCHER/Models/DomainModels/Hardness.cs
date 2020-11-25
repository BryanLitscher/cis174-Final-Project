using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class Hardness
    {
        [MaxLength(10)]
        [Required(ErrorMessage = "Please enter a hardness id.")]
        public string HardnessID { get; set; }

        [Required(ErrorMessage = "Please enter a value.")]
        public String Moisture { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
