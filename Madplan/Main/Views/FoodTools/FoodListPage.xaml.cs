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
        private ObservableCollection<Food> _listOfFood;

        public FoodListPage()
        {
            InitializeComponent();

            _listOfFood = new ObservableCollection<Food>();
        }

        protected override void OnAppearing()
        {
            _listOfFood = DataModel.Current.ListOfFood;

            listView.ItemsSource = filterListOfFood();

            base.OnAppearing();
        }

        private IEnumerable<Food> filterListOfFood(string searchText = null)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return _listOfFood.OrderBy(a => a.Name);

            return _listOfFood.Where(a => a.Name.ToLowerInvariant().Contains(searchText.ToLowerInvariant())).OrderBy(b => b.Name);
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
            //Navigation.PushAsync(new FoodCreatePage());
        }

        private void Edit_Clicked(object sender, EventArgs e)
        {
            //var menuItem = sender as MenuItem;
            //var food = menuItem.CommandParameter as Food;

            //Navigation.PushAsync(new FoodEditPage(food));
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            //var menuItem = sender as MenuItem;
            //var food = menuItem.CommandParameter as Food;

            //DataModel.Current.DeleteFood(food);
        }
    }
}