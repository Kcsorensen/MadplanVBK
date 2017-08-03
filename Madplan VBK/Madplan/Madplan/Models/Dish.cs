using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
{
    public class Dish
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Ratio { get; set; }
        public double Persons { get; set; }
        public int Page { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Dish()
        {
            Ingredients = new List<Ingredient>();
        }
    }

    
}
