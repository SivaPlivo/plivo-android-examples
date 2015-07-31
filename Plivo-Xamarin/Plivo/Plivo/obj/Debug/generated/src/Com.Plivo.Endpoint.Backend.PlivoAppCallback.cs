using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Plivo.Endpoint.Backend {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']"
	[global::Android.Runtime.Register ("com/plivo/endpoint/backend/PlivoAppCallback", DoNotGenerateAcw=true)]
	public partial class PlivoAppCallback : global::Java.Lang.Object {


		static IntPtr swigCMemOwn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/field[@name='swigCMemOwn']"
		[Register ("swigCMemOwn")]
		protected bool SwigCMemOwn {
			get {
				if (swigCMemOwn_jfieldId == IntPtr.Zero)
					swigCMemOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "swigCMemOwn", "Z");
				return JNIEnv.GetBooleanField (Handle, swigCMemOwn_jfieldId);
			}
			set {
				if (swigCMemOwn_jfieldId == IntPtr.Zero)
					swigCMemOwn_jfieldId = JNIEnv.GetFieldID (class_ref, "swigCMemOwn", "Z");
				try {
					JNIEnv.SetField (Handle, swigCMemOwn_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/plivo/endpoint/backend/PlivoAppCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlivoAppCallback); }
		}

		protected PlivoAppCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/constructor[@name='PlivoAppCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlivoAppCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PlivoAppCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_JZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/constructor[@name='PlivoAppCallback' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe PlivoAppCallback (long p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (PlivoAppCallback)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(JZ)V", __args);
					return;
				}

				if (id_ctor_JZ == IntPtr.Zero)
					id_ctor_JZ = JNIEnv.GetMethodID (class_ref, "<init>", "(JZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_JZ, __args);
			} finally {
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		static IntPtr id_delete;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			if (id_delete == IntPtr.Zero)
				id_delete = JNIEnv.GetMethodID (class_ref, "delete", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_delete);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "()V"));
			} finally {
			}
		}

		static IntPtr id_getCPtr_Lcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("getCPtr", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)J", "")]
		protected static unsafe long GetCPtr (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0)
		{
			if (id_getCPtr_Lcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_getCPtr_Lcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "getCPtr", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getCPtr_Lcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onDebugMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDebugMessage_Ljava_lang_String_Handler ()
		{
			if (cb_onDebugMessage_Ljava_lang_String_ == null)
				cb_onDebugMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDebugMessage_Ljava_lang_String_);
			return cb_onDebugMessage_Ljava_lang_String_;
		}

		static void n_OnDebugMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDebugMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDebugMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onDebugMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDebugMessage", "(Ljava/lang/String;)V", "GetOnDebugMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void OnDebugMessage (string p0)
		{
			if (id_onDebugMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_onDebugMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDebugMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDebugMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDebugMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_OnIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnIncomingCall (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onIncomingCall' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onIncomingCall", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void OnIncomingCall (int p0, string p1, string p2, string p3)
		{
			if (id_onIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onIncomingCall", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onIncomingCall_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIncomingCall", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onIncomingCallHangup_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnIncomingCallHangup_ILjava_lang_String_Handler ()
		{
			if (cb_onIncomingCallHangup_ILjava_lang_String_ == null)
				cb_onIncomingCallHangup_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnIncomingCallHangup_ILjava_lang_String_);
			return cb_onIncomingCallHangup_ILjava_lang_String_;
		}

		static void n_OnIncomingCallHangup_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnIncomingCallHangup (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onIncomingCallHangup_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onIncomingCallHangup' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onIncomingCallHangup", "(ILjava/lang/String;)V", "GetOnIncomingCallHangup_ILjava_lang_String_Handler")]
		public virtual unsafe void OnIncomingCallHangup (int p0, string p1)
		{
			if (id_onIncomingCallHangup_ILjava_lang_String_ == IntPtr.Zero)
				id_onIncomingCallHangup_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onIncomingCallHangup", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onIncomingCallHangup_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIncomingCallHangup", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onIncomingCallRejected_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnIncomingCallRejected_ILjava_lang_String_Handler ()
		{
			if (cb_onIncomingCallRejected_ILjava_lang_String_ == null)
				cb_onIncomingCallRejected_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnIncomingCallRejected_ILjava_lang_String_);
			return cb_onIncomingCallRejected_ILjava_lang_String_;
		}

		static void n_OnIncomingCallRejected_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnIncomingCallRejected (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onIncomingCallRejected_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onIncomingCallRejected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onIncomingCallRejected", "(ILjava/lang/String;)V", "GetOnIncomingCallRejected_ILjava_lang_String_Handler")]
		public virtual unsafe void OnIncomingCallRejected (int p0, string p1)
		{
			if (id_onIncomingCallRejected_ILjava_lang_String_ == IntPtr.Zero)
				id_onIncomingCallRejected_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onIncomingCallRejected", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onIncomingCallRejected_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIncomingCallRejected", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLogin ();
		}
#pragma warning restore 0169

		static IntPtr id_onLogin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onLogin' and count(parameter)=0]"
		[Register ("onLogin", "()V", "GetOnLoginHandler")]
		public virtual unsafe void OnLogin ()
		{
			if (id_onLogin == IntPtr.Zero)
				id_onLogin = JNIEnv.GetMethodID (class_ref, "onLogin", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLogin);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLogin", "()V"));
			} finally {
			}
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
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLoginFailed ();
		}
#pragma warning restore 0169

		static IntPtr id_onLoginFailed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onLoginFailed' and count(parameter)=0]"
		[Register ("onLoginFailed", "()V", "GetOnLoginFailedHandler")]
		public virtual unsafe void OnLoginFailed ()
		{
			if (id_onLoginFailed == IntPtr.Zero)
				id_onLoginFailed = JNIEnv.GetMethodID (class_ref, "onLoginFailed", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLoginFailed);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoginFailed", "()V"));
			} finally {
			}
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
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLogout ();
		}
#pragma warning restore 0169

		static IntPtr id_onLogout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onLogout' and count(parameter)=0]"
		[Register ("onLogout", "()V", "GetOnLogoutHandler")]
		public virtual unsafe void OnLogout ()
		{
			if (id_onLogout == IntPtr.Zero)
				id_onLogout = JNIEnv.GetMethodID (class_ref, "onLogout", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLogout);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLogout", "()V"));
			} finally {
			}
		}

		static Delegate cb_onOutgoingCall_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCall_ILjava_lang_String_Handler ()
		{
			if (cb_onOutgoingCall_ILjava_lang_String_ == null)
				cb_onOutgoingCall_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnOutgoingCall_ILjava_lang_String_);
			return cb_onOutgoingCall_ILjava_lang_String_;
		}

		static void n_OnOutgoingCall_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCall (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onOutgoingCall_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onOutgoingCall' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onOutgoingCall", "(ILjava/lang/String;)V", "GetOnOutgoingCall_ILjava_lang_String_Handler")]
		public virtual unsafe void OnOutgoingCall (int p0, string p1)
		{
			if (id_onOutgoingCall_ILjava_lang_String_ == IntPtr.Zero)
				id_onOutgoingCall_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCall", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onOutgoingCall_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOutgoingCall", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onOutgoingCallAnswered_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCallAnswered_ILjava_lang_String_Handler ()
		{
			if (cb_onOutgoingCallAnswered_ILjava_lang_String_ == null)
				cb_onOutgoingCallAnswered_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnOutgoingCallAnswered_ILjava_lang_String_);
			return cb_onOutgoingCallAnswered_ILjava_lang_String_;
		}

		static void n_OnOutgoingCallAnswered_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCallAnswered (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onOutgoingCallAnswered_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onOutgoingCallAnswered' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onOutgoingCallAnswered", "(ILjava/lang/String;)V", "GetOnOutgoingCallAnswered_ILjava_lang_String_Handler")]
		public virtual unsafe void OnOutgoingCallAnswered (int p0, string p1)
		{
			if (id_onOutgoingCallAnswered_ILjava_lang_String_ == IntPtr.Zero)
				id_onOutgoingCallAnswered_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCallAnswered", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onOutgoingCallAnswered_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOutgoingCallAnswered", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onOutgoingCallHangup_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCallHangup_ILjava_lang_String_Handler ()
		{
			if (cb_onOutgoingCallHangup_ILjava_lang_String_ == null)
				cb_onOutgoingCallHangup_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnOutgoingCallHangup_ILjava_lang_String_);
			return cb_onOutgoingCallHangup_ILjava_lang_String_;
		}

		static void n_OnOutgoingCallHangup_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCallHangup (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onOutgoingCallHangup_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onOutgoingCallHangup' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onOutgoingCallHangup", "(ILjava/lang/String;)V", "GetOnOutgoingCallHangup_ILjava_lang_String_Handler")]
		public virtual unsafe void OnOutgoingCallHangup (int p0, string p1)
		{
			if (id_onOutgoingCallHangup_ILjava_lang_String_ == IntPtr.Zero)
				id_onOutgoingCallHangup_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCallHangup", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onOutgoingCallHangup_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOutgoingCallHangup", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onOutgoingCallInvalid_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCallInvalid_ILjava_lang_String_Handler ()
		{
			if (cb_onOutgoingCallInvalid_ILjava_lang_String_ == null)
				cb_onOutgoingCallInvalid_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnOutgoingCallInvalid_ILjava_lang_String_);
			return cb_onOutgoingCallInvalid_ILjava_lang_String_;
		}

		static void n_OnOutgoingCallInvalid_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCallInvalid (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onOutgoingCallInvalid_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onOutgoingCallInvalid' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onOutgoingCallInvalid", "(ILjava/lang/String;)V", "GetOnOutgoingCallInvalid_ILjava_lang_String_Handler")]
		public virtual unsafe void OnOutgoingCallInvalid (int p0, string p1)
		{
			if (id_onOutgoingCallInvalid_ILjava_lang_String_ == IntPtr.Zero)
				id_onOutgoingCallInvalid_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCallInvalid", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onOutgoingCallInvalid_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOutgoingCallInvalid", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onOutgoingCallRejected_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCallRejected_ILjava_lang_String_Handler ()
		{
			if (cb_onOutgoingCallRejected_ILjava_lang_String_ == null)
				cb_onOutgoingCallRejected_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnOutgoingCallRejected_ILjava_lang_String_);
			return cb_onOutgoingCallRejected_ILjava_lang_String_;
		}

		static void n_OnOutgoingCallRejected_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCallRejected (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onOutgoingCallRejected_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onOutgoingCallRejected' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onOutgoingCallRejected", "(ILjava/lang/String;)V", "GetOnOutgoingCallRejected_ILjava_lang_String_Handler")]
		public virtual unsafe void OnOutgoingCallRejected (int p0, string p1)
		{
			if (id_onOutgoingCallRejected_ILjava_lang_String_ == IntPtr.Zero)
				id_onOutgoingCallRejected_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCallRejected", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onOutgoingCallRejected_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOutgoingCallRejected", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onOutgoingCallRinging_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnOutgoingCallRinging_ILjava_lang_String_Handler ()
		{
			if (cb_onOutgoingCallRinging_ILjava_lang_String_ == null)
				cb_onOutgoingCallRinging_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnOutgoingCallRinging_ILjava_lang_String_);
			return cb_onOutgoingCallRinging_ILjava_lang_String_;
		}

		static void n_OnOutgoingCallRinging_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOutgoingCallRinging (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onOutgoingCallRinging_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onOutgoingCallRinging' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onOutgoingCallRinging", "(ILjava/lang/String;)V", "GetOnOutgoingCallRinging_ILjava_lang_String_Handler")]
		public virtual unsafe void OnOutgoingCallRinging (int p0, string p1)
		{
			if (id_onOutgoingCallRinging_ILjava_lang_String_ == IntPtr.Zero)
				id_onOutgoingCallRinging_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onOutgoingCallRinging", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onOutgoingCallRinging_ILjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOutgoingCallRinging", "(ILjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onStarted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnStarted_Ljava_lang_String_Handler ()
		{
			if (cb_onStarted_Ljava_lang_String_ == null)
				cb_onStarted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStarted_Ljava_lang_String_);
			return cb_onStarted_Ljava_lang_String_;
		}

		static void n_OnStarted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStarted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStarted_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onStarted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onStarted", "(Ljava/lang/String;)V", "GetOnStarted_Ljava_lang_String_Handler")]
		public virtual unsafe void OnStarted (string p0)
		{
			if (id_onStarted_Ljava_lang_String_ == IntPtr.Zero)
				id_onStarted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStarted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStarted_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStarted", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onStopped_I;
#pragma warning disable 0169
		static Delegate GetOnStopped_IHandler ()
		{
			if (cb_onStopped_I == null)
				cb_onStopped_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnStopped_I);
			return cb_onStopped_I;
		}

		static void n_OnStopped_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStopped (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStopped_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='onStopped' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onStopped", "(I)V", "GetOnStopped_IHandler")]
		public virtual unsafe void OnStopped (int p0)
		{
			if (id_onStopped_I == IntPtr.Zero)
				id_onStopped_I = JNIEnv.GetMethodID (class_ref, "onStopped", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onStopped_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStopped", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_swigDirectorDisconnect;
#pragma warning disable 0169
		static Delegate GetSwigDirectorDisconnectHandler ()
		{
			if (cb_swigDirectorDisconnect == null)
				cb_swigDirectorDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigDirectorDisconnect);
			return cb_swigDirectorDisconnect;
		}

		static void n_SwigDirectorDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigDirectorDisconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_swigDirectorDisconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='swigDirectorDisconnect' and count(parameter)=0]"
		[Register ("swigDirectorDisconnect", "()V", "GetSwigDirectorDisconnectHandler")]
		protected virtual unsafe void SwigDirectorDisconnect ()
		{
			if (id_swigDirectorDisconnect == IntPtr.Zero)
				id_swigDirectorDisconnect = JNIEnv.GetMethodID (class_ref, "swigDirectorDisconnect", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_swigDirectorDisconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigDirectorDisconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_swigReleaseOwnership;
#pragma warning disable 0169
		static Delegate GetSwigReleaseOwnershipHandler ()
		{
			if (cb_swigReleaseOwnership == null)
				cb_swigReleaseOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigReleaseOwnership);
			return cb_swigReleaseOwnership;
		}

		static void n_SwigReleaseOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigReleaseOwnership ();
		}
#pragma warning restore 0169

		static IntPtr id_swigReleaseOwnership;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='swigReleaseOwnership' and count(parameter)=0]"
		[Register ("swigReleaseOwnership", "()V", "GetSwigReleaseOwnershipHandler")]
		public virtual unsafe void SwigReleaseOwnership ()
		{
			if (id_swigReleaseOwnership == IntPtr.Zero)
				id_swigReleaseOwnership = JNIEnv.GetMethodID (class_ref, "swigReleaseOwnership", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_swigReleaseOwnership);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigReleaseOwnership", "()V"));
			} finally {
			}
		}

		static Delegate cb_swigTakeOwnership;
#pragma warning disable 0169
		static Delegate GetSwigTakeOwnershipHandler ()
		{
			if (cb_swigTakeOwnership == null)
				cb_swigTakeOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigTakeOwnership);
			return cb_swigTakeOwnership;
		}

		static void n_SwigTakeOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Backend.PlivoAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Backend.PlivoAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigTakeOwnership ();
		}
#pragma warning restore 0169

		static IntPtr id_swigTakeOwnership;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='PlivoAppCallback']/method[@name='swigTakeOwnership' and count(parameter)=0]"
		[Register ("swigTakeOwnership", "()V", "GetSwigTakeOwnershipHandler")]
		public virtual unsafe void SwigTakeOwnership ()
		{
			if (id_swigTakeOwnership == IntPtr.Zero)
				id_swigTakeOwnership = JNIEnv.GetMethodID (class_ref, "swigTakeOwnership", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_swigTakeOwnership);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "swigTakeOwnership", "()V"));
			} finally {
			}
		}

	}
}
