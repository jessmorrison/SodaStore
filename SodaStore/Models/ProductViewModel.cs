﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SodaStore.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}

