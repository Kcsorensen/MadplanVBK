using Madplan.Extensions;
using Madplan.Models;
using Madplan.Models.WeekPlaner;
using Madplan.Persistance;
using SQLite;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.WeekPlaner
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
            await populateDaySelectionsAsync();

            base.OnAppearing();
        }

        private async Task populateDaySelectionsAsync()
        {
            WeekSelections = await _connection.Table<WeekSelections>().FirstAsync();

            await Task.Run(() =>
            {
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
            });

            BindingContext = DaySelections;
        }

        private void SelectMeal_Tapped(object sender, EventArgs e)
        {
            var dishType = (sender as NavigateNextCell).ClassId;

            Navigation.PushAsync(new SelectMealPage(_day, dishType));
        }

        private async void Clear_Clicked(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (_day == Day.Monday)
                {
                    WeekSelections.MondayBreakfast = Recipe.Default;
                    WeekSelections.MondayFirstSnack = Recipe.Default; 
                    WeekSelections.MondayLunch = Recipe.Default;
                    WeekSelections.MondaySecondSnack = Recipe.Default;
                    WeekSelections.MondayDinner = Recipe.Default;

                    DaySelections.Breakfast = WeekSelections.MondayBreakfast;
                    DaySelections.FirstSnack = WeekSelections.MondayFirstSnack;
                    DaySelections.Lunch = WeekSelections.MondayLunch;
                    DaySelections.SecondSnack = WeekSelections.MondaySecondSnack;
                    DaySelections.Dinner = WeekSelections.MondayDinner;
                }
                else if (_day == Day.Tuesday)
                {
                    WeekSelections.TuesdayBreakfast = Recipe.Default;
                    WeekSelections.TuesdayFirstSnack = Recipe.Default;
                    WeekSelections.TuesdayLunch = Recipe.Default;
                    WeekSelections.TuesdaySecondSnack = Recipe.Default;
                    WeekSelections.TuesdayDinner = Recipe.Default;

                    DaySelections.Breakfast = WeekSelections.TuesdayBreakfast;
                    DaySelections.FirstSnack = WeekSelections.TuesdayFirstSnack;
                    DaySelections.Lunch = WeekSelections.TuesdayLunch;
                    DaySelections.SecondSnack = WeekSelections.TuesdaySecondSnack;
                    DaySelections.Dinner = WeekSelections.TuesdayDinner;
                }
                else if (_day == Day.Wednesday)
                {
                    WeekSelections.WednesdayBreakfast = Recipe.Default;
                    WeekSelections.WednesdayFirstSnack = Recipe.Default;
                    WeekSelections.WednesdayLunch = Recipe.Default;
                    WeekSelections.WednesdaySecondSnack = Recipe.Default;
                    WeekSelections.WednesdayDinner = Recipe.Default;

                    DaySelections.Breakfast = WeekSelections.WednesdayBreakfast;
                    DaySelections.FirstSnack = WeekSelections.WednesdayFirstSnack;
                    DaySelections.Lunch = WeekSelections.WednesdayLunch;
                    DaySelections.SecondSnack = WeekSelections.WednesdaySecondSnack;
                    DaySelections.Dinner = WeekSelections.WednesdayDinner;
                }
                else if (_day == Day.Thursday)
                {
                    WeekSelections.ThursdayBreakfast = Recipe.Default;
                    WeekSelections.ThursdayFirstSnack = Recipe.Default;
                    WeekSelections.ThursdayLunch = Recipe.Default;
                    WeekSelections.ThursdaySecondSnack = Recipe.Default;
                    WeekSelections.ThursdayDinner = Recipe.Default;

                    DaySelections.Breakfast = WeekSelections.ThursdayBreakfast;
                    DaySelections.FirstSnack = WeekSelections.ThursdayFirstSnack;
                    DaySelections.Lunch = WeekSelections.ThursdayLunch;
                    DaySelections.SecondSnack = WeekSelections.ThursdaySecondSnack;
                    DaySelections.Dinner = WeekSelections.ThursdayDinner;
                }
                else if (_day == Day.Friday)
                {
                    WeekSelections.FridayBreakfast = Recipe.Default;
                    WeekSelections.FridayFirstSnack = Recipe.Default;
                    WeekSelections.FridayLunch = Recipe.Default;
                    WeekSelections.FridaySecondSnack = Recipe.Default;
                    WeekSelections.FridayDinner = Recipe.Default;

                    DaySelections.Breakfast = WeekSelections.FridayBreakfast;
                    DaySelections.FirstSnack = WeekSelections.FridayFirstSnack;
                    DaySelections.Lunch = WeekSelections.FridayLunch;
                    DaySelections.SecondSnack = WeekSelections.FridaySecondSnack;
                    DaySelections.Dinner = WeekSelections.FridayDinner;
                }
                else if (_day == Day.Saturday)
                {
                    WeekSelections.SaturdayBreakfast = Recipe.Default;
                    WeekSelections.SaturdayFirstSnack = Recipe.Default;
                    WeekSelections.SaturdayLunch = Recipe.Default;
                    WeekSelections.SaturdaySecondSnack = Recipe.Default;
                    WeekSelections.SaturdayDinner = Recipe.Default;

                    DaySelections.Breakfast = WeekSelections.SaturdayBreakfast;
                    DaySelections.FirstSnack = WeekSelections.SaturdayFirstSnack;
                    DaySelections.Lunch = WeekSelections.SaturdayLunch;
                    DaySelections.SecondSnack = WeekSelections.SaturdaySecondSnack;
                    DaySelections.Dinner = WeekSelections.SaturdayDinner;
                }
                else if (_day == Day.Sunday)
                {
                    WeekSelections.SundayBreakfast = Recipe.Default;
                    WeekSelections.SundayFirstSnack = Recipe.Default;
                    WeekSelections.SundayLunch = Recipe.Default;
                    WeekSelections.SundaySecondSnack = Recipe.Default;
                    WeekSelections.SundayDinner = Recipe.Default;

                    DaySelections.Breakfast = WeekSelections.SundayBreakfast;
                    DaySelections.FirstSnack = WeekSelections.SundayFirstSnack;
                    DaySelections.Lunch = WeekSelections.SundayLunch;
                    DaySelections.SecondSnack = WeekSelections.SundaySecondSnack;
                    DaySelections.Dinner = WeekSelections.SundayDinner;
                }

            });

            await _connection.UpdateAsync(WeekSelections);
        }
    }
}