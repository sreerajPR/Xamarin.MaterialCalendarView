package mono.com.prolificinteractive.materialcalendarview;


public class OnDateSelectedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.prolificinteractive.materialcalendarview.OnDateSelectedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onDateSelected:(Lcom/prolificinteractive/materialcalendarview/MaterialCalendarView;Lcom/prolificinteractive/materialcalendarview/CalendarDay;Z)V:GetOnDateSelected_Lcom_prolificinteractive_materialcalendarview_MaterialCalendarView_Lcom_prolificinteractive_materialcalendarview_CalendarDay_ZHandler:MaterialCalendarLibrary.IOnDateSelectedListenerInvoker, MaterialCalendarLibrary\n" +
			"";
		mono.android.Runtime.register ("MaterialCalendarLibrary.IOnDateSelectedListenerImplementor, MaterialCalendarLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnDateSelectedListenerImplementor.class, __md_methods);
	}


	public OnDateSelectedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnDateSelectedListenerImplementor.class)
			mono.android.TypeManager.Activate ("MaterialCalendarLibrary.IOnDateSelectedListenerImplementor, MaterialCalendarLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDateSelected (com.prolificinteractive.materialcalendarview.MaterialCalendarView p0, com.prolificinteractive.materialcalendarview.CalendarDay p1, boolean p2)
	{
		n_onDateSelected (p0, p1, p2);
	}

	private native void n_onDateSelected (com.prolificinteractive.materialcalendarview.MaterialCalendarView p0, com.prolificinteractive.materialcalendarview.CalendarDay p1, boolean p2);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
