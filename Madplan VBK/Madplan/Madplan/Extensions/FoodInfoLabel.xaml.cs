using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Extensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodInfoLabel : StackLayout
    {

		public static readonly BindableProperty TextProperty =
			BindableProperty.Create("Text", typeof(string), typeof(ViewCell), null);

		public static readonly BindableProperty ValueProperty =
			BindableProperty.Create("Value", typeof(string), typeof(ViewCell), null);

        public static readonly BindableProperty FontAttributesProperty =
            BindableProperty.Create("FontAttributes", typeof(FontAttributes), typeof(ViewCell), FontAttributes.None);

        

        public string Text
		{
			get { return (string)GetValue(TextProperty); }
			set { SetValue(TextProperty, value); }
		}

        public FontAttributes FontAttributes
        {
            get { return (FontAttributes)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        public string Value
		{
			get { return (string)GetValue(ValueProperty); }
			set
			{
				if (!double.TryParse(value, out double result))
					throw new FormatException("Value i FoodInfoLabel skal være en double");

                

				SetValue(ValueProperty, value);
			}
		}

		public FoodInfoLabel ()
		{
			InitializeComponent ();

            grid.BindingContext = this;
		}
	}
}