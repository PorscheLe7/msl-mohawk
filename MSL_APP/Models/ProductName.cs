﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSL_APP.Models
{
    public class ProductName
    {
        [Key]
        public int Id { get; set; }

        // Name of the products
        [Required]
        public string Name { get; set; }

        // Set the quantity limitation for students to get the product key
        public int QuantityLimit { get; set; }

        // Count how many keys left for each product
        public int KeyCount { get; set; }

        // Actived or disabled product. Using integer 0 as actived, 1 as disabled. 0 by default
        public int ActiveStatus { get; set; }
    }
}