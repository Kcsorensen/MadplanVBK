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
	public partial class IngredientCreatePage : ContentPage
	{
        private Ingredient _ingredient;
        private Recipe _recipe;

        public IngredientCreatePage(Food food, Recipe recipe)
        {
            InitializeComponent();

            _ingredient = new Ingredient(food);
            _recipe = recipe;
        }

        protected override void OnAppearing()
        {
            BindingContext = _ingredient;

            base.OnAppearing();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            _recipe.Ingredients.Add(_ingredient);

            var thisPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 1];
            Navigation.RemovePage(thisPage);

            await Navigation.PopAsync();
        }

        private void UnitPicker_Tapped(object sender, EventArgs e)
        {
            var page = new QuantityTypePickerPage();
            page.QuantityTypePicker.ItemSelected += (source, args) =>
            {
                unitPicker.Text = args.SelectedItem.ToString();
                _ingredient.DefaultQuantityType = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }
    }
}