using Main.Models;
using Xamarin.Forms;

namespace Main
{
    public partial class App : Application
	{
        public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}

		protected async override void OnStart()
		{
            // Opret tabeller eller genskab forbindelse til tabeller på den lokale LiteDb 
            // for alle classes som har brug for det under programmets opstart.
            await DataModel.Current.InitiateDataTablesAsync();
        }

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}