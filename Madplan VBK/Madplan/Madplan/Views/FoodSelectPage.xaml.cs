using Madplan.Models;
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
    public partial class FoodSelectPage : ContentPage
    {
      

        public FoodSelectPage()
        {
            InitializeComponent();

            listView.ItemsSource = DataModel.Current.ListOfFood;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Lav implementation. Tag koder fra FoodListPage
        }

        private void ListViewItem_Tapped(object sender, EventArgs e)
        {
            // Mangler at gemme det valgte mad under opskriften.

            Navigation.PushAsync(new FoodSubmitPage());
        }
    }
}