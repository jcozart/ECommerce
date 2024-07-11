﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
