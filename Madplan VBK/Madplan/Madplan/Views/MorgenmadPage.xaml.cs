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
    public partial class MorgenmadPage : ContentPage
    {
        private DataModel DataModel;

        public MorgenmadPage()
        {
            InitializeComponent();

            DataModel = new DataModel();
        }

        protected override void OnAppearing()
        {
            DataModel.PopulateListOfDishes();

            var ListOfBreakfast = DataModel.ListOfDishes.Where(a => a.Type == DishType.Morgenmad);

            BindingContext = ListOfBreakfast;

            base.OnAppearing();
        }
    }
}