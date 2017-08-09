using Madplan.Extensions;
using Madplan.Models;
using Madplan.Persistance;
using Madplan.Views;
using SQLite;
using System;
using Xamarin.Forms;

namespace Madplan
{
    public partial class MainPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        public MainPage()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected async override void OnAppearing()
        {
            // TODO: Lav en oversigt på Mainpage med gennemsnitlig Ratio for hver dag, og senere kan der laves en samlede energitilskud i kcal.

            await _connection.CreateTableAsync<WeekSelections>();

            if (await _connection.Table<WeekSelections>().CountAsync() == 0)
            {
                await _connection.InsertAsync(new WeekSelections()
                {
                    // Mandag
                    MondayBreakfast = Meal.Default,
                    MondayFirstSnack = Meal.Default,
                    MondayLunch = Meal.Default,
                    MondaySecondSnack = Meal.Default,
                    MondayDinner = Meal.Default,

                    // Tirsdag
                    TuesdayBreakfast = Meal.Default,
                    TuesdayFirstSnack = Meal.Default,
                    TuesdayLunch = Meal.Default,
                    TuesdaySecondSnack = Meal.Default,
                    TuesdayDinner = Meal.Default,

                    // Onsdag
                    WednesdayBreakfast = Meal.Default,
                    WednesdayFirstSnack = Meal.Default,
                    WednesdayLunch = Meal.Default,
                    WednesdaySecondSnack = Meal.Default,
                    WednesdayDinner = Meal.Default,

                    // Torsdag
                    ThursdayBreakfast = Meal.Default,
                    ThursdayFirstSnack = Meal.Default,
                    ThursdayLunch = Meal.Default,
                    ThursdaySecondSnack = Meal.Default,
                    ThursdayDinner = Meal.Default,

                    // Fredag
                    FridayBreakfast = Meal.Default,
                    FridayFirstSnack = Meal.Default,
                    FridayLunch = Meal.Default,
                    FridaySecondSnack = Meal.Default,
                    FridayDinner = Meal.Default,

                    // Lørdag
                    SaturdayBreakfast = Meal.Default,
                    SaturdayFirstSnack = Meal.Default,
                    SaturdayLunch = Meal.Default,
                    SaturdaySecondSnack = Meal.Default,
                    SaturdayDinner = Meal.Default,

                    // Søndag
                    SundayBreakfast = Meal.Default,
                    SundayFirstSnack = Meal.Default,
                    SundayLunch = Meal.Default,
                    SundaySecondSnack = Meal.Default,
                    SundayDinner = Meal.Default
                });
            }

            // Load PopulateListOfMealsAsync i en singleton, så det kun skal gøres en gang.
            await DataModel.Current.PopulateListOfMealsAsync();

            DataModel.Current.ReadCsvFile();

            base.OnAppearing();
        }

        private void Day_Tapped(object sender, EventArgs e)
        {
            var day = (sender as NavigateNextCell).ClassId;

            Navigation.PushAsync(new DayPage(day));
        }

        private void ShoppingList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShoppingListPage());
        }
    }
}
