﻿using LiteDB;
using Main.Models.WeekPlaner;
using Newtonsoft.Json;
using SharedLib.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Main.Models
{
    public class DataModel
    {
        private string Url = "http://nuttynas.dsmynas.com:7500/api/food";
        private HttpClient _client = new HttpClient();

        // Singleton
        public static DataModel Current = new DataModel();

        // LiteDb Database
        public static LiteDatabase Database { get; private set; }

        public ObservableCollection<Food> ListOfFood { get; set; }


        public DataModel()
        {
            ListOfFood = new ObservableCollection<Food>();
        }

        public async Task InitiateDataTablesAsync()
        {
            // Open database (or create if doesn't exist)
            Database = new LiteDatabase(DependencyService.Get<IFileHelper>().GetConnection());

            // WeekSelections Table
            await initiateWeekSelectionsTableAsync();

            // Food Table
            await initiateFoodTableAsync();
        }

        private async Task initiateWeekSelectionsTableAsync()
        {
            // Get a collection (or create, if doesn't exist)
            var weekSelectionsTable = Database.GetCollection<WeekSelections>();

            if (!weekSelectionsTable.Find(a => true).ToList().Any())
            {
                await Task.Run(() =>
                {
                    weekSelectionsTable.Insert(new WeekSelections
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
                });

            }
        }

        private async Task initiateFoodTableAsync()
        {
            // Get a collection (or create, if doesn't exist)
            var foodTable = Database.GetCollection<Food>();

            if (!foodTable.Find(a => true).ToList().Any())
            {
                // Hent data fra API
                var content = await _client.GetStringAsync(Url);

                List<Food> list = await Task.Run(() => JsonConvert.DeserializeObject<List<Food>>(content));

                await Task.Run(() => foodTable.InsertBulk(list));
            }
        }
    }
}