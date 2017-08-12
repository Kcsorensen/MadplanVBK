using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomPicker : ViewCell
    {
        public static readonly BindableProperty ItemSourceProperty =
            BindableProperty.Create("ItemSource", typeof(IEnumerable), typeof(ViewCell));

        public static readonly BindableProperty SelectedItemProperty =
            BindableProperty.Create("SelectedItem", typeof(string), typeof(ViewCell), null,
                defaultBindingMode: BindingMode.TwoWay,
                validateValue: null,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    ((CustomPicker)bindable).OnPropertyChanged();
                });

        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(ViewCell));

        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create("Placeholder", typeof(string), typeof(ViewCell), "Vælg en kategori");

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public string SelectedItem
        {
            get { return (string)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public IEnumerable ItemSource
        {
            get { return (IEnumerable)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }

        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }


        public CustomPicker()
        {
            InitializeComponent();
        }
    }
}