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
    public partial class FoodInfoPage : ContentPage
    {
        private string _foodName;
        private Food _food;

        public FoodInfoPage(string foodName)
        {
            _foodName = foodName;

            if (DataModel.Current.ListOfFood.Any(a => a.Navn == _foodName))
                _food = DataModel.Current.ListOfFood.Where(a => a.Navn == _foodName).First();
            else
                _food = new Food();

            BindingContext = _food;

            InitializeComponent();
        }
    }
}