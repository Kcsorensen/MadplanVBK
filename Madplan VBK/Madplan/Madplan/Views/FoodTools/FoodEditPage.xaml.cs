using Madplan.Models;
using Xamarin.Forms;
using System.Linq;
using Xamarin.Forms.Xaml;
using Madplan.Extensions;
using System.Threading.Tasks;
using ExpressMapper;

namespace Madplan.Views.FoodTools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodEditPage : TabbedPage
    {
        private Food _food;

        public FoodEditPage (Food food)
        {
            // Laves en deep copy af food for at fjerne referencen imellem de to classes
            // TODO: Deep copy af food er ikke lavet som Async. Gør det hvis det føles langsom.
            _food = Mapper.Map<Food, Food>(food);

            BindingContext = _food;

            InitializeComponent();
        }

        private async void Save_Clicked(object sender, System.EventArgs e)
        {
            await DataModel.Current.UpdateFoodAsync(_food);

            await Navigation.PopAsync();
        }
    }
}