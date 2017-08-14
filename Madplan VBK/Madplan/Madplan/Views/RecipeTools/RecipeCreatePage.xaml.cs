using Madplan.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.RecipeTools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeCreatePage : TabbedPage
    {
        private Recipe _recipe; 

        public RecipeCreatePage()
        {
            InitializeComponent();

            _recipe = new Recipe();

            _recipe.Ingredients.Add(DataModel.Current.ListOfFood[4]);
            _recipe.Ingredients.Add(DataModel.Current.ListOfFood[20]);
            _recipe.Ingredients.Add(DataModel.Current.ListOfFood[44]);

            BindingContext = _recipe;
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodSelectPage(_recipe));
        }

        private void SaveRecipe_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(recipeName.Value))
            {
                DisplayAlert("Fejl", "Opskriften skal have et navn", "OK");
                return;
            }

            if (string.IsNullOrEmpty(mealPicker.Text) || mealPicker.Text == "Vælg")
            {
                DisplayAlert("Fejl", "Opskriften skal tildeles et måltid", "OK");
                return;
            }

            // TODO: Mangler gem funktion
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var food = menuItem.CommandParameter as Food;

            _recipe.Ingredients.Remove(food);
        }

        private void MealPicker_Tapped(object sender, EventArgs e)
        {
            var page = new MealTypePickerPage();
            page.MealTypePicker.ItemSelected += (source, args) =>
            {
                mealPicker.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }

        private void DefaultQuantityTypePicker_Tapped(object sender, EventArgs e)
        {
            var page = new QuantityTypePickerPage();
            page.QuantityTypePicker.ItemSelected += (source, args) =>
            {
                defaultQuantityTypePicker.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }
    }
}