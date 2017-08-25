using Madplan.Models;
using SharedLib.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.FoodTools
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