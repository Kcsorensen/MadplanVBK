using Madplan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
{
    public class QuantityConverter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DefaultQuantity { get; set; }
        public List<Tuple<string,double>> Conversions { get; set; }

        public QuantityConverter()
        {
            Conversions = new List<Tuple<string, double>>();

            foreach (var quantityType in QuantityType.Current.ListOfQuantityTypes)
            {
                Conversions.Add(new Tuple<string, double>(quantityType, 0.0));
            }
        }
    }
}
