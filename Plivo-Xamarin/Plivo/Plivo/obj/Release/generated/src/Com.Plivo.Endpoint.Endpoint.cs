using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Plivo.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Endpoint']"
	[global::Android.Runtime.Register ("com/plivo/endpoint/Endpoint", DoNotGenerateAcw=true)]
	public partial class Endpoint : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/plivo/endpoint/Endpoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Endpoint); }
		}

		protected Endpoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getOutgoing;
#pragma warning disable 0169
		static Delegate GetGetOutgoingHandler ()
		{
			if (cb_getOutgoing == null)
				cb_getOutgoing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutgoing);
			return cb_getOutgoing;
		}

		static IntPtr n_GetOutgoing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Endpoint __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Outgoing);
		}
#pragma warning restore 0169

		static IntPtr id_getOutgoing;
		protected virtual unsafe global::Com.Plivo.Endpoint.Outgoing Outgoing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Endpoint']/method[@name='getOutgoing' and count(parameter)=0]"
			[Register ("getOutgoing", "()Lcom/plivo/endpoint/Outgoing;", "GetGetOutgoingHandler")]
			get {
				if (id_getOutgoing == IntPtr.Zero)
					id_getOutgoing = JNIEnv.GetMethodID (class_ref, "getOutgoing", "()Lcom/plivo/endpoint/Outgoing;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (JNIEnv.CallObjectMethod  (Handle, id_getOutgoing), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutgoing", "()Lcom/plivo/endpoint/Outgoing;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRegistered;
#pragma warning disable 0169
		static Delegate GetGetRegisteredHandler ()
		{
			if (cb_getRegistered == null)
				cb_getRegistered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRegistered);
			return cb_getRegistered;
		}

		static bool n_GetRegistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Endpoint __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Registered;
		}
#pragma warning restore 0169

		static Delegate cb_setRegistered_Z;
#pragma warning disable 0169
		static Delegate GetSetRegistered_ZHandler ()
		{
			if (cb_setRegistered_Z == null)
				cb_setRegistered_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRegistered_Z);
			return cb_setRegistered_Z;
		}

		static void n_SetRegistered_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Plivo.Endpoint.Endpoint __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Registered = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegistered;
		static IntPtr id_setRegistered_Z;
		protected virtual unsafe bool Registered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Endpoint']/method[@name='getRegistered' and count(parameter)=0]"
			[Register ("getRegistered", "()Z", "GetGetRegisteredHandler")]
			get {
				if (id_getRegistered == IntPtr.Zero)
					id_getRegistered = JNIEnv.GetMethodID (class_ref, "getRegistered", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_getRegistered);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegistered", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Endpoint']/method[@name='setRegistered' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRegistered", "(Z)V", "GetSetRegistered_ZHandler")]
			set {
				if (id_setRegistered_Z == IntPtr.Zero)
					id_setRegistered_Z = JNIEnv.GetMethodID (class_ref, "setRegistered", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRegistered_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegistered", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkDtmfDigit_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckDtmfDigit_Ljava_lang_String_Handler ()
		{
			if (cb_checkDtmfDigit_Ljava_lang_String_ == null)
				cb_checkDtmfDigit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CheckDtmfDigit_Ljava_lang_String_);
			return cb_checkDtmfDigit_Ljava_lang_String_;
		}

		static bool n_CheckDtmfDigit_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.Endpoint __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckDtmfDigit (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_checkDtmfDigit_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Endpoint']/method[@name='checkDtmfDigit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkDtmfDigit", "(Ljava/lang/String;)Z", "GetCheckDtmfDigit_Ljava_lang_String_Handler")]
		public virtual unsafe bool CheckDtmfDigit (string p0)
		{
			if (id_checkDtmfDigit_Ljava_lang_String_ == IntPtr.Zero)
				id_checkDtmfDigit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkDtmfDigit", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_checkDtmfDigit_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkDtmfDigit", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createOutgoingCall;
#pragma warning disable 0169
		static Delegate GetCreateOutgoingCallHandler ()
		{
			if (cb_createOutgoingCall == null)
				cb_createOutgoingCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateOutgoingCall);
			return cb_createOutgoingCall;
		}

		static IntPtr n_CreateOutgoingCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Endpoint __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateOutgoingCall ());
		}
#pragma warning restore 0169

		static IntPtr id_createOutgoingCall;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Endpoint']/method[@name='createOutgoingCall' and count(parameter)=0]"
		[Register ("createOutgoingCall", "()Lcom/plivo/endpoint/Outgoing;", "GetCreateOutgoingCallHandler")]
		public virtual unsafe global::Com.Plivo.Endpoint.Outgoing CreateOutgoingCall ()
		{
			if (id_createOutgoingCall == IntPtr.Zero)
				id_createOutgoingCall = JNIEnv.GetMethodID (class_ref, "createOutgoingCall", "()Lcom/plivo/endpoint/Outgoing;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (JNIEnv.CallObjectMethod  (Handle, id_createOutgoingCall), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createOutgoingCall", "()Lcom/plivo/endpoint/Outgoing;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_login_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogin_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_login_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_login_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Login_Ljava_lang_String_Ljava_lang_String_);
			return cb_login_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Login_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Plivo.Endpoint.Endpoint __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Login (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_login_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Endpoint']/method[@name='login' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("login", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetLogin_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool Login (string p0, string p1)
		{
			if (id_login_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_login_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "login", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_login_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "login", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_logout;
#pragma warning disable 0169
		static Delegate GetLogoutHandler ()
		{
			if (cb_logout == null)
				cb_logout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Logout);
			return cb_logout;
		}

		static bool n_Logout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Endpoint __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Logout ();
		}
#pragma warning restore 0169

		static IntPtr id_logout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Endpoint']/method[@name='logout' and count(parameter)=0]"
		[Register ("logout", "()Z", "GetLogoutHandler")]
		public virtual unsafe bool Logout ()
		{
			if (id_logout == IntPtr.Zero)
				id_logout = JNIEnv.GetMethodID (class_ref, "logout", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_logout);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "()Z"));
			} finally {
			}
		}

		static IntPtr id_newInstance_ZLcom_plivo_endpoint_EventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Endpoint']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.plivo.endpoint.EventListener']]"
		[Register ("newInstance", "(ZLcom/plivo/endpoint/EventListener;)Lcom/plivo/endpoint/Endpoint;", "")]
		public static unsafe global::Com.Plivo.Endpoint.Endpoint NewInstance (bool p0, global::Com.Plivo.Endpoint.IEventListener p1)
		{
			if (id_newInstance_ZLcom_plivo_endpoint_EventListener_ == IntPtr.Zero)
				id_newInstance_ZLcom_plivo_endpoint_EventListener_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(ZLcom/plivo/endpoint/EventListener;)Lcom/plivo/endpoint/Endpoint;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Plivo.Endpoint.Endpoint __ret = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Endpoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_ZLcom_plivo_endpoint_EventListener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
