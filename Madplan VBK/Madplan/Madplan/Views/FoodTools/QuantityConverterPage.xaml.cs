using Madplan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Views.FoodTools
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuantityConverterPage : ContentPage
	{
		public QuantityConverterPage (Food food)
		{
			InitializeComponent ();

            listView.ItemsSource = DataModel.Current.ListOfQuantityConverters.Where(a => a.Id == food.QuantityConververId).First().Conversions; ;
        }
    }
}