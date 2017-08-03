using Madplan.Extensions;
using Madplan.Models;
using Madplan.Models.db;
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