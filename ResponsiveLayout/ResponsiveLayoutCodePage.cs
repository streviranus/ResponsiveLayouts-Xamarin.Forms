using System;
using Xamarin.Forms;

namespace ResponsiveLayout
{
	public class ResponsiveLayoutCodePage : ContentPage
	{
		public ResponsiveLayoutCodePage ()
		{
			var firstNameEntry = new Entry ();
			var middleNameEntry = new Entry ();
			var lastNameEntry = new Entry ();

			var emailEntry = new Entry ();


			var nameStackLayout = LayoutHelper.FormLayout (
				new View [] {
					LayoutHelper.LabelAndEntryLayout (firstNameEntry, "First Name"),
					LayoutHelper.LabelAndEntryLayout (middleNameEntry, "Middle Name"),
					LayoutHelper.LabelAndEntryLayout (lastNameEntry, "Last Name")
				});
			
			var emailStackLayout = LayoutHelper.FormLayout (
				new View[] {
					LayoutHelper.LabelAndEntryLayout (emailEntry, "Email")
				});

			int topPadding = 0;
			if (Device.OS == TargetPlatform.iOS)
				topPadding = 15;

			Content = new ScrollView {
				Content = new StackLayout {
					Padding = new Thickness (0, topPadding, 0, 0),
					Children = {
						nameStackLayout,
						emailStackLayout
					}
				}
			};
		}
	}
}

