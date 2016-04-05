using Android.OS;
using Android.App;
using MaterialCalendarLibrary;

namespace MaterialCalendarSample
{
	[Activity (Label = "MaterialCalendarSample", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			var materialCalendar= new MaterialCalendarView(this);

			SetContentView (materialCalendar);
		}
	}
}


