using Main.Models;
using Main.Models.WeekPlaner;
using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views.WeekPlaner
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroceryListPage : ContentPage
	{
        public GroceryListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            // TODO: Lav det sådan at ingredienser for grundopskrifter står for sig selv.
            // TODO: Lav en konverter, så samme ingredienser med forskellige quantityTypes kan lægges sammen.

            var weekSelections = DataModel.Database.GetCollection<WeekSelections>().FindOne(a => true);

            //var mondayBreakfast = weekSelections.MondayBreakfast;

            var listOfWeekSelections = weekSelections.GetListOfPickedRecipes();

            List<Ingredient> completeListOfIngredients = new List<Ingredient>();

            foreach (var item in listOfWeekSelections)
            {
                completeListOfIngredients.AddRange(DataModel.Current.ListOfRecipes.Where(a => a.Name == item).First().Ingredients);
            }

            // Find alle ingridients som indgår mere end en gang i completeListOfIngredients
            var listofDuplicates = completeListOfIngredients.GroupBy(a => a.Food.Name).Where(b => b.Count() > 1).Select(c => c).ToList();

            List<Ingredient> sortedListOfIngredients = new List<Ingredient>();

            foreach (var ingredient in completeListOfIngredients)
            {
                // Undersøg om den betragtede ingredient indgår flere gange i completeListOfIngredients.

                // Den betratede ingridient indgår flere gang i completeListOfIngredients. På baggrund heraf undersøges det hvordan den skal addes til sortedListOfIngredients.
                if (listofDuplicates.Any(a => a.Key == ingredient.Food.Name))
                {
                    // Den betragtede ingridient ikke er added til sortedListOfIngredients endnu, hvorfor den skal addes.
                    if (!sortedListOfIngredients.Any(a => a.Food.Name == ingredient.Food.Name))
                    {
                        sortedListOfIngredients.Add(ingredient);
                    }
                    // Den betragtede ingridient er allerede added til sortedListOfIngredients. 
                    // På baggrund heraf undersøges det om QuantityType er den samme som den allerede added ingridient med samme navn.
                    // Hvis QuantityType = Ingen, bliver den kasseret.
                    else
                    {
                        // Bliver kasseret hvis QuantityType = Ingen.
                        if (ingredient.DefaultQuantityType != QuantityType.Ingen)
                        {
                            // QuantityType for den betragtede ingridient er den samme som den allerede added ingridient med samme navn. Quantity forsøges med den value den betragtede ingridient har.
                            if (sortedListOfIngredients.Any(a => a.Food.Name == ingredient.Food.Name && a.DefaultQuantityType == ingredient.DefaultQuantityType))
                            {
                                sortedListOfIngredients.Where(b => b.Food.Name == ingredient.Food.Name && b.DefaultQuantityType == ingredient.DefaultQuantityType).First().Quantity += ingredient.Quantity;
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

            BindingContext = sortedListOfIngredients.OrderBy(a => a.Food.Name);

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