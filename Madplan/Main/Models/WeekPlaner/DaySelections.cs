using SharedLib.Extensions;
using SharedLib.Models;

namespace Main.Models.WeekPlaner
{
    public class DaySelections : BaseModel
    {
        private string _breakfast;
        private string _firstSnack;
        private string _lunch;
        private string _secondSnack;
        private string _dinner;

        public string Breakfast
        {
            get { return _breakfast; }
            set { SetValue(ref _breakfast, value); }
        }
        public string FirstSnack
        {
            get { return _firstSnack; }
            set { SetValue(ref _firstSnack, value); }
        }
        public string Lunch
        {
            get { return _lunch; }
            set { SetValue(ref _lunch, value); }
        }
        public string SecondSnack
        {
            get { return _secondSnack; }
            set { SetValue(ref _secondSnack, value); }
        }
        public string Dinner
        {
            get { return _dinner; }
            set { SetValue(ref _dinner, value); }
        }

        public void Clear()
        {
            Breakfast = Recipe.Default;
            FirstSnack = Recipe.Default;
            Lunch = Recipe.Default;
            SecondSnack = Recipe.Default;
            Dinner = Recipe.Default;
        }
    }

}
