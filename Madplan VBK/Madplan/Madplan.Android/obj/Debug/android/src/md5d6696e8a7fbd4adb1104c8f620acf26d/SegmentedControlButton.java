package md5d6696e8a7fbd4adb1104c8f620acf26d;


public class SegmentedControlButton
	extends android.widget.RadioButton
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDraw:(Landroid/graphics/Canvas;)V:GetOnDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("Messier16.Forms.Android.Controls.Native.SegmentedControl.SegmentedControlButton, Messier16.Forms.Android.Controls, Version=85.0.0.0, Culture=neutral, PublicKeyToken=null", SegmentedControlButton.class, __md_methods);
	}


	public SegmentedControlButton (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == SegmentedControlButton.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.Native.SegmentedControl.SegmentedControlButton, Messier16.Forms.Android.Controls, Version=85.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public SegmentedControlButton (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == SegmentedControlButton.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.Native.SegmentedControl.SegmentedControlButton, Messier16.Forms.Android.Controls, Version=85.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public SegmentedControlButton (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == SegmentedControlButton.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.Native.SegmentedControl.SegmentedControlButton, Messier16.Forms.Android.Controls, Version=85.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public SegmentedControlButton (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3) throws java.lang.Throwable
	{
		super (p0, p1, p2, p3);
		if (getClass () == SegmentedControlButton.class)
			mono.android.TypeManager.Activate ("Messier16.Forms.Android.Controls.Native.SegmentedControl.SegmentedControlButton, Messier16.Forms.Android.Controls, Version=85.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void onDraw (android.graphics.Canvas p0)
	{
		n_onDraw (p0);
	}

	private native void n_onDraw (android.graphics.Canvas p0);

	private java.util.ArrayList refList;
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
