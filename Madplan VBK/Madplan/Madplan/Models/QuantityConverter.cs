//using Madplan.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Madplan.Models
//{
//    public class QuantityConverter
//    {
//        public ICollection<Quantity> Quantities { get; set; }

//        public QuantityConverter()
//        {
//            Quantities = new List<Quantity>();

//            foreach (var quantityType in QuantityType.Current.ListForQuantityConverter)
//            {
//                Quantities.Add(new Quantity() { Name = quantityType, Value = 0.0 });
//            }
//        }
//    }
//}
