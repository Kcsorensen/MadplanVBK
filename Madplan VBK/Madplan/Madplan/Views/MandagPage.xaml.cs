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
    public partial class MandagPage : ContentPage
    {
        public MandagPage()
        {
            InitializeComponent();
        }

        private void Morgenmad_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MorgenmadPage());
        }
    }
}