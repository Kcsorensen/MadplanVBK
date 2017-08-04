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
    public partial class NavigateNextCell : ViewCell
    {
        // TODO: Lav et felt hvor det fremgår hvor mange retter for den given dag, som er valgt.

        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(ViewCell), null);

        public static readonly BindableProperty TappedProperty =
            BindableProperty.Create("Tapped", typeof(string), typeof(ViewCell), null, BindingMode.Default, null, propertyChanged: (bindable, oldValue, newValue) =>
            {
                ((NavigateNextCell)bindable).OnTapped();
            });

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public NavigateNextCell()
        {
            InitializeComponent();

            stackLayout.BindingContext = this;
        }
    }
}