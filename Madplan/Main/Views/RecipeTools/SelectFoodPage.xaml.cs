using Main.Models;
using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views.RecipeTools
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectFoodPage : ContentPage
	{
        private Recipe _recipe;

        public SelectFoodPage(Recipe recipe)
        {
            InitializeComponent();

            _recipe = recipe;

            listView.ItemsSource = DataModel.Current.ListOfFood;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Lav implementation. Tag koder fra FoodListPage
        }

        private void ListViewItem_Tapped(object sender, EventArgs e)
        {
            var food = ((sender as TextCell).CommandParameter as Food);

            Navigation.PushAsync(new IngredientCreatePage(food, _recipe));
        }
    }
}