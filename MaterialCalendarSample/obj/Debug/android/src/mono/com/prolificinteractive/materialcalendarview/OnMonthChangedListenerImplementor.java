package mono.com.prolificinteractive.materialcalendarview;


public class OnMonthChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.prolificinteractive.materialcalendarview.OnMonthChangedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMonthChanged:(Lcom/prolificinteractive/materialcalendarview/MaterialCalendarView;Lcom/prolificinteractive/materialcalendarview/CalendarDay;)V:GetOnMonthChanged_Lcom_prolificinteractive_materialcalendarview_MaterialCalendarView_Lcom_prolificinteractive_materialcalendarview_CalendarDay_Handler:MaterialCalendarLibrary.IOnMonthChangedListenerInvoker, MaterialCalendarLibrary\n" +
			"";
		mono.android.Runtime.register ("MaterialCalendarLibrary.IOnMonthChangedListenerImplementor, MaterialCalendarLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnMonthChangedListenerImplementor.class, __md_methods);
	}


	public OnMonthChangedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnMonthChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("MaterialCalendarLibrary.IOnMonthChangedListenerImplementor, MaterialCalendarLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMonthChanged (com.prolificinteractive.materialcalendarview.MaterialCalendarView p0, com.prolificinteractive.materialcalendarview.CalendarDay p1)
	{
		n_onMonthChanged (p0, p1);
	}

	private native void n_onMonthChanged (com.prolificinteractive.materialcalendarview.MaterialCalendarView p0, com.prolificinteractive.materialcalendarview.CalendarDay p1);

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
