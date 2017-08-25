using Madplan.Models;
using SharedLib.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.RecipeTools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodSelectPage : ContentPage
    {
        private Recipe _recipe;

        public FoodSelectPage(Recipe recipe)
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

            Navigation.PushAsync(new FoodSubmitPage(food, _recipe));
        }
    }
}