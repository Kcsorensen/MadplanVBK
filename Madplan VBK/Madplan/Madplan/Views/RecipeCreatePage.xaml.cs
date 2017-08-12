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
    public partial class RecipeCreatePage : ContentPage
    {
        

        public RecipeCreatePage()
        {
            InitializeComponent();
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodSelectPage());
        }
    }
}