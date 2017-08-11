using Madplan.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodEditPage : TabbedPage
    {
        private Food _food;

        public FoodEditPage (Food food)
        {
            _food = food;

            BindingContext = _food;

            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            DataModel.Current.UpdateFood(_food);

            base.OnDisappearing();
        }
    }
}