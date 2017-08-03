using Madplan.Extensions;
using Madplan.Models;
using Madplan.Persistance;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private string _day;

        public DaySelections DaySelections { get; set; }

        public WeekSelections WeekSelections { get; set; }

        public DayPage(string day)
        {
            InitializeComponent();

            _day = day;

            DaySelections = new DaySelections();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected async override void OnAppearing()
        {
            await populateDaySelections();

            base.OnAppearing();
        }

        private async Task populateDaySelections()
        {
            WeekSelections = await _connection.Table<WeekSelections>().FirstAsync();

            if (_day == Day.Monday)
            {
                DaySelections.Breakfast = WeekSelections.MondayBreakfast;
                DaySelections.FirstSnack = WeekSelections.MondayFirstSnack;
                DaySelections.Lunch = WeekSelections.MondayLunch;
                DaySelections.SecondSnack = WeekSelections.MondaySecondSnack;
                DaySelections.Dinner = WeekSelections.MondayDinner;
            }
            else if (_day == Day.Tuesday)
            {
                DaySelections.Breakfast = WeekSelections.TuesdayBreakfast;
                DaySelections.FirstSnack = WeekSelections.TuesdayFirstSnack;
                DaySelections.Lunch = WeekSelections.TuesdayLunch;
                DaySelections.SecondSnack = WeekSelections.TuesdaySecondSnack;
                DaySelections.Dinner = WeekSelections.TuesdayDinner;
            }
            else if (_day == Day.Wednesday)
            {
                DaySelections.Breakfast = WeekSelections.WednesdayBreakfast;
                DaySelections.FirstSnack = WeekSelections.WednesdayFirstSnack;
                DaySelections.Lunch = WeekSelections.WednesdayLunch;
                DaySelections.SecondSnack = WeekSelections.WednesdaySecondSnack;
                DaySelections.Dinner = WeekSelections.WednesdayDinner;
            }
            else if (_day == Day.Thursday)
            {
                DaySelections.Breakfast = WeekSelections.ThursdayBreakfast;
                DaySelections.FirstSnack = WeekSelections.ThursdayFirstSnack;
                DaySelections.Lunch = WeekSelections.ThursdayLunch;
                DaySelections.SecondSnack = WeekSelections.ThursdaySecondSnack;
                DaySelections.Dinner = WeekSelections.ThursdayDinner;
            }
            else if (_day == Day.Friday)
            {
                DaySelections.Breakfast = WeekSelections.FridayBreakfast;
                DaySelections.FirstSnack = WeekSelections.FridayFirstSnack;
                DaySelections.Lunch = WeekSelections.FridayLunch;
                DaySelections.SecondSnack = WeekSelections.FridaySecondSnack;
                DaySelections.Dinner = WeekSelections.FridayDinner;
            }
            else if (_day == Day.Saturday)
            {
                DaySelections.Breakfast = WeekSelections.SaturdayBreakfast;
                DaySelections.FirstSnack = WeekSelections.SaturdayFirstSnack;
                DaySelections.Lunch = WeekSelections.SaturdayLunch;
                DaySelections.SecondSnack = WeekSelections.SaturdaySecondSnack;
                DaySelections.Dinner = WeekSelections.SaturdayDinner;
            }
            else if (_day == Day.Sunday)
            {
                DaySelections.Breakfast = WeekSelections.SundayBreakfast;
                DaySelections.FirstSnack = WeekSelections.SundayFirstSnack;
                DaySelections.Lunch = WeekSelections.SundayLunch;
                DaySelections.SecondSnack = WeekSelections.SundaySecondSnack;
                DaySelections.Dinner = WeekSelections.SundayDinner;
            }

            BindingContext = DaySelections;
        }

        private void SelectMeal_Tapped(object sender, EventArgs e)
        {
            var dishType = (sender as NavigateNextCell).ClassId;

            Navigation.PushAsync(new SelectMealPage(_day, dishType));
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            WeekSelections.MondayBreakfast = "Vælg måltid";
        }
    }
}