﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string QuantityType { get; set; }
        public bool BasicRecipe { get; set; }

        public Ingredient()
        {
            BasicRecipe = false;
        }
    }
}
