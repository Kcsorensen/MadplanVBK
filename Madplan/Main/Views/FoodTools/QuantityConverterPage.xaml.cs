using Main.Models;
using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views.FoodTools
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuantityConverterPage : ContentPage
	{
		public QuantityConverterPage (Food food)
		{
			InitializeComponent ();

            listView.ItemsSource = food.QuantityConverver.Quantities;

        }
    }
}