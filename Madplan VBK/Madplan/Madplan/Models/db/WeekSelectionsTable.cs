using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models.db
{
    public class WeekSelectionsTable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        // Mandag
        public string MondayBreakfast { get; set; }
        public string MondayFirstSnack{ get; set; }
        public string MondayLunch { get; set; }
        public string MondaySecondSnack { get; set; }
        public string MondayDinner { get; set; }

        // Tirsdag
        public string TuesdayBreakfast { get; set; }
        public string TuesdayFirstSnack { get; set; }
        public string TuesdayLunch { get; set; }
        public string TuesdaySecondSnack { get; set; }
        public string TuesdayDinner { get; set; }

        // Onsdag
        public string WednesdayBreakfast { get; set; }
        public string WednesdayFirstSnack { get; set; }
        public string WednesdayLunch { get; set; }
        public string WednesdaySecondSnack { get; set; }
        public string WednesdayDinner { get; set; }

        // Torsdag
        public string ThursdayBreakfast { get; set; }
        public string ThursdayFirstSnack { get; set; }
        public string ThursdayLunch { get; set; }
        public string ThursdaySecondSnack { get; set; }
        public string ThursdayDinner { get; set; }

        // Fredag
        public string FridayBreakfast { get; set; }
        public string FridayFirstSnack { get; set; }
        public string FridayLunch { get; set; }
        public string FridaySecondSnack { get; set; }
        public string FridayDinner { get; set; }

        // Lørdag
        public string SaturdayBreakfast { get; set; }
        public string SaturdayFirstSnack { get; set; }
        public string SaturdayLunch { get; set; }
        public string SaturdaySecondSnack { get; set; }
        public string SaturdayDinner { get; set; }

        // Søndag
        public string SundayBreakfast { get; set; }
        public string SundayFirstSnack { get; set; }
        public string SundayLunch { get; set; }
        public string SundaySecondSnack { get; set; }
        public string SundayDinner { get; set; }

    }
}
