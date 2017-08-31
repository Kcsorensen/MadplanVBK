using SharedLib.Extensions;
using SharedLib.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views.FoodTools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodEditPage : TabbedPage
    {
        private Food _foodNoneClone;
        private Food _foodClone;

        public FoodEditPage(Food food)
        {
            InitializeComponent();

            _foodNoneClone = food;
        }

        protected async override void OnAppearing()
        {
            // Laves en deep copy af food for at fjerne referencen imellem de to classes
            // TODO: Deep copy af food er ikke lavet som Async. Gør det hvis det føles langsom.
            //_foodClone = await ExtensionMethods.CloneAsync<Food>(_foodNoneClone);

            BindingContext = _foodNoneClone;

            base.OnAppearing();
        }

        private async void Save_Clicked(object sender, System.EventArgs e)
        {
            //await DataModel.Current.UpdateFoodAsync(_food);

            //await Navigation.PopAsync();
        }

        private void QuantityConverter_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new QuantityConverterPage(_foodNoneClone));
        }
    }
}