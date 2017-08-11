using Madplan.Models;
using Xamarin.Forms;
using System.Linq;
using Xamarin.Forms.Xaml;
using Madplan.Extensions;
using System.Threading.Tasks;

namespace Madplan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodEditPage : TabbedPage
    {
        private Food _unreferencedFood;
        private Food _referencedFeed;

        public FoodEditPage (Food food)
        {
            _referencedFeed = food;

            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            _unreferencedFood = new Food();

            // Laves en deep copy af food for at fjerne referencen imellem de to classes

            await Task.Run(() => 
            {
                _unreferencedFood.CopyFrom(_referencedFeed);
            });

            BindingContext = _unreferencedFood;

            base.OnAppearing();
        }

        private async void Save_Clicked(object sender, System.EventArgs e)
        {
            await DataModel.Current.UpdateFoodAsync(_unreferencedFood);

            await Navigation.PopAsync();
        }
    }
}