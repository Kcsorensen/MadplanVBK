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

            var listOfWeakSelections = weekSelections.GetListOfSelectedMeals();

            List<Ingredient> completeListOfIngredients = new List<Ingredient>();

            foreach (var item in listOfWeakSelections)
            {
                completeListOfIngredients.AddRange(DataModel.Current.ListOfMeals.Where(a => a.Name == item).First().Ingredients);
            }

            // Find alle ingridients som indgår mere end en gang i completeListOfIngredients
            var listofDuplicates = completeListOfIngredients.GroupBy(a => a.Name).Where(b => b.Count() > 1).Select(c => c).ToList();

            List<Ingredient> sortedListOfIngredients = new List<Ingredient>();

            foreach (var ingridient in completeListOfIngredients)
            {
                // Undersøg om den betragtede ingredient indgår flere gange i completeListOfIngredients.

                // Den betratede ingridient indgår flere gang i completeListOfIngredients. På baggrund heraf undersøges det hvordan den skal addes til sortedListOfIngredients.
                if (listofDuplicates.Any(a => a.Key == ingridient.Name))
                {
                    // Den betragtede ingridient ikke er added til sortedListOfIngredients endnu, hvorfor den skal addes.
                    if (!sortedListOfIngredients.Any(a => a.Name == ingridient.Name))
                    {
                        sortedListOfIngredients.Add(ingridient);
                    }
                    // Den betragtede ingridient er allerede added til sortedListOfIngredients. 
                    // På baggrund heraf undersøges det om QuantityType er den samme som den allerede added ingridient med samme navn.
                    // Hvis QuantityType = Ingen, bliver den kasseret.
                    else
                    {
                        // Bliver kasseret hvis QuantityType = Ingen.
                        if (ingridient.QuantityType != QuantityType.Ingen)
                        {
                            // QuantityType for den betragtede ingridient er den samme som den allerede added ingridient med samme navn. Quantity forsøges med den value den betragtede ingridient har.
                            if (sortedListOfIngredients.Any(a => a.Name == ingridient.Name && a.QuantityType == ingridient.QuantityType))
                            {
                                sortedListOfIngredients.Where(b => b.Name == ingridient.Name && b.QuantityType == ingridient.QuantityType).First().Quantity += ingridient.Quantity;
                            }
                            // QuantityType for den betragtede ingridient er ikke den samme som den allerede added ingridient med samme navn. Den betragtede ingridient addes til sortedListOfIngredients
                            else
                            {
                                sortedListOfIngredients.Add(ingridient);
                            }
                        }
                    }
                }
                // Den betratede ingridient indgår ikke flere gang i completeListOfIngredients og skal derfor bare addes til sortedListOfIngredients
                else
                {
                    sortedListOfIngredients.Add(ingridient);
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