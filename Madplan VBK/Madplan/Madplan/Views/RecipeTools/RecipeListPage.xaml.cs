﻿using Madplan.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.RecipeTools
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeListPage : ContentPage
	{
		private ObservableCollection<Recipe> _listOfRecipes;

		public RecipeListPage ()
		{
			InitializeComponent ();

			_listOfRecipes = new ObservableCollection<Recipe>();
		}

		protected override void OnAppearing()
		{
			_listOfRecipes = DataModel.Current.ListOfRecipes;

			var listOfRecipeGroups = new ObservableCollection<RecipeGroup>();

			// Morgenmad
			var breakfastGroup = new RecipeGroup("Morgenmad");

			foreach (var recipe in _listOfRecipes.Where(a => a.Type == MealType.Breakfast).OrderBy(b => b.Name, StringComparer.Ordinal))
			{
				breakfastGroup.Add(recipe);
			}

			listOfRecipeGroups.Add(breakfastGroup);

			// Snack
			var snackGroup = new RecipeGroup("Mellemmåltid");

			foreach (var recipe in _listOfRecipes.Where(a => a.Type == MealType.Snack).OrderBy(b => b.Name, StringComparer.Ordinal))
			{
				snackGroup.Add(recipe);
			}

			listOfRecipeGroups.Add(snackGroup);

			// Middagsmad
			var lunchGroup = new RecipeGroup("Middagsmad");

			foreach (var recipe in _listOfRecipes.Where(a => a.Type == MealType.Lunch).OrderBy(b => b.Name, StringComparer.Ordinal))
			{
				lunchGroup.Add(recipe);
			}

			listOfRecipeGroups.Add(lunchGroup);

			// Aftensmad
			var dinnerGroup = new RecipeGroup("Aftensmad");

			foreach (var recipe in _listOfRecipes.Where(a => a.Type == MealType.Dinner).OrderBy(b => b.Name, StringComparer.Ordinal))
			{
				dinnerGroup.Add(recipe);
			}

			listOfRecipeGroups.Add(dinnerGroup);

			listview.ItemsSource = listOfRecipeGroups;

			base.OnAppearing();
		}

		private void Create_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new RecipeCreatePage());
		}

		private void Delete_Clicked(object sender, EventArgs e)
		{

		}

		private void Edit_Clicked(object sender, EventArgs e)
		{

		}

		private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void ListViewItem_Tapped(object sender, EventArgs e)
		{

		}
	}
}