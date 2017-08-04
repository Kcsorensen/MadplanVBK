using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
{
    public class Meal
    {
        public const string Default = "Vælg måltid";

        public string Name { get; set; }
        public string Type { get; set; }
        public double Ratio { get; set; }
        public double Persons { get; set; }
        public int Page { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Meal()
        {
            Ingredients = new List<Ingredient>();
        }
    }

    
}
