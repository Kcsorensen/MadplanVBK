﻿using Madplan.Models;
using Madplan.Models.WeekPlaner;
using Madplan.Persistance;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Madplan
{
    public partial class App : Application
    {
        private SQLiteAsyncConnection _connection;

        public App()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            MainPage = new NavigationPage (new Madplan.MainPage());
        }

        protected async override void OnStart()
        {
            // TODO: Lav en oversigt på Mainpage med gennemsnitlig Ratio for hver dag, og senere kan der laves en samlede energitilskud i kcal.

            await _connection.CreateTableAsync<WeekSelections>();

            if (await _connection.Table<WeekSelections>().CountAsync() == 0)
            {
                await _connection.InsertAsync(new WeekSelections()
                {
                    // Mandag
                    MondayBreakfast = Recipe.Default,
                    MondayFirstSnack = Recipe.Default,
                    MondayLunch = Recipe.Default,
                    MondaySecondSnack = Recipe.Default,
                    MondayDinner = Recipe.Default,

                    // Tirsdag
                    TuesdayBreakfast = Recipe.Default,
                    TuesdayFirstSnack = Recipe.Default,
                    TuesdayLunch = Recipe.Default,
                    TuesdaySecondSnack = Recipe.Default,
                    TuesdayDinner = Recipe.Default,

                    // Onsdag
                    WednesdayBreakfast = Recipe.Default,
                    WednesdayFirstSnack = Recipe.Default,
                    WednesdayLunch = Recipe.Default,
                    WednesdaySecondSnack = Recipe.Default,
                    WednesdayDinner = Recipe.Default,

                    // Torsdag
                    ThursdayBreakfast = Recipe.Default,
                    ThursdayFirstSnack = Recipe.Default,
                    ThursdayLunch = Recipe.Default,
                    ThursdaySecondSnack = Recipe.Default,
                    ThursdayDinner = Recipe.Default,

                    // Fredag
                    FridayBreakfast = Recipe.Default,
                    FridayFirstSnack = Recipe.Default,
                    FridayLunch = Recipe.Default,
                    FridaySecondSnack = Recipe.Default,
                    FridayDinner = Recipe.Default,

                    // Lørdag
                    SaturdayBreakfast = Recipe.Default,
                    SaturdayFirstSnack = Recipe.Default,
                    SaturdayLunch = Recipe.Default,
                    SaturdaySecondSnack = Recipe.Default,
                    SaturdayDinner = Recipe.Default,

                    // Søndag
                    SundayBreakfast = Recipe.Default,
                    SundayFirstSnack = Recipe.Default,
                    SundayLunch = Recipe.Default,
                    SundaySecondSnack = Recipe.Default,
                    SundayDinner = Recipe.Default
                });
            }

            // Load PopulateListOfMealsAsync i en singleton, så det kun skal gøres en gang.
            await DataModel.Current.PopulateListOfRecipesAsync();

            await DataModel.Current.PopulateListOfFoodAsync();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
