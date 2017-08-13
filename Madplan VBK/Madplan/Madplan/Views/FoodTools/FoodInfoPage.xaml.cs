using Madplan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.FoodTools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodInfoPage : ContentPage
    {
        private string _foodName;
        private Food _food;

        // TODO: Mangler at lave rediger click event

        public FoodInfoPage(string foodName)
        {
            _foodName = foodName;

            if (DataModel.Current.ListOfFood.Any(a => a.Name == _foodName))
                _food = DataModel.Current.ListOfFood.Where(a => a.Name == _foodName).First();
            else
                _food = new Food();

            BindingContext = _food;

            InitializeComponent();
        }

        private void Edit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodEditPage(_food));
        }
    }
}