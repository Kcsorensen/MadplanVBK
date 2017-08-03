using Madplan.Models;
using Madplan.Persistance;
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
    public partial class SelectMealPage : ContentPage
    {
        private DataModel DataModel;
        private string _day;
        private string _dishType;

        public SelectMealPage(string day, string dishType)
        {
            InitializeComponent();

            _day = day;
            _dishType = dishType;

            label.Text = "Opskrifter til " + _dishType.ToLower();

            DataModel = new DataModel();
        }

        protected override void OnAppearing()
        {
            DataModel.PopulateListOfDishes();

            IEnumerable<Dish> ListOfMeals = new List<Dish>();

            if (_dishType == DishType.FirstSnack || _dishType == DishType.SecondSnack)
            {
                ListOfMeals = DataModel.ListOfDishes.Where(a => a.Type == DishType.Snack);
            }
            else
            {
                ListOfMeals = DataModel.ListOfDishes.Where(a => a.Type == _dishType);
            }

            BindingContext = ListOfMeals;

            base.OnAppearing();
        }

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {
            var viewCell = sender as ViewCell;
            var stackLayout = viewCell.View as StackLayout;
            var selectedMeal = (stackLayout.Children[0] as Label).Text;

            await SaveSelected(selectedMeal);

            await Navigation.PopAsync();
        }

        private async Task SaveSelected(string selectedMeal)
        {
            var connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            var weekSelections = await connection.Table<WeekSelections>().FirstAsync();

            if (_day == Day.Monday)
            {
                if (_dishType == DishType.Breakfast)
                    weekSelections.MondayBreakfast = selectedMeal;

                if (_dishType == DishType.FirstSnack)
                    weekSelections.MondayFirstSnack = selectedMeal;

                if (_dishType == DishType.Lunch)
                    weekSelections.MondayLunch = selectedMeal;

                if (_dishType == DishType.SecondSnack)
                    weekSelections.MondaySecondSnack = selectedMeal;

                if (_dishType == DishType.Dinner)
                    weekSelections.MondayDinner = selectedMeal;
            }

            if (_day == Day.Tuesday)
            {
                // TODO: Mangler af udfylde de sidste dage
            }

            if (_day == Day.Wednesday)
            {

            }

            if (_day == Day.Thursday)
            {

            }

            if (_day == Day.Friday)
            {

            }

            if (_day == Day.Saturday)
            {

            }

            if (_day == Day.Sunday)
            {

            }

            await connection.UpdateAsync(weekSelections);
        }
    }
}