﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public List<Hardness> Moisture { get; set; }
        public List<Appearance> Appearance { get; set; }
    }
}
