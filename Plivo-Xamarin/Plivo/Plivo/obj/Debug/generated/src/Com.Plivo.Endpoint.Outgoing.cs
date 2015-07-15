using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Plivo.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']"
	[global::Android.Runtime.Register ("com/plivo/endpoint/Outgoing", DoNotGenerateAcw=true)]
	public partial class Outgoing : global::Java.Lang.Object {


		static IntPtr pjsuaCallId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/field[@name='pjsuaCallId']"
		[Register ("pjsuaCallId")]
		protected int PjsuaCallId {
			get {
				if (pjsuaCallId_jfieldId == IntPtr.Zero)
					pjsuaCallId_jfieldId = JNIEnv.GetFieldID (class_ref, "pjsuaCallId", "I");
				return JNIEnv.GetIntField (Handle, pjsuaCallId_jfieldId);
			}
			set {
				if (pjsuaCallId_jfieldId == IntPtr.Zero)
					pjsuaCallId_jfieldId = JNIEnv.GetFieldID (class_ref, "pjsuaCallId", "I");
				try {
					JNIEnv.SetField (Handle, pjsuaCallId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/plivo/endpoint/Outgoing", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Outgoing); }
		}

		protected Outgoing (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_plivo_endpoint_Endpoint_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/constructor[@name='Outgoing' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.Endpoint']]"
		[Register (".ctor", "(Lcom/plivo/endpoint/Endpoint;)V", "")]
		public unsafe Outgoing (global::Com.Plivo.Endpoint.Endpoint p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Outgoing)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/plivo/endpoint/Endpoint;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/plivo/endpoint/Endpoint;)V", __args);
					return;
				}

				if (id_ctor_Lcom_plivo_endpoint_Endpoint_ == IntPtr.Zero)
					id_ctor_Lcom_plivo_endpoint_Endpoint_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/plivo/endpoint/Endpoint;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_plivo_endpoint_Endpoint_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_plivo_endpoint_Endpoint_, __args);
			} finally {
			}
		}

		static Delegate cb_getCallId;
#pragma warning disable 0169
		static Delegate GetGetCallIdHandler ()
		{
			if (cb_getCallId == null)
				cb_getCallId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallId);
			return cb_getCallId;
		}

		static IntPtr n_GetCallId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallId);
		}
#pragma warning restore 0169

		static Delegate cb_setCallId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCallId_Ljava_lang_String_Handler ()
		{
			if (cb_setCallId_Ljava_lang_String_ == null)
				cb_setCallId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallId_Ljava_lang_String_);
			return cb_setCallId_Ljava_lang_String_;
		}

		static void n_SetCallId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CallId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCallId;
		static IntPtr id_setCallId_Ljava_lang_String_;
		public virtual unsafe string CallId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='getCallId' and count(parameter)=0]"
			[Register ("getCallId", "()Ljava/lang/String;", "GetGetCallIdHandler")]
			get {
				if (id_getCallId == IntPtr.Zero)
					id_getCallId = JNIEnv.GetMethodID (class_ref, "getCallId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCallId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='setCallId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCallId", "(Ljava/lang/String;)V", "GetSetCallId_Ljava_lang_String_Handler")]
			set {
				if (id_setCallId_Ljava_lang_String_ == IntPtr.Zero)
					id_setCallId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCallId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setCallId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isActive;
#pragma warning disable 0169
		static Delegate GetIsActiveHandler ()
		{
			if (cb_isActive == null)
				cb_isActive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActive);
			return cb_isActive;
		}

		static bool n_IsActive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActive;
		}
#pragma warning restore 0169

		static IntPtr id_isActive;
		public virtual unsafe bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "GetIsActiveHandler")]
			get {
				if (id_isActive == IntPtr.Zero)
					id_isActive = JNIEnv.GetMethodID (class_ref, "isActive", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isActive);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isActive", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getToContact;
#pragma warning disable 0169
		static Delegate GetGetToContactHandler ()
		{
			if (cb_getToContact == null)
				cb_getToContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToContact);
			return cb_getToContact;
		}

		static IntPtr n_GetToContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToContact);
		}
