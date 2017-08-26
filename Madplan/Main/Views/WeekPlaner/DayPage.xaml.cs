using Main.ExtensionViews;
using Main.Models;
using Main.Models.WeekPlaner;
using SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Main.Views.WeekPlaner
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DayPage : ContentPage
	{
		private string _day;
        private WeekSelections _weekSelections;

		public DaySelections DaySelections { get; set; }
		//public WeekSelections WeekSelections { get; set; }

		public DayPage(string day)
		{
			InitializeComponent();

			_day = day;

            int firstId = DataModel.Database.GetCollection<WeekSelections>().Min();
            _weekSelections = DataModel.Database.GetCollection<WeekSelections>().FindOne(a => a.Id == firstId);

            DaySelections = new DaySelections();
		}

		protected override void OnAppearing()
		{
            DaySelections = _weekSelections.GetDaySelections(_day);

            BindingContext = DaySelections;

            base.OnAppearing();
		}

		private void SelectMeal_Tapped(object sender, EventArgs e)
		{
            var mealType = (sender as NavigateNextCell).ClassId;

            Navigation.PushAsync(new SelectMealPage(_day, mealType));
        }

		private async void Clear_Clicked(object sender, EventArgs e)
		{
            // Ryd alle dagens måltider
            DaySelections.Clear();

            // Opdater dagen i WeekSelections
            _weekSelections.UpdateDay(DaySelections, _day);

            // Opdater WeekSelections i lokal Database
            await Task.Run(() => DataModel.Database.GetCollection<WeekSelections>().Update(_weekSelections));
        }
	}
}