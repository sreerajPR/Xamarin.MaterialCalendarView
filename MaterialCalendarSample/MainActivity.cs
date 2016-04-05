using Android.OS;
using Android.App;
using MaterialCalendarLibrary;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace MaterialCalendarSample
{
	[Activity (Label = "MaterialCalendarSample", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			var materialCalendar= FindViewById<MaterialCalendarView>(Resource.Id.calendarView);

			materialCalendar.SelectionMode = MaterialCalendarView.SelectionModeNone;

			materialCalendar.AddDecorator (new CalendarDayViewDecorator ());
		}
	}
	class CalendarDayViewDecorator:Java.Lang.Object,IDayViewDecorator
	{
		int pp=0;
		public bool ShouldDecorate (CalendarDay p0)
		{
			return ((++pp) % 2 == 0);
		}

		public void Decorate (DayViewFacade p0)
		{
			p0.SetBackgroundDrawable (new ColorDrawable (Color.LightYellow));
		}
	}
}


