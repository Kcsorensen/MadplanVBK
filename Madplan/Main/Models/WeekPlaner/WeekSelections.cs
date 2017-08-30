using SharedLib.Extensions;
using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Models.WeekPlaner
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

        // Få en complet liste over alle dage, hvor der er valgt et måltid
        public List<string> GetListOfPickedRecipes()
        {
            var list = new List<string>();

            // Mandag
            if (MondayBreakfast != Recipe.Default)
                list.Add(MondayBreakfast);
            if (MondayFirstSnack != Recipe.Default)
                list.Add(MondayFirstSnack);
            if (MondayLunch != Recipe.Default)
                list.Add(MondayLunch);
            if (MondaySecondSnack != Recipe.Default)
                list.Add(MondaySecondSnack);
            if (MondayDinner != Recipe.Default)
                list.Add(MondayDinner);

            // Tirsdag
            if (TuesdayBreakfast != Recipe.Default)
                list.Add(TuesdayBreakfast);
            if (TuesdayFirstSnack != Recipe.Default)
                list.Add(TuesdayFirstSnack);
            if (TuesdayLunch != Recipe.Default)
                list.Add(TuesdayLunch);
            if (TuesdaySecondSnack != Recipe.Default)
                list.Add(TuesdaySecondSnack);
            if (TuesdayDinner != Recipe.Default)
                list.Add(TuesdayDinner);

            // Onsdag
            if (WednesdayBreakfast != Recipe.Default)
                list.Add(WednesdayBreakfast);
            if (WednesdayFirstSnack != Recipe.Default)
                list.Add(WednesdayFirstSnack);
            if (WednesdayLunch != Recipe.Default)
                list.Add(WednesdayLunch);
            if (WednesdaySecondSnack != Recipe.Default)
                list.Add(WednesdaySecondSnack);
            if (WednesdayDinner != Recipe.Default)
                list.Add(WednesdayDinner);

            // Torsdag
            if (ThursdayBreakfast != Recipe.Default)
                list.Add(ThursdayBreakfast);
            if (ThursdayFirstSnack != Recipe.Default)
                list.Add(ThursdayFirstSnack);
            if (ThursdayLunch != Recipe.Default)
                list.Add(ThursdayLunch);
            if (ThursdaySecondSnack != Recipe.Default)
                list.Add(ThursdaySecondSnack);
            if (ThursdayDinner != Recipe.Default)
                list.Add(ThursdayDinner);

            // Fredag
            if (FridayBreakfast != Recipe.Default)
                list.Add(FridayBreakfast);
            if (FridayFirstSnack != Recipe.Default)
                list.Add(FridayFirstSnack);
            if (FridayLunch != Recipe.Default)
                list.Add(FridayLunch);
            if (FridaySecondSnack != Recipe.Default)
                list.Add(FridaySecondSnack);
            if (FridayDinner != Recipe.Default)
                list.Add(FridayDinner);

            // Lørdag
            if (SaturdayBreakfast != Recipe.Default)
                list.Add(SaturdayBreakfast);
            if (SaturdayFirstSnack != Recipe.Default)
                list.Add(SaturdayFirstSnack);
            if (SaturdayLunch != Recipe.Default)
                list.Add(SaturdayLunch);
            if (SaturdaySecondSnack != Recipe.Default)
                list.Add(SaturdaySecondSnack);
            if (SaturdayDinner != Recipe.Default)
                list.Add(SaturdayDinner);

            // Søndag
            if (SundayBreakfast != Recipe.Default)
                list.Add(SundayBreakfast);
            if (SundayFirstSnack != Recipe.Default)
                list.Add(SundayFirstSnack);
            if (SundayLunch != Recipe.Default)
                list.Add(SundayLunch);
            if (SundaySecondSnack != Recipe.Default)
                list.Add(SundaySecondSnack);
            if (SundayDinner != Recipe.Default)
                list.Add(SundayDinner);

            return list;
        }

        // Hent data for en given dag
        public DaySelections GetDaySelections(string day)
        {
            DaySelections daySelections = new DaySelections();

            if (day == Day.Monday)
            {
                daySelections.Breakfast = MondayBreakfast;
                daySelections.FirstSnack = MondayFirstSnack;
                daySelections.Lunch = MondayLunch;
                daySelections.SecondSnack = MondaySecondSnack;
                daySelections.Dinner = MondayDinner;
            }
            else if (day == Day.Tuesday)
            {
                daySelections.Breakfast = TuesdayBreakfast;
                daySelections.FirstSnack = TuesdayFirstSnack;
                daySelections.Lunch = TuesdayLunch;
                daySelections.SecondSnack = TuesdaySecondSnack;
                daySelections.Dinner = TuesdayDinner;
            }
            else if (day == Day.Wednesday)
            {
                daySelections.Breakfast = WednesdayBreakfast;
                daySelections.FirstSnack = WednesdayFirstSnack;
                daySelections.Lunch = WednesdayLunch;
                daySelections.SecondSnack = WednesdaySecondSnack;
                daySelections.Dinner = WednesdayDinner;
            }
            else if (day == Day.Thursday)
            {
                daySelections.Breakfast = ThursdayBreakfast;
                daySelections.FirstSnack = ThursdayFirstSnack;
                daySelections.Lunch = ThursdayLunch;
                daySelections.SecondSnack = ThursdaySecondSnack;
                daySelections.Dinner = ThursdayDinner;
            }
            else if (day == Day.Friday)
            {
                daySelections.Breakfast = FridayBreakfast;
                daySelections.FirstSnack = FridayFirstSnack;
                daySelections.Lunch = FridayLunch;
                daySelections.SecondSnack = FridaySecondSnack;
                daySelections.Dinner = FridayDinner;
            }
            else if (day == Day.Saturday)
            {
                daySelections.Breakfast = SaturdayBreakfast;
                daySelections.FirstSnack = SaturdayFirstSnack;
                daySelections.Lunch = SaturdayLunch;
                daySelections.SecondSnack = SaturdaySecondSnack;
                daySelections.Dinner = SaturdayDinner;
            }
            else if (day == Day.Sunday)
            {
                daySelections.Breakfast = SundayBreakfast;
                daySelections.FirstSnack = SundayFirstSnack;
                daySelections.Lunch = SundayLunch;
                daySelections.SecondSnack = SundaySecondSnack;
                daySelections.Dinner = SundayDinner;
            }
            else
            {
                throw new ArgumentException("GetDaySelections: input(string) er forkert");
            }

            return daySelections;
        }

        public void UpdateDay(DaySelections daySelections, string day)
        {
            if (daySelections == null)
                throw new NullReferenceException("UpdateDay: Input daySelections må ikke være null");

            if (day == Day.Monday)
            {
                MondayBreakfast = daySelections.Breakfast;
                MondayFirstSnack = daySelections.FirstSnack;
                MondayLunch = daySelections.Lunch;
                MondaySecondSnack = daySelections.SecondSnack;
                MondayDinner = daySelections.Dinner;
            }
            else if (day == Day.Tuesday)
            {
                TuesdayBreakfast = daySelections.Breakfast;
                TuesdayFirstSnack = daySelections.FirstSnack;
                TuesdayLunch = daySelections.Lunch;
                TuesdaySecondSnack = daySelections.SecondSnack;
                TuesdayDinner = daySelections.Dinner;
            }
            else if (day == Day.Wednesday)
            {
                WednesdayBreakfast = daySelections.Breakfast;
                WednesdayFirstSnack = daySelections.FirstSnack;
                WednesdayLunch = daySelections.Lunch;
                WednesdaySecondSnack = daySelections.SecondSnack;
                WednesdayDinner = daySelections.Dinner;
            }
            else if (day == Day.Thursday)
            {
                ThursdayBreakfast = daySelections.Breakfast;
                ThursdayFirstSnack = daySelections.FirstSnack;
                ThursdayLunch = daySelections.Lunch;
                ThursdaySecondSnack = daySelections.SecondSnack;
                ThursdayDinner = daySelections.Dinner;
            }
            else if (day == Day.Friday)
            {
                FridayBreakfast = daySelections.Breakfast;
                FridayFirstSnack = daySelections.FirstSnack;
                FridayLunch = daySelections.Lunch;
                FridaySecondSnack = daySelections.SecondSnack;
                FridayDinner = daySelections.Dinner;
            }
            else if (day == Day.Saturday)
            {
                SaturdayBreakfast = daySelections.Breakfast;
                SaturdayFirstSnack = daySelections.FirstSnack;
                SaturdayLunch = daySelections.Lunch;
                SaturdaySecondSnack = daySelections.SecondSnack;
                SaturdayDinner = daySelections.Dinner;
            }
            else if (day == Day.Sunday)
            {
                SundayBreakfast = daySelections.Breakfast;
                SundayFirstSnack = daySelections.FirstSnack;
                SundayLunch = daySelections.Lunch;
                SundaySecondSnack = daySelections.SecondSnack;
                SundayDinner = daySelections.Dinner;
            }
            else
            {
                throw new ArgumentException("UpdateDay: input(string) er forkert");
            }
        }

    }
}
