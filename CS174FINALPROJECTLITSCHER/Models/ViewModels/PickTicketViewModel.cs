﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class PickTicketViewModel
    {
        public List<CartItem> itemList { get;set;}
        public CartCustomer customerInfo { get; set; }
    }
}
