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

        public List<Quantity> Conversions { get; set; }

        public QuantityConverter()
        {
            Conversions = new List<Quantity>();

            foreach (var quantityType in QuantityType.Current.CompleteListOfQuantityTypes)
            {
                Conversions.Add(new Quantity() { Name = quantityType, Value = 0.0 });
            }
        }
    }
}
