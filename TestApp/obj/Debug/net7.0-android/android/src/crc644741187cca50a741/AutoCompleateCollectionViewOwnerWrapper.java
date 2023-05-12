package crc644741187cca50a741;


public class AutoCompleateCollectionViewOwnerWrapper
	extends crc644741187cca50a741.SingleSelectionCollectionViewOwnerWrapper_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DevExpress.Maui.Editors.Android.Internal.AutoCompleateCollectionViewOwnerWrapper, DevExpress.Maui.Editors", AutoCompleateCollectionViewOwnerWrapper.class, __md_methods);
	}


	public AutoCompleateCollectionViewOwnerWrapper ()
	{
		super ();
		if (getClass () == AutoCompleateCollectionViewOwnerWrapper.class) {
			mono.android.TypeManager.Activate ("DevExpress.Maui.Editors.Android.Internal.AutoCompleateCollectionViewOwnerWrapper, DevExpress.Maui.Editors", "", this, new java.lang.Object[] {  });
		}
	}

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
