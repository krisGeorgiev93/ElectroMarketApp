﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMarket.Data.Models
{
    public class WishlistProduct
    {
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