#pragma warning restore 0169

		static Delegate cb_setToContact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToContact_Ljava_lang_String_Handler ()
		{
			if (cb_setToContact_Ljava_lang_String_ == null)
				cb_setToContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToContact_Ljava_lang_String_);
			return cb_setToContact_Ljava_lang_String_;
		}

		static void n_SetToContact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ToContact = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToContact;
		static IntPtr id_setToContact_Ljava_lang_String_;
		public virtual unsafe string ToContact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='getToContact' and count(parameter)=0]"
			[Register ("getToContact", "()Ljava/lang/String;", "GetGetToContactHandler")]
			get {
				if (id_getToContact == IntPtr.Zero)
					id_getToContact = JNIEnv.GetMethodID (class_ref, "getToContact", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getToContact), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToContact", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='setToContact' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToContact", "(Ljava/lang/String;)V", "GetSetToContact_Ljava_lang_String_Handler")]
			set {
				if (id_setToContact_Ljava_lang_String_ == IntPtr.Zero)
					id_setToContact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToContact", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setToContact_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToContact", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_call_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCall_Ljava_lang_String_Handler ()
		{
			if (cb_call_Ljava_lang_String_ == null)
				cb_call_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Call_Ljava_lang_String_);
			return cb_call_Ljava_lang_String_;
		}

		static bool n_Call_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Call (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_call_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='call' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("call", "(Ljava/lang/String;)Z", "GetCall_Ljava_lang_String_Handler")]
		public virtual unsafe bool Call (string p0)
		{
			if (id_call_Ljava_lang_String_ == IntPtr.Zero)
				id_call_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "call", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_call_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "call", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hangup;
#pragma warning disable 0169
		static Delegate GetHangupHandler ()
		{
			if (cb_hangup == null)
				cb_hangup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Hangup);
			return cb_hangup;
		}

		static void n_Hangup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hangup ();
		}
#pragma warning restore 0169

		static IntPtr id_hangup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='hangup' and count(parameter)=0]"
		[Register ("hangup", "()V", "GetHangupHandler")]
		public virtual unsafe void Hangup ()
		{
			if (id_hangup == IntPtr.Zero)
				id_hangup = JNIEnv.GetMethodID (class_ref, "hangup", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_hangup);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hangup", "()V"));
			} finally {
			}
		}

		static Delegate cb_mute;
#pragma warning disable 0169
		static Delegate GetMuteHandler ()
		{
			if (cb_mute == null)
				cb_mute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Mute);
			return cb_mute;
		}

		static bool n_Mute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mute ();
		}
#pragma warning restore 0169

		static IntPtr id_mute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='mute' and count(parameter)=0]"
		[Register ("mute", "()Z", "GetMuteHandler")]
		public virtual unsafe bool Mute ()
		{
			if (id_mute == IntPtr.Zero)
				id_mute = JNIEnv.GetMethodID (class_ref, "mute", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_mute);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mute", "()Z"));
			} finally {
			}
		}

		static Delegate cb_sendDigits_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendDigits_Ljava_lang_String_Handler ()
		{
			if (cb_sendDigits_Ljava_lang_String_ == null)
				cb_sendDigits_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendDigits_Ljava_lang_String_);
			return cb_sendDigits_Ljava_lang_String_;
		}

		static bool n_SendDigits_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendDigits (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendDigits_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='sendDigits' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendDigits", "(Ljava/lang/String;)Z", "GetSendDigits_Ljava_lang_String_Handler")]
		public virtual unsafe bool SendDigits (string p0)
		{
			if (id_sendDigits_Ljava_lang_String_ == IntPtr.Zero)
				id_sendDigits_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendDigits", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_sendDigits_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendDigits", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unmute;
#pragma warning disable 0169
		static Delegate GetUnmuteHandler ()
		{
			if (cb_unmute == null)
				cb_unmute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Unmute);
			return cb_unmute;
		}

		static bool n_Unmute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Outgoing __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Outgoing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Unmute ();
		}
#pragma warning restore 0169

		static IntPtr id_unmute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Outgoing']/method[@name='unmute' and count(parameter)=0]"
		[Register ("unmute", "()Z", "GetUnmuteHandler")]
		public virtual unsafe bool Unmute ()
		{
			if (id_unmute == IntPtr.Zero)
				id_unmute = JNIEnv.GetMethodID (class_ref, "unmute", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_unmute);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unmute", "()Z"));
			} finally {
			}
		}

	}
}
