using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuantityTypePickerPage : ContentPage
	{
        public ListView QuantityTypePicker { get { return listView; } }

        public QuantityTypePickerPage()
        {

            InitializeComponent();

            listView.ItemsSource = QuantityType.Current.CompleteListOfQuantityTypes;
        }
    }
}