using Android.OS;
using MaterialCalendarLibrary;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.App;
using System;
using Android.Runtime;

namespace MaterialCalendarSample
{
	[Activity (Label = "MaterialCalendarSample", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			var materialCalendar= FindViewById<MaterialCalendarView>(Resource.Id.calendarView);

			materialCalendar.SelectionMode = MaterialCalendarView.SelectionModeSingle;

			materialCalendar.AddDecorator (new CalendarDayViewDecorator ());
		}
	}
	class CalendarDayViewDecorator:Java.Lang.Object,IDayViewDecorator
	{
		
		public bool ShouldDecorate (CalendarDay p0)
		{
			if (p0.Day == 5 || p0.Day == 14 || p0.Day == 25)
				return true;
			else
				return false;
		}

		public void Decorate (DayViewFacade p0)
		{
			p0.SetBackgroundDrawable (new ColorDrawable (Color.Rgb(37,155,36)));
		}
	}
	interface ICustomDayViewDecorator:IDayViewDecorator
	{
		
	}
//	class CustomCalendarPagerView: MonthView 
//	{
//		public CustomCalendarPagerView (IntPtr javaReference,JniHandleOwnership transfer):base(javaReference,transfer)
//		{
//			
//		}
//
//		public CustomCalendarPagerView (MaterialCalendarView p0, CalendarDay p1,int p2):base(p0,p1,p2)
//		{
//
//		}
//
//
//	}
}


