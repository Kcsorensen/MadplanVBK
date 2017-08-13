using ExpressMapper;
using Madplan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.RecipeTools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodSubmitPage : ContentPage
    {
        private Food _linkedFood;
        private Food _unlinkedFood;
        private Recipe _recipe;

        public FoodSubmitPage(Food food, Recipe recipe)
        {
            InitializeComponent();

            _linkedFood = food;
            _recipe = recipe;
        }

        protected async override void OnAppearing()
        {
            await Task.Run(() =>
            {
                _unlinkedFood = Mapper.Map<Food, Food>(_linkedFood);
            });

            BindingContext = _unlinkedFood;

            base.OnAppearing();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            _recipe.Ingredients.Add(_unlinkedFood);

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
                _unlinkedFood.QuantityType = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };

            Navigation.PushAsync(page);
        }
    }
}