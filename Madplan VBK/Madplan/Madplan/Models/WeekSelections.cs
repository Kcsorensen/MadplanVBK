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
        private string _mondayBreakfast;

        public string MondayBreakfast
        {
            get { return _mondayBreakfast; }
            set { SetValue(ref _mondayBreakfast, value); }
        }

    }
}
