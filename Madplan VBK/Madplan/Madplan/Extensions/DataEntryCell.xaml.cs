﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Madplan.Extensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataEntryCell : ViewCell
	{
		public static readonly BindableProperty LabelProperty =
			BindableProperty.Create("Label", typeof(string), typeof(ViewCell));

		public static readonly BindableProperty UnitProperty =
			BindableProperty.Create("Unit", typeof(string), typeof(ViewCell));

		public static readonly BindableProperty ValueProperty =
		BindableProperty.Create("Value", typeof(string), typeof(ViewCell), null,
			defaultBindingMode: BindingMode.TwoWay,
			validateValue: null,
			propertyChanged: (bindable, oldValue, newValue) =>
			{
				((DataEntryCell)bindable).OnPropertyChanged();
			});

		public static readonly BindableProperty PlaceholderProperty =
			BindableProperty.Create("Placeholder", typeof(string), typeof(ViewCell));

		public new static readonly BindableProperty IsEnabledProperty =
			BindableProperty.Create("IsEnabled", typeof(bool), typeof(ViewCell), true);

		public static readonly BindableProperty KeyboardProperty =
			BindableProperty.Create("Keyboard", typeof(Keyboard), typeof(ViewCell), Keyboard.Numeric);

		public string Label
		{
			get { return (string)GetValue(LabelProperty); }
			set { SetValue(LabelProperty, value); }
		}

		public string Unit
		{
			get { return (string)GetValue(UnitProperty); }
			set { SetValue(UnitProperty, value); }
		}

		public string Value
		{
			get { return (string)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		public string Placeholder
		{
			get { return (string)GetValue(PlaceholderProperty); }
			set { SetValue(PlaceholderProperty, value); }
		}

		public new bool IsEnabled
		{
			get { return (bool)GetValue(IsEnabledProperty); }
			set { SetValue(IsEnabledProperty, value); }
		}

		public Keyboard Keyboard
		{
			get { return (Keyboard)GetValue(KeyboardProperty); }
			set { SetValue(KeyboardProperty, value); }
		}

		public DataEntryCell()
		{
			InitializeComponent();

			
		}
	}
}