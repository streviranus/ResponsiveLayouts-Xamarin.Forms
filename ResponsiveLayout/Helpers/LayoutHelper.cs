using System;
using System.Collections.Generic;

namespace Xamarin.Forms
{
	public static class LayoutHelper
	{
		private static readonly int EntryHeight = Device.Idiom == TargetIdiom.Tablet ? 50 : 40;

		public static StackLayout FormLayout (View[] formElements){

			StackOrientation orientation = StackOrientation.Horizontal;
			Thickness padding = new Thickness (10, 10, 10, 0);
			double spacing = 10;
			if (Device.Idiom == TargetIdiom.Phone) {
				orientation = StackOrientation.Vertical;
				padding = 5;
			}

			var stackLayout = new StackLayout {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = padding,
				Spacing = spacing,
				Orientation = orientation
			};

			foreach (var element in formElements) {
				stackLayout.Children.Add (element);
			}

			return stackLayout;
		}

		public static StackLayout LabelAndEntryLayout(Entry entry, string labelText){
			Thickness padding = new Thickness (15, 0);

			if (Device.Idiom == TargetIdiom.Phone)
				padding = new Thickness (5, 0);

			SetEntryHeight (entry);

			Label label = ControlStyles.EntryLabel (labelText);

			int extraHeight = 20;

			var stackLayout = new StackLayout {
				Padding = padding,
				Orientation = StackOrientation.Vertical,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.Start,
				WidthRequest = 1, // this will auto expand evenly,
				HeightRequest = EntryHeight + extraHeight, // need this because of WidthRequest = 1
				Children = { label, entry }
			};

			return stackLayout;
		}

		// helper
		public static void SetEntryHeight (View element)
		{
			if (element.GetType () == typeof (Entry) || element.GetType () == typeof (Picker))
				element.HeightRequest = EntryHeight;
		}
	}
}

