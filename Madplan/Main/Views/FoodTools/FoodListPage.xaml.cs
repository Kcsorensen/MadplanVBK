using Main.Models;
using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views.FoodTools
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodListPage : ContentPage
	{
        public FoodListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            listView.ItemsSource = filterListOfFood();

            base.OnAppearing();
        }

        private IEnumerable<Food> filterListOfFood(string searchText = null)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return DataModel.Current.ListOfFood.OrderBy(a => a.Name);

            return DataModel.Current.ListOfFood.Where(a => a.Name.ToLowerInvariant().Contains(searchText.ToLowerInvariant())).OrderBy(b => b.Name);
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = filterListOfFood(e.NewTextValue);
        }

        private void Food_Tapped(object sender, EventArgs e)
        {
            var foodName = (sender as TextCell).Text;

            Navigation.PushAsync(new FoodInfoPage(foodName));
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodCreatePage());
        }

        private void Edit_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var food = menuItem.CommandParameter as Food;

            Navigation.PushAsync(new FoodEditPage(food));
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var food = menuItem.CommandParameter as Food;

            DataModel.Current.RemoveFood(food);

            listView.ItemsSource = filterListOfFood();
        }
    }
}