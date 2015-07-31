package mono.com.plivo.endpoint;


public class EventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.plivo.endpoint.EventListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onIncomingCall:(Lcom/plivo/endpoint/Incoming;)V:GetOnIncomingCall_Lcom_plivo_endpoint_Incoming_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onIncomingCallHangup:(Lcom/plivo/endpoint/Incoming;)V:GetOnIncomingCallHangup_Lcom_plivo_endpoint_Incoming_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onIncomingCallRejected:(Lcom/plivo/endpoint/Incoming;)V:GetOnIncomingCallRejected_Lcom_plivo_endpoint_Incoming_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onLogin:()V:GetOnLoginHandler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onLoginFailed:()V:GetOnLoginFailedHandler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onLogout:()V:GetOnLogoutHandler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onOutgoingCall:(Lcom/plivo/endpoint/Outgoing;)V:GetOnOutgoingCall_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onOutgoingCallAnswered:(Lcom/plivo/endpoint/Outgoing;)V:GetOnOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onOutgoingCallHangup:(Lcom/plivo/endpoint/Outgoing;)V:GetOnOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onOutgoingCallInvalid:(Lcom/plivo/endpoint/Outgoing;)V:GetOnOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"n_onOutgoingCallRejected:(Lcom/plivo/endpoint/Outgoing;)V:GetOnOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo\n" +
			"";
		mono.android.Runtime.register ("Com.Plivo.Endpoint.IEventListenerImplementor, Plivo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", EventListenerImplementor.class, __md_methods);
	}


	public EventListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == EventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Plivo.Endpoint.IEventListenerImplementor, Plivo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onIncomingCall (com.plivo.endpoint.Incoming p0)
	{
		n_onIncomingCall (p0);
	}

	private native void n_onIncomingCall (com.plivo.endpoint.Incoming p0);


	public void onIncomingCallHangup (com.plivo.endpoint.Incoming p0)
	{
		n_onIncomingCallHangup (p0);
	}

	private native void n_onIncomingCallHangup (com.plivo.endpoint.Incoming p0);


	public void onIncomingCallRejected (com.plivo.endpoint.Incoming p0)
	{
		n_onIncomingCallRejected (p0);
	}

	private native void n_onIncomingCallRejected (com.plivo.endpoint.Incoming p0);


	public void onLogin ()
	{
		n_onLogin ();
	}

	private native void n_onLogin ();


	public void onLoginFailed ()
	{
		n_onLoginFailed ();
	}

	private native void n_onLoginFailed ();


	public void onLogout ()
	{
		n_onLogout ();
	}

	private native void n_onLogout ();


	public void onOutgoingCall (com.plivo.endpoint.Outgoing p0)
	{
		n_onOutgoingCall (p0);
	}

	private native void n_onOutgoingCall (com.plivo.endpoint.Outgoing p0);


	public void onOutgoingCallAnswered (com.plivo.endpoint.Outgoing p0)
	{
		n_onOutgoingCallAnswered (p0);
	}

	private native void n_onOutgoingCallAnswered (com.plivo.endpoint.Outgoing p0);


	public void onOutgoingCallHangup (com.plivo.endpoint.Outgoing p0)
	{
		n_onOutgoingCallHangup (p0);
	}

	private native void n_onOutgoingCallHangup (com.plivo.endpoint.Outgoing p0);


	public void onOutgoingCallInvalid (com.plivo.endpoint.Outgoing p0)
	{
		n_onOutgoingCallInvalid (p0);
	}

	private native void n_onOutgoingCallInvalid (com.plivo.endpoint.Outgoing p0);


	public void onOutgoingCallRejected (com.plivo.endpoint.Outgoing p0)
	{
		n_onOutgoingCallRejected (p0);
	}

	private native void n_onOutgoingCallRejected (com.plivo.endpoint.Outgoing p0);

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
