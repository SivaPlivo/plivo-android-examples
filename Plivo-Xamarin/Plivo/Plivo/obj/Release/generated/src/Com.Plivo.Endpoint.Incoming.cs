using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Plivo.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']"
	[global::Android.Runtime.Register ("com/plivo/endpoint/Incoming", DoNotGenerateAcw=true)]
	public partial class Incoming : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/plivo/endpoint/Incoming", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Incoming); }
		}

		protected Incoming (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/constructor[@name='Incoming' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Incoming (int p0, string p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (Incoming)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CallId);
		}
#pragma warning restore 0169

		static IntPtr id_getCallId;
		public virtual unsafe string CallId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='getCallId' and count(parameter)=0]"
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
		}

		static Delegate cb_getFromContact;
#pragma warning disable 0169
		static Delegate GetGetFromContactHandler ()
		{
			if (cb_getFromContact == null)
				cb_getFromContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFromContact);
			return cb_getFromContact;
		}

		static IntPtr n_GetFromContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FromContact);
		}
#pragma warning restore 0169

		static IntPtr id_getFromContact;
		public virtual unsafe string FromContact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='getFromContact' and count(parameter)=0]"
			[Register ("getFromContact", "()Ljava/lang/String;", "GetGetFromContactHandler")]
			get {
				if (id_getFromContact == IntPtr.Zero)
					id_getFromContact = JNIEnv.GetMethodID (class_ref, "getFromContact", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFromContact), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFromContact", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFromSip;
#pragma warning disable 0169
		static Delegate GetGetFromSipHandler ()
		{
			if (cb_getFromSip == null)
				cb_getFromSip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFromSip);
			return cb_getFromSip;
		}

		static IntPtr n_GetFromSip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FromSip);
		}
#pragma warning restore 0169

		static IntPtr id_getFromSip;
		public virtual unsafe string FromSip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='getFromSip' and count(parameter)=0]"
			[Register ("getFromSip", "()Ljava/lang/String;", "GetGetFromSipHandler")]
			get {
				if (id_getFromSip == IntPtr.Zero)
					id_getFromSip = JNIEnv.GetMethodID (class_ref, "getFromSip", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFromSip), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFromSip", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActive;
		}
#pragma warning restore 0169

		static IntPtr id_isActive;
		public virtual unsafe bool IsActive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='isActive' and count(parameter)=0]"
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
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToContact);
		}
#pragma warning restore 0169

		static IntPtr id_getToContact;
		public virtual unsafe string ToContact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='getToContact' and count(parameter)=0]"
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
		}

		static Delegate cb_getToSip;
#pragma warning disable 0169
		static Delegate GetGetToSipHandler ()
		{
			if (cb_getToSip == null)
				cb_getToSip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToSip);
			return cb_getToSip;
		}

		static IntPtr n_GetToSip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToSip);
		}
#pragma warning restore 0169

		static IntPtr id_getToSip;
		public virtual unsafe string ToSip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='getToSip' and count(parameter)=0]"
			[Register ("getToSip", "()Ljava/lang/String;", "GetGetToSipHandler")]
			get {
				if (id_getToSip == IntPtr.Zero)
					id_getToSip = JNIEnv.GetMethodID (class_ref, "getToSip", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getToSip), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToSip", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_answer;
#pragma warning disable 0169
		static Delegate GetAnswerHandler ()
		{
			if (cb_answer == null)
				cb_answer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Answer);
			return cb_answer;
		}

		static void n_Answer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Answer ();
		}
#pragma warning restore 0169

		static IntPtr id_answer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='answer' and count(parameter)=0]"
		[Register ("answer", "()V", "GetAnswerHandler")]
		public virtual unsafe void Answer ()
		{
			if (id_answer == IntPtr.Zero)
				id_answer = JNIEnv.GetMethodID (class_ref, "answer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_answer);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "answer", "()V"));
			} finally {
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
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hangup ();
		}
#pragma warning restore 0169

		static IntPtr id_hangup;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='hangup' and count(parameter)=0]"
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
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mute ();
		}
#pragma warning restore 0169

		static IntPtr id_mute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='mute' and count(parameter)=0]"
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

		static Delegate cb_reject;
#pragma warning disable 0169
		static Delegate GetRejectHandler ()
		{
			if (cb_reject == null)
				cb_reject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reject);
			return cb_reject;
		}

		static void n_Reject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reject ();
		}
#pragma warning restore 0169

		static IntPtr id_reject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='reject' and count(parameter)=0]"
		[Register ("reject", "()V", "GetRejectHandler")]
		public virtual unsafe void Reject ()
		{
			if (id_reject == IntPtr.Zero)
				id_reject = JNIEnv.GetMethodID (class_ref, "reject", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_reject);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reject", "()V"));
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
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendDigits (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendDigits_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='sendDigits' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Plivo.Endpoint.Incoming __this = global::Java.Lang.Object.GetObject<global::Com.Plivo.Endpoint.Incoming> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Unmute ();
		}
#pragma warning restore 0169

		static IntPtr id_unmute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Incoming']/method[@name='unmute' and count(parameter)=0]"
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
