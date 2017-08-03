using Madplan.Extensions;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
{
    public class WeekSelections : BaseModel
    {
        #region private fields

        // Mandag 
        private string _mondayBreakfast;
        private string _mondayFirstSnack;
        private string _mondayLunch;
        private string _mondaySecondSnack;
        private string _mondayDinner;

        // Tirsdag
        private string _tuesdayBreakfast;
        private string _tuesdayFirstSnack;
        private string _tuesdayLunch;
        private string _tuesdaySecondSnack;
        private string _tuesdayDinner;

        // Onsdag
        private string _wednesdayBreakfast;
        private string _wednesdayFirstSnack;
        private string _wednesdayLunch;
        private string _wednesdaySecondSnack;
        private string _wednesdayDinner;

        // Torsdag
        private string _thursdayBreakfast;
        private string _thursdayFirstSnack;
        private string _thursdayLunch;
        private string _thursdaySecondSnack;
        private string _thursdayDinner;

        // Fredag
        private string _fridayBreakfast;
        private string _fridayFirstSnack;
        private string _fridayLunch;
        private string _fridaySecondSnack;
        private string _fridayDinner;

        // Lørdag
        private string _saturdayBreakfast;
        private string _saturdayFirstSnack;
        private string _saturdayLunch;
        private string _saturdaySecondSnack;
        private string _saturdayDinner;

        // Søndag
        private string _sundayBreakfast;
        private string _sundayFirstSnack;
        private string _sundayLunch;
        private string _sundaySecondSnack;
        private string _sundayDinner;

        #endregion

        #region public properties

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        // Mandag
        public string MondayBreakfast
        {
            get { return _mondayBreakfast; }
            set { SetValue(ref _mondayBreakfast, value); }
        }
        public string MondayFirstSnack
        {
            get { return _mondayFirstSnack; }
            set { SetValue(ref _mondayFirstSnack, value); }
        }
        public string MondayLunch
        {
            get { return _mondayLunch; }
            set { SetValue(ref _mondayLunch, value); }
        }
        public string MondaySecondSnack
        {
            get { return _mondaySecondSnack; }
            set { SetValue(ref _mondaySecondSnack, value); }
        }
        public string MondayDinner
        {
            get { return _mondayDinner; }
            set { SetValue(ref _mondayDinner, value); }
        }

        // Tirsdag

        public string TuesdayBreakfast
        {
            get { return _tuesdayBreakfast; }
            set { SetValue(ref _tuesdayBreakfast, value); }
        }
        public string TuesdayFirstSnack
        {
            get { return _tuesdayFirstSnack; }
            set { SetValue(ref _tuesdayFirstSnack, value); }
        }
        public string TuesdayLunch
        {
            get { return _tuesdayLunch; }
            set { SetValue(ref _tuesdayLunch, value); }
        }
        public string TuesdaySecondSnack
        {
            get { return _tuesdaySecondSnack; }
            set { SetValue(ref _tuesdaySecondSnack, value); }
        }
        public string TuesdayDinner
        {
            get { return _tuesdayDinner; }
            set { SetValue(ref _tuesdayDinner, value); }
        }

        // Onsdag

        public string WednesdayBreakfast
        {
            get { return _wednesdayBreakfast; }
            set { SetValue(ref _wednesdayBreakfast, value); }
        }
        public string WednesdayFirstSnack
        {
            get { return _wednesdayFirstSnack; }
            set { SetValue(ref _wednesdayFirstSnack, value); }
        }
        public string WednesdayLunch
        {
            get { return _wednesdayLunch; }
            set { SetValue(ref _wednesdayLunch, value); }
        }
        public string WednesdaySecondSnack
        {
            get { return _wednesdaySecondSnack; }
            set { SetValue(ref _wednesdaySecondSnack, value); }
        }
        public string WednesdayDinner
        {
            get { return _wednesdayDinner; }
            set { SetValue(ref _wednesdayDinner, value); }
        }

        // Torsdag

        public string ThursdayBreakfast
        {
            get { return _thursdayBreakfast; }
            set { SetValue(ref _thursdayBreakfast, value); }
        }
        public string ThursdayFirstSnack
        {
            get { return _thursdayFirstSnack; }
            set { SetValue(ref _thursdayFirstSnack, value); }
        }
        public string ThursdayLunch
        {
            get { return _thursdayLunch; }
            set { SetValue(ref _thursdayLunch, value); }
        }
        public string ThursdaySecondSnack
        {
            get { return _thursdaySecondSnack; }
            set { SetValue(ref _thursdaySecondSnack, value); }
        }
        public string ThursdayDinner
        {
            get { return _thursdayDinner; }
            set { SetValue(ref _thursdayDinner, value); }
        }

        // Fredag

        public string FridayBreakfast
        {
            get { return _fridayBreakfast; }
            set { SetValue(ref _fridayBreakfast, value); }
        }
        public string FridayFirstSnack
        {
            get { return _fridayFirstSnack; }
            set { SetValue(ref _fridayFirstSnack, value); }
        }
        public string FridayLunch
        {
            get { return _fridayLunch; }
            set { SetValue(ref _fridayLunch, value); }
        }
        public string FridaySecondSnack
        {
            get { return _fridaySecondSnack; }
            set { SetValue(ref _fridaySecondSnack, value); }
        }
        public string FridayDinner
        {
            get { return _fridayDinner; }
            set { SetValue(ref _fridayDinner, value); }
        }

        // Lørdag

        public string SaturdayBreakfast
        {
            get { return _saturdayBreakfast; }
            set { SetValue(ref _saturdayBreakfast, value); }
        }
        public string SaturdayFirstSnack
        {
            get { return _saturdayFirstSnack; }
            set { SetValue(ref _saturdayFirstSnack, value); }
        }
        public string SaturdayLunch
        {
            get { return _saturdayLunch; }
            set { SetValue(ref _saturdayLunch, value); }
        }
        public string SaturdaySecondSnack
        {
            get { return _saturdaySecondSnack; }
            set { SetValue(ref _saturdaySecondSnack, value); }
        }
        public string SaturdayDinner
        {
            get { return _saturdayDinner; }
            set { SetValue(ref _saturdayDinner, value); }
        }

        // Søndag

        public string SundayBreakfast
        {
            get { return _sundayBreakfast; }
            set { SetValue(ref _sundayBreakfast, value); }
        }
        public string SundayFirstSnack
        {
            get { return _sundayFirstSnack; }
            set { SetValue(ref _sundayFirstSnack, value); }
        }
        public string SundayLunch
        {
            get { return _sundayLunch; }
            set { SetValue(ref _sundayLunch, value); }
        }
        public string SundaySecondSnack
        {
            get { return _sundaySecondSnack; }
            set { SetValue(ref _sundaySecondSnack, value); }
        }
        public string SundayDinner
        {
            get { return _sundayDinner; }
            set { SetValue(ref _sundayDinner, value); }
        }

        #endregion
    }
}
