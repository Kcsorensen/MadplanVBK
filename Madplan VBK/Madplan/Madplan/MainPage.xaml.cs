﻿using Madplan.Extensions;
using Madplan.Views.FoodTools;
using Madplan.Views.RecipeTools;
using Madplan.Views.WeekPlaner;
using System;
using Xamarin.Forms;

namespace Madplan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Day_Tapped(object sender, EventArgs e)
        {
            var day = (sender as NavigateNextCell).ClassId;

            Navigation.PushAsync(new DayPage(day));
        }

        private void GroceryList_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GroceryListPage());
        }

        private void Food_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodListPage());
        }

        private void Recipe_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecipeListPage());
        }

    }
}
