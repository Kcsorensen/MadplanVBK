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
            await _connection.CreateTableAsync<WeekSelections>();

            if (await _connection.Table<WeekSelections>().CountAsync() == 0)
            {
                await _connection.InsertAsync(new WeekSelections()
                {
                    // Mandag
                    MondayBreakfast = "Vælg Måltid",
                    MondayFirstSnack = "Vælg Måltid",
                    MondayLunch = "Vælg Måltid",
                    MondaySecondSnack = "Vælg Måltid",
                    MondayDinner = "Vælg Måltid",

                    // Tirsdag
                    TuesdayBreakfast = "Vælg Måltid",
                    TuesdayFirstSnack = "Vælg Måltid",
                    TuesdayLunch = "Vælg Måltid",
                    TuesdaySecondSnack = "Vælg Måltid",
                    TuesdayDinner = "Vælg Måltid",

                    // Onsdag
                    WednesdayBreakfast = "Vælg Måltid",
                    WednesdayFirstSnack = "Vælg Måltid",
                    WednesdayLunch = "Vælg Måltid",
                    WednesdaySecondSnack = "Vælg Måltid",
                    WednesdayDinner = "Vælg Måltid",

                    // Torsdag
                    ThursdayBreakfast = "Vælg Måltid",
                    ThursdayFirstSnack = "Vælg Måltid",
                    ThursdayLunch = "Vælg Måltid",
                    ThursdaySecondSnack = "Vælg Måltid",
                    ThursdayDinner = "Vælg Måltid",

                    // Fredag
                    FridayBreakfast = "Vælg Måltid",
                    FridayFirstSnack = "Vælg Måltid",
                    FridayLunch = "Vælg Måltid",
                    FridaySecondSnack = "Vælg Måltid",
                    FridayDinner = "Vælg Måltid",

                    // Lørdag
                    SaturdayBreakfast = "Vælg Måltid",
                    SaturdayFirstSnack = "Vælg Måltid",
                    SaturdayLunch = "Vælg Måltid",
                    SaturdaySecondSnack = "Vælg Måltid",
                    SaturdayDinner = "Vælg Måltid",

                    // Søndag
                    SundayBreakfast = "Vælg Måltid",
                    SundayFirstSnack = "Vælg Måltid",
                    SundayLunch = "Vælg Måltid",
                    SundaySecondSnack = "Vælg Måltid",
                    SundayDinner = "Vælg Måltid"
                });
            }

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
