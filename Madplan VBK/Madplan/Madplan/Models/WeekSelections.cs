using Madplan.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
{
    public class WeekSelections : BaseModel
    {
        private string _mandagMorgenmad;

        public string MandagMorgenmad
        {
            get { return _mandagMorgenmad; }
            set { SetValue(ref _mandagMorgenmad, value); }
        }

        public WeekSelections()
        {
            MandagMorgenmad = "Vælg måltid";
        }
    }
}
