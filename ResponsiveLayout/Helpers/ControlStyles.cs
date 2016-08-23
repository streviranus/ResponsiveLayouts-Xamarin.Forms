using System;
using ResponsiveLayout;

namespace Xamarin.Forms
{
	public static class ControlStyles
	{
		public static readonly double LabelFontSize = Device.Idiom == TargetIdiom.Phone ? Font.SystemFontOfSize (15).FontSize : Font.SystemFontOfSize (18).FontSize;

		public static Label EntryLabel (string text)
		{
			return new Label {
				Text = text,
				FontSize = LabelFontSize,
				//LineBreakMode = LineBreakMode.TailTruncation
			};
		}
	}
}

