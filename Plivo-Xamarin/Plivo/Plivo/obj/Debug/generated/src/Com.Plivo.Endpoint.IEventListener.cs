using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Plivo.Endpoint {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']"
	[Register ("com/plivo/endpoint/EventListener", "", "Com.Plivo.Endpoint.IEventListenerInvoker")]
	public partial interface IEventListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onIncomingCall' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.Incoming']]"
		[Register ("onIncomingCall", "(Lcom/plivo/endpoint/Incoming;)V", "GetOnIncomingCall_Lcom_plivo_endpoint_Incoming_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnIncomingCall (global::Com.Plivo.Endpoint.Incoming p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onIncomingCallHangup' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.Incoming']]"
		[Register ("onIncomingCallHangup", "(Lcom/plivo/endpoint/Incoming;)V", "GetOnIncomingCallHangup_Lcom_plivo_endpoint_Incoming_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnIncomingCallHangup (global::Com.Plivo.Endpoint.Incoming p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onIncomingCallRejected' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.Incoming']]"
		[Register ("onIncomingCallRejected", "(Lcom/plivo/endpoint/Incoming;)V", "GetOnIncomingCallRejected_Lcom_plivo_endpoint_Incoming_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnIncomingCallRejected (global::Com.Plivo.Endpoint.Incoming p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onLogin' and count(parameter)=0]"
		[Register ("onLogin", "()V", "GetOnLoginHandler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnLogin ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onLoginFailed' and count(parameter)=0]"
		[Register ("onLoginFailed", "()V", "GetOnLoginFailedHandler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnLoginFailed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onLogout' and count(parameter)=0]"
		[Register ("onLogout", "()V", "GetOnLogoutHandler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnLogout ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onOutgoingCall' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.Outgoing']]"
		[Register ("onOutgoingCall", "(Lcom/plivo/endpoint/Outgoing;)V", "GetOnOutgoingCall_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnOutgoingCall (global::Com.Plivo.Endpoint.Outgoing p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onOutgoingCallAnswered' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.Outgoing']]"
		[Register ("onOutgoingCallAnswered", "(Lcom/plivo/endpoint/Outgoing;)V", "GetOnOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnOutgoingCallAnswered (global::Com.Plivo.Endpoint.Outgoing p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onOutgoingCallHangup' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.Outgoing']]"
		[Register ("onOutgoingCallHangup", "(Lcom/plivo/endpoint/Outgoing;)V", "GetOnOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnOutgoingCallHangup (global::Com.Plivo.Endpoint.Outgoing p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onOutgoingCallInvalid' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.Outgoing']]"
		[Register ("onOutgoingCallInvalid", "(Lcom/plivo/endpoint/Outgoing;)V", "GetOnOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnOutgoingCallInvalid (global::Com.Plivo.Endpoint.Outgoing p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/interface[@name='EventListener']/method[@name='onOutgoingCallRejected' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.Outgoing']]"
		[Register ("onOutgoingCallRejected", "(Lcom/plivo/endpoint/Outgoing;)V", "GetOnOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_Handler:Com.Plivo.Endpoint.IEventListenerInvoker, Plivo")]
		void OnOutgoingCallRejected (global::Com.Plivo.Endpoint.Outgoing p0);

	}

	[global::Android.Runtime.Register ("com/plivo/endpoint/EventListener", DoNotGenerateAcw=true)]
	internal class IEventListenerInvoker : global::Java.Lang.Object, IEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/plivo/endpoint/EventListener");
		IntPtr class_ref;

		public static IEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.plivo.endpoint.EventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEventListenerInvoker); }
		}

		static Delegate cb_onIncomingCall_Lcom_plivo_endpoint_Incoming_;
#pragma warning disable 0169
		static Delegate GetOnIncomingCall_Lcom_plivo_endpoint_Incoming_Handler ()
		{
			if (cb_onIncomingCall_Lcom_plivo_endpoint_Incoming_ == null)
				cb_onIncomingCall_Lcom_plivo_endpoint_Incoming_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIncomingCall_Lcom_plivo_endpoint_Incoming_);
			return cb_onIncomingCall_Lcom_plivo_endpoint_Incoming_;
		}

		static void n_OnIncomingCall_Lcom_plivo_endpoint_Incoming_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Plivo.Endpoint.Incoming p0 = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnIncomingCall (p0);
		}
#pragma warning restore 0169

		IntPtr id_onIncomingCall_Lcom_plivo_endpoint_Incoming_;
		public unsafe void OnIncomingCall (global::Com.Plivo.Endpoint.Incoming p0)
		{
			if (id_onIncomingCall_Lcom_plivo_endpoint_Incoming_ == IntPtr.Zero)
				id_onIncomingCall_Lcom_plivo_endpoint_Incoming_ = JNIEnv.GetMethodID (class_ref, "onIncomingCall", "(Lcom/plivo/endpoint/Incoming;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onIncomingCall_Lcom_plivo_endpoint_Incoming_, __args);
		}

		static Delegate cb_onIncomingCallHangup_Lcom_plivo_endpoint_Incoming_;
#pragma warning disable 0169
		static Delegate GetOnIncomingCallHangup_Lcom_plivo_endpoint_Incoming_Handler ()
		{
			if (cb_onIncomingCallHangup_Lcom_plivo_endpoint_Incoming_ == null)
				cb_onIncomingCallHangup_Lcom_plivo_endpoint_Incoming_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIncomingCallHangup_Lcom_plivo_endpoint_Incoming_);
			return cb_onIncomingCallHangup_Lcom_plivo_endpoint_Incoming_;
		}

		static void n_OnIncomingCallHangup_Lcom_plivo_endpoint_Incoming_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Plivo.Endpoint.Incoming p0 = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnIncomingCallHangup (p0);
		}
#pragma warning restore 0169

		IntPtr id_onIncomingCallHangup_Lcom_plivo_endpoint_Incoming_;
		public unsafe void OnIncomingCallHangup (global::Com.Plivo.Endpoint.Incoming p0)
		{
			if (id_onIncomingCallHangup_Lcom_plivo_endpoint_Incoming_ == IntPtr.Zero)
				id_onIncomingCallHangup_Lcom_plivo_endpoint_Incoming_ = JNIEnv.GetMethodID (class_ref, "onIncomingCallHangup", "(Lcom/plivo/endpoint/Incoming;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onIncomingCallHangup_Lcom_plivo_endpoint_Incoming_, __args);
		}

		static Delegate cb_onIncomingCallRejected_Lcom_plivo_endpoint_Incoming_;
#pragma warning disable 0169
		static Delegate GetOnIncomingCallRejected_Lcom_plivo_endpoint_Incoming_Handler ()
		{
			if (cb_onIncomingCallRejected_Lcom_plivo_endpoint_Incoming_ == null)
				cb_onIncomingCallRejected_Lcom_plivo_endpoint_Incoming_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIncomingCallRejected_Lcom_plivo_endpoint_Incoming_);
			return cb_onIncomingCallRejected_Lcom_plivo_endpoint_Incoming_;
		}

		static void n_OnIncomingCallRejected_Lcom_plivo_endpoint_Incoming_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Plivo.Endpoint.Incoming p0 = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnIncomingCallRejected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onIncomingCallRejected_Lcom_plivo_endpoint_Incoming_;
		public unsafe void OnIncomingCallRejected (global::Com.Plivo.Endpoint.Incoming p0)
		{
			if (id_onIncomingCallRejected_Lcom_plivo_endpoint_Incoming_ == IntPtr.Zero)
				id_onIncomingCallRejected_Lcom_plivo_endpoint_Incoming_ = JNIEnv.GetMethodID (class_ref, "onIncomingCallRejected", "(Lcom/plivo/endpoint/Incoming;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onIncomingCallRejected_Lcom_plivo_endpoint_Incoming_, __args);
		}

		static Delegate cb_onLogin;
#pragma warning disable 0169
		static Delegate GetOnLoginHandler ()
		{
			if (cb_onLogin == null)
				cb_onLogin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLogin);
			return cb_onLogin;
		}

		static void n_OnLogin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLogin ();
		}
#pragma warning restore 0169

		IntPtr id_onLogin;
		public unsafe void OnLogin ()
		{
			if (id_onLogin == IntPtr.Zero)
				id_onLogin = JNIEnv.GetMethodID (class_ref, "onLogin", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onLogin);
		}

		static Delegate cb_onLoginFailed;
#pragma warning disable 0169
		static Delegate GetOnLoginFailedHandler ()
		{
			if (cb_onLoginFailed == null)
				cb_onLoginFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLoginFailed);
			return cb_onLoginFailed;
		}

		static void n_OnLoginFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLoginFailed ();
		}
#pragma warning restore 0169

		IntPtr id_onLoginFailed;
		public unsafe void OnLoginFailed ()
		{
			if (id_onLoginFailed == IntPtr.Zero)
				id_onLoginFailed = JNIEnv.GetMethodID (class_ref, "onLoginFailed", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onLoginFailed);
		}

		static Delegate cb_onLogout;
#pragma warning disable 0169
		static Delegate GetOnLogoutHandler ()
		{
			if (cb_onLogout == null)
				cb_onLogout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLogout);
			return cb_onLogout;
		}

		static void n_OnLogout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLogout ();
		}
#pragma warning restore 0169

		IntPtr id_onLogout;
		public unsafe void OnLogout ()
		{
			if (id_onLogout == IntPtr.Zero)
				id_onLogout = JNIEnv.GetMethodID (class_ref, "onLogout", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onLogout);
		}

		static Delegate cb_onOutgoingCall_Lcom_plivo_endpoint_Outgoing_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCall_Lcom_plivo_endpoint_Outgoing_Handler ()
		{
			if (cb_onOutgoingCall_Lcom_plivo_endpoint_Outgoing_ == null)
				cb_onOutgoingCall_Lcom_plivo_endpoint_Outgoing_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOutgoingCall_Lcom_plivo_endpoint_Outgoing_);
			return cb_onOutgoingCall_Lcom_plivo_endpoint_Outgoing_;
		}

		static void n_OnOutgoingCall_Lcom_plivo_endpoint_Outgoing_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Plivo.Endpoint.Outgoing p0 = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCall (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOutgoingCall_Lcom_plivo_endpoint_Outgoing_;
		public unsafe void OnOutgoingCall (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			if (id_onOutgoingCall_Lcom_plivo_endpoint_Outgoing_ == IntPtr.Zero)
				id_onOutgoingCall_Lcom_plivo_endpoint_Outgoing_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCall", "(Lcom/plivo/endpoint/Outgoing;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onOutgoingCall_Lcom_plivo_endpoint_Outgoing_, __args);
		}

		static Delegate cb_onOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_Handler ()
		{
			if (cb_onOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_ == null)
				cb_onOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_);
			return cb_onOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_;
		}

		static void n_OnOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Plivo.Endpoint.Outgoing p0 = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCallAnswered (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_;
		public unsafe void OnOutgoingCallAnswered (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			if (id_onOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_ == IntPtr.Zero)
				id_onOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCallAnswered", "(Lcom/plivo/endpoint/Outgoing;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onOutgoingCallAnswered_Lcom_plivo_endpoint_Outgoing_, __args);
		}

		static Delegate cb_onOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_Handler ()
		{
			if (cb_onOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_ == null)
				cb_onOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_);
			return cb_onOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_;
		}

		static void n_OnOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Plivo.Endpoint.Outgoing p0 = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCallHangup (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_;
		public unsafe void OnOutgoingCallHangup (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			if (id_onOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_ == IntPtr.Zero)
				id_onOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCallHangup", "(Lcom/plivo/endpoint/Outgoing;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onOutgoingCallHangup_Lcom_plivo_endpoint_Outgoing_, __args);
		}

		static Delegate cb_onOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_Handler ()
		{
			if (cb_onOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_ == null)
				cb_onOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_);
			return cb_onOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_;
		}

		static void n_OnOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Plivo.Endpoint.Outgoing p0 = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCallInvalid (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_;
		public unsafe void OnOutgoingCallInvalid (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			if (id_onOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_ == IntPtr.Zero)
				id_onOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCallInvalid", "(Lcom/plivo/endpoint/Outgoing;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onOutgoingCallInvalid_Lcom_plivo_endpoint_Outgoing_, __args);
		}

		static Delegate cb_onOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_Handler ()
		{
			if (cb_onOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_ == null)
				cb_onOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_);
			return cb_onOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_;
		}

		static void n_OnOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Plivo.Endpoint.Outgoing p0 = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCallRejected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_;
		public unsafe void OnOutgoingCallRejected (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			if (id_onOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_ == IntPtr.Zero)
				id_onOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCallRejected", "(Lcom/plivo/endpoint/Outgoing;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onOutgoingCallRejected_Lcom_plivo_endpoint_Outgoing_, __args);
		}

	}

	public partial class IncomingCallEventArgs : global::System.EventArgs {

		public IncomingCallEventArgs (global::Com.Plivo.Endpoint.Incoming p0)
		{
			this.p0 = p0;
		}

		global::Com.Plivo.Endpoint.Incoming p0;
		public global::Com.Plivo.Endpoint.Incoming P0 {
			get { return p0; }
		}
	}

	public partial class IncomingCallHangupEventArgs : global::System.EventArgs {

		public IncomingCallHangupEventArgs (global::Com.Plivo.Endpoint.Incoming p0)
		{
			this.p0 = p0;
		}

		global::Com.Plivo.Endpoint.Incoming p0;
		public global::Com.Plivo.Endpoint.Incoming P0 {
			get { return p0; }
		}
	}

	public partial class IncomingCallRejectedEventArgs : global::System.EventArgs {

		public IncomingCallRejectedEventArgs (global::Com.Plivo.Endpoint.Incoming p0)
		{
			this.p0 = p0;
		}

		global::Com.Plivo.Endpoint.Incoming p0;
		public global::Com.Plivo.Endpoint.Incoming P0 {
			get { return p0; }
		}
	}

	public partial class OutgoingCallEventArgs : global::System.EventArgs {

		public OutgoingCallEventArgs (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			this.p0 = p0;
		}

		global::Com.Plivo.Endpoint.Outgoing p0;
		public global::Com.Plivo.Endpoint.Outgoing P0 {
			get { return p0; }
		}
	}

	public partial class OutgoingCallAnsweredEventArgs : global::System.EventArgs {

		public OutgoingCallAnsweredEventArgs (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			this.p0 = p0;
		}

		global::Com.Plivo.Endpoint.Outgoing p0;
		public global::Com.Plivo.Endpoint.Outgoing P0 {
			get { return p0; }
		}
	}

	public partial class OutgoingCallHangupEventArgs : global::System.EventArgs {

		public OutgoingCallHangupEventArgs (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			this.p0 = p0;
		}

		global::Com.Plivo.Endpoint.Outgoing p0;
		public global::Com.Plivo.Endpoint.Outgoing P0 {
			get { return p0; }
		}
	}

	public partial class OutgoingCallInvalidEventArgs : global::System.EventArgs {

		public OutgoingCallInvalidEventArgs (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			this.p0 = p0;
		}

		global::Com.Plivo.Endpoint.Outgoing p0;
		public global::Com.Plivo.Endpoint.Outgoing P0 {
			get { return p0; }
		}
	}

	public partial class OutgoingCallRejectedEventArgs : global::System.EventArgs {

		public OutgoingCallRejectedEventArgs (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			this.p0 = p0;
		}

		global::Com.Plivo.Endpoint.Outgoing p0;
		public global::Com.Plivo.Endpoint.Outgoing P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/plivo/endpoint/EventListenerImplementor")]
	internal sealed partial class IEventListenerImplementor : global::Java.Lang.Object, IEventListener {

		object sender;

		public IEventListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/plivo/endpoint/EventListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<IncomingCallEventArgs> OnIncomingCallHandler;
#pragma warning restore 0649

		public void OnIncomingCall (global::Com.Plivo.Endpoint.Incoming p0)
		{
			var __h = OnIncomingCallHandler;
			if (__h != null)
				__h (sender, new IncomingCallEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<IncomingCallHangupEventArgs> OnIncomingCallHangupHandler;
#pragma warning restore 0649

		public void OnIncomingCallHangup (global::Com.Plivo.Endpoint.Incoming p0)
		{
			var __h = OnIncomingCallHangupHandler;
			if (__h != null)
				__h (sender, new IncomingCallHangupEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<IncomingCallRejectedEventArgs> OnIncomingCallRejectedHandler;
#pragma warning restore 0649

		public void OnIncomingCallRejected (global::Com.Plivo.Endpoint.Incoming p0)
		{
			var __h = OnIncomingCallRejectedHandler;
			if (__h != null)
				__h (sender, new IncomingCallRejectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnLoginHandler;
#pragma warning restore 0649

		public void OnLogin ()
		{
			var __h = OnLoginHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnLoginFailedHandler;
#pragma warning restore 0649

		public void OnLoginFailed ()
		{
			var __h = OnLoginFailedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnLogoutHandler;
#pragma warning restore 0649

		public void OnLogout ()
		{
			var __h = OnLogoutHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<OutgoingCallEventArgs> OnOutgoingCallHandler;
#pragma warning restore 0649

		public void OnOutgoingCall (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			var __h = OnOutgoingCallHandler;
			if (__h != null)
				__h (sender, new OutgoingCallEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<OutgoingCallAnsweredEventArgs> OnOutgoingCallAnsweredHandler;
#pragma warning restore 0649

		public void OnOutgoingCallAnswered (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			var __h = OnOutgoingCallAnsweredHandler;
			if (__h != null)
				__h (sender, new OutgoingCallAnsweredEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<OutgoingCallHangupEventArgs> OnOutgoingCallHangupHandler;
#pragma warning restore 0649

		public void OnOutgoingCallHangup (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			var __h = OnOutgoingCallHangupHandler;
			if (__h != null)
				__h (sender, new OutgoingCallHangupEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<OutgoingCallInvalidEventArgs> OnOutgoingCallInvalidHandler;
#pragma warning restore 0649

		public void OnOutgoingCallInvalid (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			var __h = OnOutgoingCallInvalidHandler;
			if (__h != null)
				__h (sender, new OutgoingCallInvalidEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<OutgoingCallRejectedEventArgs> OnOutgoingCallRejectedHandler;
#pragma warning restore 0649

		public void OnOutgoingCallRejected (global::Com.Plivo.Endpoint.Outgoing p0)
		{
			var __h = OnOutgoingCallRejectedHandler;
			if (__h != null)
				__h (sender, new OutgoingCallRejectedEventArgs (p0));
		}

		internal static bool __IsEmpty (IEventListenerImplementor value)
		{
			return value.OnIncomingCallHandler == null && value.OnIncomingCallHangupHandler == null && value.OnIncomingCallRejectedHandler == null && value.OnLoginHandler == null && value.OnLoginFailedHandler == null && value.OnLogoutHandler == null && value.OnOutgoingCallHandler == null && value.OnOutgoingCallAnsweredHandler == null && value.OnOutgoingCallHangupHandler == null && value.OnOutgoingCallInvalidHandler == null && value.OnOutgoingCallRejectedHandler == null;
		}
	}

}
