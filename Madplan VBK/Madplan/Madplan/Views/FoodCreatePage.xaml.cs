﻿using Madplan.Models;
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
    public partial class FoodCreatePage : TabbedPage
    {
        private Food _food;

        public FoodCreatePage ()
        {
            InitializeComponent();

            _food = new Food();

            BindingContext = _food;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(navnEntry.Text))
            {
                DisplayAlert("Fejl", "Madvaren mangler et navn", "OK");
                return;
            }

            DataModel.Current.AddNewFood(_food);

            Navigation.PopAsync();
        }
    }
}