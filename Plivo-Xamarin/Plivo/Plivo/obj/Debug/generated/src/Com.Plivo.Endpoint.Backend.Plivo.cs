using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Plivo.Endpoint.Backend {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']"
	[global::Android.Runtime.Register ("com/plivo/endpoint/backend/plivo", DoNotGenerateAcw=true)]
	public partial class Plivo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/plivo/endpoint/backend/plivo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Plivo); }
		}

		protected Plivo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/constructor[@name='plivo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Plivo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Plivo)) {
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

		static IntPtr id_Answer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='Answer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Answer", "(I)I", "")]
		public static unsafe int Answer (int p0)
		{
			if (id_Answer_I == IntPtr.Zero)
				id_Answer_I = JNIEnv.GetStaticMethodID (class_ref, "Answer", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_Answer_I, __args);
			} finally {
			}
		}

		static IntPtr id_Call_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='Call' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("Call", "(Ljava/lang/String;)I", "")]
		public static unsafe int Call (string p0)
		{
			if (id_Call_Ljava_lang_String_ == IntPtr.Zero)
				id_Call_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Call", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_Call_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_Hangup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='Hangup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Hangup", "(I)I", "")]
		public static unsafe int Hangup (int p0)
		{
			if (id_Hangup_I == IntPtr.Zero)
				id_Hangup_I = JNIEnv.GetStaticMethodID (class_ref, "Hangup", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_Hangup_I, __args);
			} finally {
			}
		}

		static IntPtr id_Login_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='Login' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("Login", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int Login (string p0, string p1)
		{
			if (id_Login_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_Login_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "Login", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_Login_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_Logout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='Logout' and count(parameter)=0]"
		[Register ("Logout", "()I", "")]
		public static unsafe int Logout ()
		{
			if (id_Logout == IntPtr.Zero)
				id_Logout = JNIEnv.GetStaticMethodID (class_ref, "Logout", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_Logout);
			} finally {
			}
		}

		static IntPtr id_Mute_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='Mute' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Mute", "(I)I", "")]
		public static unsafe int Mute (int p0)
		{
			if (id_Mute_I == IntPtr.Zero)
				id_Mute_I = JNIEnv.GetStaticMethodID (class_ref, "Mute", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_Mute_I, __args);
			} finally {
			}
		}

		static IntPtr id_Reject_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='Reject' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("Reject", "(I)I", "")]
		public static unsafe int Reject (int p0)
		{
			if (id_Reject_I == IntPtr.Zero)
				id_Reject_I = JNIEnv.GetStaticMethodID (class_ref, "Reject", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_Reject_I, __args);
			} finally {
			}
		}

		static IntPtr id_SendDTMF_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='SendDTMF' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("SendDTMF", "(ILjava/lang/String;)I", "")]
		public static unsafe int SendDTMF (int p0, string p1)
		{
			if (id_SendDTMF_ILjava_lang_String_ == IntPtr.Zero)
				id_SendDTMF_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SendDTMF", "(ILjava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_SendDTMF_ILjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_UnMute_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='UnMute' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("UnMute", "(I)I", "")]
		public static unsafe int UnMute (int p0)
		{
			if (id_UnMute_I == IntPtr.Zero)
				id_UnMute_I = JNIEnv.GetStaticMethodID (class_ref, "UnMute", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_UnMute_I, __args);
			} finally {
			}
		}

		static IntPtr id_plivoDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='plivoDestroy' and count(parameter)=0]"
		[Register ("plivoDestroy", "()V", "")]
		public static unsafe void PlivoDestroy ()
		{
			if (id_plivoDestroy == IntPtr.Zero)
				id_plivoDestroy = JNIEnv.GetStaticMethodID (class_ref, "plivoDestroy", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_plivoDestroy);
			} finally {
			}
		}

		static IntPtr id_plivoRestart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='plivoRestart' and count(parameter)=0]"
		[Register ("plivoRestart", "()I", "")]
		public static unsafe int PlivoRestart ()
		{
			if (id_plivoRestart == IntPtr.Zero)
				id_plivoRestart = JNIEnv.GetStaticMethodID (class_ref, "plivoRestart", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_plivoRestart);
			} finally {
			}
		}

		static IntPtr id_plivoStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='plivoStart' and count(parameter)=0]"
		[Register ("plivoStart", "()I", "")]
		public static unsafe int PlivoStart ()
		{
			if (id_plivoStart == IntPtr.Zero)
				id_plivoStart = JNIEnv.GetStaticMethodID (class_ref, "plivoStart", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_plivoStart);
			} finally {
			}
		}

		static IntPtr id_setCallbackObject_Lcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivo']/method[@name='setCallbackObject' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("setCallbackObject", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void SetCallbackObject (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0)
		{
			if (id_setCallbackObject_Lcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_setCallbackObject_Lcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "setCallbackObject", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCallbackObject_Lcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

	}
}
