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
        private string _day;
        private string _dishType;
        private IEnumerable<Recipe> ListOfMeals;

        public SelectMealPage(string day, string dishType)
        {
            InitializeComponent();

            _day = day;
            _dishType = dishType;

            // Navn på sortSwitch
            if (_dishType == MealType.FirstSnack || _dishType == MealType.SecondSnack)
                sortSwitch.Text = "Sortér efter måltidstype (" + MealType.Snack.ToLower() + ")";
            else
                sortSwitch.Text = "Sortér efter måltidstype (" + _dishType.ToLower() + ")";

            // Navn på tableSectionListOfMeals
            if (_dishType == MealType.FirstSnack || _dishType == MealType.SecondSnack)
                tableSectionListOfMeals.Title = "Oversigt over " + MealType.Snack.ToLower();
            else
                tableSectionListOfMeals.Title = "Oversigt over " + _dishType.ToLower();

        }

        protected async override void OnAppearing()
        {
            // TODO: Lav en switch, så personer kan vælge om de kun vil se mad for den valgte kategori eller om det vil se mad for alle kategorier
            // TODO: Lav en søgefelt

            await sortListOfMealsAsync(_dishType);

            base.OnAppearing();
        }

        private async void Meal_Tapped(object sender, EventArgs e)
        {
            var viewCell = sender as ViewCell;
            var grid = viewCell.View as Grid;
            var stackLayout = grid.Children[0] as StackLayout;
            var selectedMeal = (stackLayout.Children[0] as Label).Text;

            await SaveSelected(selectedMeal);

            await Navigation.PopAsync();
        }

        private async Task SaveSelected(string selectedMeal)
        {
            var connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            var weekSelections = await connection.Table<WeekSelections>().FirstAsync();

            await Task.Run(() => 
            {
                if (_day == Day.Monday)
                {
                    if (_dishType == MealType.Breakfast)
                        weekSelections.MondayBreakfast = selectedMeal;

                    if (_dishType == MealType.FirstSnack)
                        weekSelections.MondayFirstSnack = selectedMeal;

                    if (_dishType == MealType.Lunch)
                        weekSelections.MondayLunch = selectedMeal;

                    if (_dishType == MealType.SecondSnack)
                        weekSelections.MondaySecondSnack = selectedMeal;

                    if (_dishType == MealType.Dinner)
                        weekSelections.MondayDinner = selectedMeal;
                }

                if (_day == Day.Tuesday)
                {
                    if (_dishType == MealType.Breakfast)
                        weekSelections.TuesdayBreakfast = selectedMeal;

                    if (_dishType == MealType.FirstSnack)
                        weekSelections.TuesdayFirstSnack = selectedMeal;

                    if (_dishType == MealType.Lunch)
                        weekSelections.TuesdayLunch = selectedMeal;

                    if (_dishType == MealType.SecondSnack)
                        weekSelections.TuesdaySecondSnack = selectedMeal;

                    if (_dishType == MealType.Dinner)
                        weekSelections.TuesdayDinner = selectedMeal;
                }

                if (_day == Day.Wednesday)
                {
                    if (_dishType == MealType.Breakfast)
                        weekSelections.WednesdayBreakfast = selectedMeal;

                    if (_dishType == MealType.FirstSnack)
                        weekSelections.WednesdayFirstSnack = selectedMeal;

                    if (_dishType == MealType.Lunch)
                        weekSelections.WednesdayLunch = selectedMeal;

                    if (_dishType == MealType.SecondSnack)
                        weekSelections.WednesdaySecondSnack = selectedMeal;

                    if (_dishType == MealType.Dinner)
                        weekSelections.WednesdayDinner = selectedMeal;
                }

                if (_day == Day.Thursday)
                {
                    if (_dishType == MealType.Breakfast)
                        weekSelections.ThursdayBreakfast = selectedMeal;

                    if (_dishType == MealType.FirstSnack)
                        weekSelections.ThursdayFirstSnack = selectedMeal;

                    if (_dishType == MealType.Lunch)
                        weekSelections.ThursdayLunch = selectedMeal;

                    if (_dishType == MealType.SecondSnack)
                        weekSelections.ThursdaySecondSnack = selectedMeal;

                    if (_dishType == MealType.Dinner)
                        weekSelections.ThursdayDinner = selectedMeal;
                }

                if (_day == Day.Friday)
                {
                    if (_dishType == MealType.Breakfast)
                        weekSelections.FridayBreakfast = selectedMeal;

                    if (_dishType == MealType.FirstSnack)
                        weekSelections.FridayFirstSnack = selectedMeal;

                    if (_dishType == MealType.Lunch)
                        weekSelections.FridayLunch = selectedMeal;

                    if (_dishType == MealType.SecondSnack)
                        weekSelections.FridaySecondSnack = selectedMeal;

                    if (_dishType == MealType.Dinner)
                        weekSelections.FridayDinner = selectedMeal;
                }

                if (_day == Day.Saturday)
                {
                    if (_dishType == MealType.Breakfast)
                        weekSelections.SaturdayBreakfast = selectedMeal;

                    if (_dishType == MealType.FirstSnack)
                        weekSelections.SaturdayFirstSnack = selectedMeal;

                    if (_dishType == MealType.Lunch)
                        weekSelections.SaturdayLunch = selectedMeal;

                    if (_dishType == MealType.SecondSnack)
                        weekSelections.SaturdaySecondSnack = selectedMeal;

                    if (_dishType == MealType.Dinner)
                        weekSelections.SaturdayDinner = selectedMeal;
                }

                if (_day == Day.Sunday)
                {
                    if (_dishType == MealType.Breakfast)
                        weekSelections.SundayBreakfast = selectedMeal;

                    if (_dishType == MealType.FirstSnack)
                        weekSelections.SundayFirstSnack = selectedMeal;

                    if (_dishType == MealType.Lunch)
                        weekSelections.SundayLunch = selectedMeal;

                    if (_dishType == MealType.SecondSnack)
                        weekSelections.SundaySecondSnack = selectedMeal;

                    if (_dishType == MealType.Dinner)
                        weekSelections.SundayDinner = selectedMeal;
                }
            });

            await connection.UpdateAsync(weekSelections);
        }

        private async Task sortListOfMealsAsync(string mealType = null)
        {
            ListOfMeals = new List<Recipe>();

            await Task.Run(() =>
            {
                if (mealType == null)
                {
                    ListOfMeals = DataModel.Current.ListOfRecipes;
                }
                else
                {
                    if (mealType == MealType.FirstSnack || mealType == MealType.SecondSnack)
                    {
                        ListOfMeals = DataModel.Current.ListOfRecipes.Where(a => a.Type == MealType.Snack);
                    }
                    else
                    {
                        ListOfMeals = DataModel.Current.ListOfRecipes.Where(a => a.Type == mealType);
                    }
                }
            });

            BindingContext = ListOfMeals;

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void sortSwitch_OnChanged(object sender, ToggledEventArgs e)
        {

            if (e.Value == false)
            {
                await sortListOfMealsAsync();
            }
            else
            {
                await sortListOfMealsAsync(_dishType);
            }


            //if (e.Value == false)
            //{
            //    tableSectionListOfMeals.Title = "Oversigt over alle måltider";
            //}
            //else
            //{
            //    if (_dishType == MealType.FirstSnack || _dishType == MealType.SecondSnack)
            //        tableSectionListOfMeals.Title = "Oversigt over " + MealType.Snack.ToLower();
            //    else
            //        tableSectionListOfMeals.Title = "Oversigt over " + _dishType.ToLower();
            //}

        }
    }
}