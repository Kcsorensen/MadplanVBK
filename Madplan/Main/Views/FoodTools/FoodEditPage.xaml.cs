using Main.Models;
using SharedLib.Extensions;
using SharedLib.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views.FoodTools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodEditPage : TabbedPage
    {
        private Food _food;

        public FoodEditPage(Food food)
        {
            InitializeComponent();

            _food = food;
        }

        protected override void OnAppearing()
        {
            BindingContext = _food;

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            var foodDb = DataModel.Database.GetCollection<Food>();

            foodDb.Update(_food);

            base.OnDisappearing();
        }

        private void QuantityConverter_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new QuantityConverterPage(_food));
        }
    }
}