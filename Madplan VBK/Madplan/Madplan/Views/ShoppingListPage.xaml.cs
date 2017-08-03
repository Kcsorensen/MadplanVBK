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
    public partial class ShoppingListPage : ContentPage
    {
        private DataModel DataModel;
        private SQLiteAsyncConnection _connection;

        public ShoppingListPage()
        {
            InitializeComponent();

            DataModel = new DataModel();

            DataModel.PopulateListOfDishes();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected async override void OnAppearing()
        {
            var weekSelections = await _connection.Table<WeekSelections>().FirstAsync();

            var mondayBreakfast = weekSelections.MondayBreakfast;

            var shoppinglist = DataModel.ListOfDishes.Where(a => a.Name == mondayBreakfast).First().Ingredients;

            BindingContext = shoppinglist;

            base.OnAppearing();
        }
    }
}