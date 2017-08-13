using Madplan.Models;
using Madplan.Models.WeekPlaner;
using Madplan.Persistance;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.WeekPlaner
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroceryListPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        public GroceryListPage()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected async override void OnAppearing()
        {
            // TODO: Lav det sådan at ingredienser for grundopskrifter står for sig selv.
            // TODO: Lav en konverter, så samme ingredienser med forskellige quantityTypes kan lægges sammen.

            var weekSelections = await _connection.Table<WeekSelections>().FirstAsync();

            var mondayBreakfast = weekSelections.MondayBreakfast;

            var listOfWeekSelections = weekSelections.GetListOfSelectedMeals();

            List<Food> completeListOfIngredients = new List<Food>();

            foreach (var item in listOfWeekSelections)
            {
                completeListOfIngredients.AddRange(DataModel.Current.ListOfRecipes.Where(a => a.Name == item).First().Ingredients);
            }

            // Find alle ingridients som indgår mere end en gang i completeListOfIngredients
            var listofDuplicates = completeListOfIngredients.GroupBy(a => a.Name).Where(b => b.Count() > 1).Select(c => c).ToList();

            List<Food> sortedListOfIngredients = new List<Food>();

            foreach (var ingredient in completeListOfIngredients)
            {
                // Undersøg om den betragtede ingredient indgår flere gange i completeListOfIngredients.

                // Den betratede ingridient indgår flere gang i completeListOfIngredients. På baggrund heraf undersøges det hvordan den skal addes til sortedListOfIngredients.
                if (listofDuplicates.Any(a => a.Key == ingredient.Name))
                {
                    // Den betragtede ingridient ikke er added til sortedListOfIngredients endnu, hvorfor den skal addes.
                    if (!sortedListOfIngredients.Any(a => a.Name == ingredient.Name))
                    {
                        sortedListOfIngredients.Add(ingredient);
                    }
                    // Den betragtede ingridient er allerede added til sortedListOfIngredients. 
                    // På baggrund heraf undersøges det om QuantityType er den samme som den allerede added ingridient med samme navn.
                    // Hvis QuantityType = Ingen, bliver den kasseret.
                    else
                    {
                        // Bliver kasseret hvis QuantityType = Ingen.
                        if (ingredient.QuantityType != QuantityType.Ingen)
                        {
                            // QuantityType for den betragtede ingridient er den samme som den allerede added ingridient med samme navn. Quantity forsøges med den value den betragtede ingridient har.
                            if (sortedListOfIngredients.Any(a => a.Name == ingredient.Name && a.QuantityType == ingredient.QuantityType))
                            {
                                sortedListOfIngredients.Where(b => b.Name == ingredient.Name && b.QuantityType == ingredient.QuantityType).First().Quantity += ingredient.Quantity;
                            }
                            // QuantityType for den betragtede ingridient er ikke den samme som den allerede added ingridient med samme navn. Den betragtede ingridient addes til sortedListOfIngredients
                            else
                            {
                                sortedListOfIngredients.Add(ingredient);
                            }
                        }
                    }
                }
                // Den betratede ingridient indgår ikke flere gang i completeListOfIngredients og skal derfor bare addes til sortedListOfIngredients
                else
                {
                    sortedListOfIngredients.Add(ingredient);
                }
            }

            BindingContext = sortedListOfIngredients.OrderBy(a => a.Name);

            base.OnAppearing();
        }

        private void ListViewItem_Tapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null)
                return;

            // De-selecter listviewitem
            ((ListView)sender).SelectedItem = null;
        }


    }
}