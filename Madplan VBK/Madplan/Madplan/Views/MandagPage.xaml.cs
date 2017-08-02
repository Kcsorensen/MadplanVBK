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
    public partial class MandagPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        public WeekSelections WeekSelections { get; set; }

        public MandagPage()
        {
            InitializeComponent();

            WeekSelections = new WeekSelections();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected async override void OnAppearing()
        {
            await _connection.CreateTableAsync<WeekSelectionsTable>();

            if (await _connection.Table<WeekSelectionsTable>().CountAsync() == 0)
            {
                await _connection.InsertAsync(new WeekSelectionsTable()
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

            var db = await _connection.Table<WeekSelectionsTable>().FirstAsync();

            #region Overfører værdier fra db til WeekSelections

            // Mandag
            WeekSelections.MondayBreakfast = db.MondayBreakfast;
            //WeekSelectionsTable.MondayFirstSnack = "vælg Måltid";
            //WeekSelectionsTable.MondayLunch = "vælg Måltid";
            //WeekSelectionsTable.MondaySecondSnack = "vælg Måltid";
            //WeekSelectionsTable.MondayDinner = "vælg Måltid";

            //// Tirsdag
            //WeekSelectionsTable.TuesdayBreakfast = "vælg Måltid";
            //WeekSelectionsTable.TuesdayFirstSnack = "vælg Måltid";
            //WeekSelectionsTable.TuesdayLunch = "vælg Måltid";
            //WeekSelectionsTable.TuesdaySecondSnack = "vælg Måltid";
            //WeekSelectionsTable.TuesdayDinner = "vælg Måltid";

            //// Onsdag
            //WeekSelectionsTable.WednesdayBreakfast = "vælg Måltid";
            //WeekSelectionsTable.WednesdayFirstSnack = "vælg Måltid";
            //WeekSelectionsTable.WednesdayLunch = "vælg Måltid";
            //WeekSelectionsTable.WednesdaySecondSnack = "vælg Måltid";
            //WeekSelectionsTable.WednesdayDinner = "vælg Måltid";

            //// Torsdag
            //ThursdayBreakfast = "vælg Måltid";
            //ThursdayFirstSnack = "vælg Måltid";
            //ThursdayLunch = "vælg Måltid";
            //ThursdaySecondSnack = "vælg Måltid";
            //ThursdayDinner = "vælg Måltid";

            //// Fredag
            //FridayBreakfast = "vælg Måltid";
            //FridayFirstSnack = "vælg Måltid";
            //FridayLunch = "vælg Måltid";
            //FridaySecondSnack = "vælg Måltid";
            //FridayDinner = "vælg Måltid";

            //// Lørdag
            //SaturdayBreakfast = "vælg Måltid";
            //SaturdayFirstSnack = "vælg Måltid";
            //SaturdayLunch = "vælg Måltid";
            //SaturdaySecondSnack = "vælg Måltid";
            //SaturdayDinner = "vælg Måltid";

            //// Søndag
            //SundayBreakfast = "vælg Måltid";
            //SundayFirstSnack = "vælg Måltid";
            //SundayLunch = "vælg Måltid";
            //SundaySecondSnack = "vælg Måltid";
            //SundayDinner = "vælg Måltid";

            #endregion

            BindingContext = WeekSelections;

            base.OnAppearing();
        }

        private void Morgenmad_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MorgenmadPage());
        }
    }
}