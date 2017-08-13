using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.RecipeTools
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealTypePickerPage : ContentPage
    {
        public ListView MealTypePicker { get { return listView; } }

        public MealTypePickerPage()
        {
            InitializeComponent();
        }
    }
}