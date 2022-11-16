﻿using System;
using System.Collections.Generic;

namespace VoiCoffee.Model
{
    public class Cart
    {
        public string UserName { get; set; }
        public int CartId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
