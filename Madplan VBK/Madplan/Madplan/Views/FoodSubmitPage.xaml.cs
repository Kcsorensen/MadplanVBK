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
    public partial class FoodSubmitPage : ContentPage
    {
        public FoodSubmitPage()
        {
            InitializeComponent();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            var thisPage = Navigation.NavigationStack[Navigation.NavigationStack.Count - 1];
            Navigation.RemovePage(thisPage);

            await Navigation.PopAsync();
        }
    }
}