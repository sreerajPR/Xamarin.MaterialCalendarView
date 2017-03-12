using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.Content.Res;
using Android.Support.V7.App;
using Android.Text.Style;
using Com.Prolificinteractive.Materialcalendarview.Spans;
using Java.Util;
using MaterialCalendarLibrary;

namespace MaterialCalendarSample
{
    [Activity(Label = "MaterialCalendarSample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity, IOnDateSelectedListener
    {
        readonly OneDayDecorator _oneDayDecorator = new OneDayDecorator();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            var materialCalendar = FindViewById<MaterialCalendarView>(Resource.Id.calendarView);
            materialCalendar.ShowOtherDates = MaterialCalendarView.ShowAll;
            materialCalendar.SelectionMode = MaterialCalendarView.SelectionModeSingle;

            Calendar instance = Calendar.Instance;
            materialCalendar.SetSelectedDate(instance.Time);

            Calendar instance1 = Calendar.Instance;
            instance1.Set(instance1.Get(CalendarField.Year), Calendar.January, 1);

            Calendar instance2 = Calendar.Instance;
            instance2.Set(instance2.Get(CalendarField.Year), Calendar.December, 31);

            materialCalendar.CurrentState().Edit()
                .SetFirstDayOfWeek(Java.Util.Calendar.Monday)
                .SetMinimumDate(instance1.Time)
                .SetMaximumDate(instance2.Time)
                .Commit();

            materialCalendar.AddDecorators(
                new MySelectorDecorator(this),
                new CalendarDayViewDecorator(),
                new HiglightWeekendsDecorator(),
                _oneDayDecorator);
        }

        public void OnDateSelected(MaterialCalendarView widget, CalendarDay date, bool selected)
        {
            _oneDayDecorator.Date = CalendarDay.From(date.Date);
            widget.InvalidateDecorators();
        }
    }

    class MySelectorDecorator : Java.Lang.Object, IDayViewDecorator
    {
        readonly Drawable _drawable;

        public MySelectorDecorator(Context context)
        {
            _drawable = ResourcesCompat.GetDrawable(context.Resources, Resource.Drawable.my_selector, null);
        }

        public bool ShouldDecorate(CalendarDay day)
        {
            return true;
        }

        public void Decorate(DayViewFacade view)
        {
            view.SetSelectionDrawable(_drawable);
        }
    }
    class CalendarDayViewDecorator : Java.Lang.Object, IDayViewDecorator
    {
        public bool ShouldDecorate(CalendarDay day)
        {
            if (day.Day == 5 || day.Day == 14 || day.Day == 25)
                return true;
            else
                return false;
        }

        public void Decorate(DayViewFacade view)
        {
            view.AddSpan(new DotSpan(5, Color.Red));
        }
    }
    class HiglightWeekendsDecorator : Java.Lang.Object, IDayViewDecorator
    {
        readonly Calendar _calendar = Calendar.Instance;
        readonly Drawable _highlightDrawable;

        public HiglightWeekendsDecorator()
        {
            _highlightDrawable = new ColorDrawable(Color.ParseColor("#228BC24A"));
        }

        public bool ShouldDecorate(CalendarDay day)
        {
            day.CopyTo(_calendar);
            var weekDay = _calendar.Get(CalendarField.DayOfWeek);
            return weekDay == Calendar.Saturday || weekDay == Calendar.Sunday;
        }

        public void Decorate(DayViewFacade view)
        {
            view.SetBackgroundDrawable(_highlightDrawable);
        }
    }
    class OneDayDecorator : Java.Lang.Object, IDayViewDecorator
    {
        public CalendarDay Date { get; set; }

        public bool ShouldDecorate(CalendarDay date)
        {
            return Date != null && Date.Equals(date);
        }

        public void Decorate(DayViewFacade view)
        {
            view.AddSpan(new StyleSpan(TypefaceStyle.Bold));
            view.AddSpan(new RelativeSizeSpan(1.4f));
        }
    }
}


