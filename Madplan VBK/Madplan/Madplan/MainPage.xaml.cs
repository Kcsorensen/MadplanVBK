using Madplan.Models;
using Madplan.Views;
using System;
using Xamarin.Forms;

namespace Madplan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Mandag_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MandagPage());
        }
    }
}
