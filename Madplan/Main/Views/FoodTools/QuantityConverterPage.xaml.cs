using Main.Models;
using SharedLib.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views.FoodTools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuantityConverterPage : ContentPage
	{
        private Food _food;

        public QuantityConverterPage (Food food)
		{
			InitializeComponent ();

            _food = food;

            listView.ItemsSource = food.QuantityConverver.Quantities;
        }

        protected override void OnDisappearing()
        {
            var foodDb = DataModel.Database.GetCollection<Food>();

            foodDb.Update(_food);

            base.OnDisappearing();
        }
    }
}