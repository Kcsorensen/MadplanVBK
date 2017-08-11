using Madplan.Models;
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
    public partial class FoodListPage : ContentPage
    {
        private List<Food> _listOfFood;

        public FoodListPage()
        {
            InitializeComponent();

            _listOfFood = new List<Food>();
        }

        protected override void OnAppearing()
        {
            _listOfFood = DataModel.Current.ListOfFood;

            //var newList = _listOfFood.Where(a => a.Navn.StartsWith("A")).ToList();

            listview.ItemsSource = filterListOfFood();

            base.OnAppearing();
        }

        private IEnumerable<Food> filterListOfFood(string searchText = null)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return _listOfFood;
      
            return _listOfFood.Where(a => a.Navn.ToLowerInvariant().Contains(searchText.ToLowerInvariant())).ToList();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = filterListOfFood(e.NewTextValue);
        }

        private void ListViewItem_Tapped(object sender, EventArgs e)
        {
            var foodName = (sender as TextCell).Text;

            Navigation.PushAsync(new FoodInfoPage(foodName));
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodCreatePage());
        }
    }
}