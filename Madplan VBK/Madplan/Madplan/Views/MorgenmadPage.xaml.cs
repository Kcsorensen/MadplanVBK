using Madplan.Models;
using Madplan.Models.db;
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

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {
            var viewCell = sender as ViewCell;
            var stackLayout = viewCell.View as StackLayout;
            var labelText = (stackLayout.Children[0] as Label).Text;

            var connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            var db = await connection.Table<WeekSelectionsTable>().FirstAsync();

            db.MondayBreakfast = labelText;

            await connection.UpdateAsync(db);

            await Navigation.PopAsync();
        }
    }
}