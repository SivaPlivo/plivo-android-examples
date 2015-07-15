using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Plivo.Endpoint.Backend {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']"
	[global::Android.Runtime.Register ("com/plivo/endpoint/backend/plivoJNI", DoNotGenerateAcw=true)]
	public partial class PlivoJNI : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/plivo/endpoint/backend/plivoJNI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlivoJNI); }
		}

		protected PlivoJNI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/constructor[@name='plivoJNI' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlivoJNI ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PlivoJNI)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='Answer' and count(parameter)=1 and parameter[1][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='Call' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='Hangup' and count(parameter)=1 and parameter[1][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='Login' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='Logout' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='Mute' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_PlivoAppCallback_change_ownership_Lcom_plivo_endpoint_backend_PlivoAppCallback_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_change_ownership' and count(parameter)=3 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("PlivoAppCallback_change_ownership", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;JZ)V", "")]
		public static unsafe void PlivoAppCallback_change_ownership (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, long p1, bool p2)
		{
			if (id_PlivoAppCallback_change_ownership_Lcom_plivo_endpoint_backend_PlivoAppCallback_JZ == IntPtr.Zero)
				id_PlivoAppCallback_change_ownership_Lcom_plivo_endpoint_backend_PlivoAppCallback_JZ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_change_ownership", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;JZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_change_ownership_Lcom_plivo_endpoint_backend_PlivoAppCallback_JZ, __args);
			} finally {
			}
		}

		static IntPtr id_PlivoAppCallback_director_connect_Lcom_plivo_endpoint_backend_PlivoAppCallback_JZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_director_connect' and count(parameter)=4 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("PlivoAppCallback_director_connect", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;JZZ)V", "")]
		public static unsafe void PlivoAppCallback_director_connect (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, long p1, bool p2, bool p3)
		{
			if (id_PlivoAppCallback_director_connect_Lcom_plivo_endpoint_backend_PlivoAppCallback_JZZ == IntPtr.Zero)
				id_PlivoAppCallback_director_connect_Lcom_plivo_endpoint_backend_PlivoAppCallback_JZZ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_director_connect", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;JZZ)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_director_connect_Lcom_plivo_endpoint_backend_PlivoAppCallback_JZZ, __args);
			} finally {
			}
		}

		static IntPtr id_PlivoAppCallback_onDebugMessage_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onDebugMessage' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onDebugMessage", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onDebugMessage (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, string p2)
		{
			if (id_PlivoAppCallback_onDebugMessage_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onDebugMessage_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onDebugMessage", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onDebugMessage_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_PlivoAppCallback_onDebugMessageSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onDebugMessageSwigExplicitPlivoAppCallback' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onDebugMessageSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onDebugMessageSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, string p2)
		{
			if (id_PlivoAppCallback_onDebugMessageSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onDebugMessageSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onDebugMessageSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onDebugMessageSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_PlivoAppCallback_onIncomingCall_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onIncomingCall' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onIncomingCall", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onIncomingCall (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3, string p4, string p5)
		{
			if (id_PlivoAppCallback_onIncomingCall_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onIncomingCall_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onIncomingCall", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onIncomingCall_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_PlivoAppCallback_onIncomingCallHangup_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onIncomingCallHangup' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onIncomingCallHangup", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onIncomingCallHangup (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onIncomingCallHangup_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onIncomingCallHangup_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onIncomingCallHangup", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onIncomingCallHangup_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onIncomingCallHangupSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onIncomingCallHangupSwigExplicitPlivoAppCallback' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onIncomingCallHangupSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onIncomingCallHangupSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onIncomingCallHangupSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onIncomingCallHangupSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onIncomingCallHangupSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onIncomingCallHangupSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onIncomingCallRejected_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onIncomingCallRejected' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onIncomingCallRejected", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onIncomingCallRejected (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onIncomingCallRejected_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onIncomingCallRejected_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onIncomingCallRejected", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onIncomingCallRejected_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onIncomingCallRejectedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onIncomingCallRejectedSwigExplicitPlivoAppCallback' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onIncomingCallRejectedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onIncomingCallRejectedSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onIncomingCallRejectedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onIncomingCallRejectedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onIncomingCallRejectedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onIncomingCallRejectedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onIncomingCallSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onIncomingCallSwigExplicitPlivoAppCallback' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onIncomingCallSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onIncomingCallSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3, string p4, string p5)
		{
			if (id_PlivoAppCallback_onIncomingCallSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onIncomingCallSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onIncomingCallSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onIncomingCallSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_PlivoAppCallback_onLogin_JLcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onLogin' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("PlivoAppCallback_onLogin", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void PlivoAppCallback_onLogin (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1)
		{
			if (id_PlivoAppCallback_onLogin_JLcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_PlivoAppCallback_onLogin_JLcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onLogin", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onLogin_JLcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_PlivoAppCallback_onLoginFailed_JLcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onLoginFailed' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("PlivoAppCallback_onLoginFailed", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void PlivoAppCallback_onLoginFailed (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1)
		{
			if (id_PlivoAppCallback_onLoginFailed_JLcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_PlivoAppCallback_onLoginFailed_JLcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onLoginFailed", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onLoginFailed_JLcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_PlivoAppCallback_onLoginFailedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onLoginFailedSwigExplicitPlivoAppCallback' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("PlivoAppCallback_onLoginFailedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void PlivoAppCallback_onLoginFailedSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1)
		{
			if (id_PlivoAppCallback_onLoginFailedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_PlivoAppCallback_onLoginFailedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onLoginFailedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onLoginFailedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_PlivoAppCallback_onLoginSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onLoginSwigExplicitPlivoAppCallback' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("PlivoAppCallback_onLoginSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void PlivoAppCallback_onLoginSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1)
		{
			if (id_PlivoAppCallback_onLoginSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_PlivoAppCallback_onLoginSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onLoginSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onLoginSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_PlivoAppCallback_onLogout_JLcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onLogout' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("PlivoAppCallback_onLogout", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void PlivoAppCallback_onLogout (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1)
		{
			if (id_PlivoAppCallback_onLogout_JLcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_PlivoAppCallback_onLogout_JLcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onLogout", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onLogout_JLcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_PlivoAppCallback_onLogoutSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onLogoutSwigExplicitPlivoAppCallback' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("PlivoAppCallback_onLogoutSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void PlivoAppCallback_onLogoutSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1)
		{
			if (id_PlivoAppCallback_onLogoutSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_PlivoAppCallback_onLogoutSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onLogoutSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onLogoutSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCall_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCall' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCall", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCall (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCall_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCall_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCall", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCall_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallAnswered_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallAnswered' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallAnswered", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallAnswered (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallAnswered_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallAnswered_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallAnswered", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallAnswered_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallAnsweredSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallAnsweredSwigExplicitPlivoAppCallback' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallAnsweredSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallAnsweredSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallAnsweredSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallAnsweredSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallAnsweredSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallAnsweredSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallHangup_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallHangup' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallHangup", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallHangup (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallHangup_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallHangup_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallHangup", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallHangup_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallHangupSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallHangupSwigExplicitPlivoAppCallback' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallHangupSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallHangupSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallHangupSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallHangupSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallHangupSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallHangupSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallInvalid_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallInvalid' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallInvalid", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallInvalid (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallInvalid_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallInvalid_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallInvalid", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallInvalid_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallInvalidSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallInvalidSwigExplicitPlivoAppCallback' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallInvalidSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallInvalidSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallInvalidSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallInvalidSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallInvalidSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallInvalidSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallRejected_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallRejected' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallRejected", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallRejected (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallRejected_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallRejected_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallRejected", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallRejected_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallRejectedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallRejectedSwigExplicitPlivoAppCallback' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallRejectedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallRejectedSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallRejectedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallRejectedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallRejectedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallRejectedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallRinging_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallRinging' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallRinging", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallRinging (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallRinging_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallRinging_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallRinging", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallRinging_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallRingingSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallRingingSwigExplicitPlivoAppCallback' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallRingingSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallRingingSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallRingingSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallRingingSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallRingingSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallRingingSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onOutgoingCallSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onOutgoingCallSwigExplicitPlivoAppCallback' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onOutgoingCallSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onOutgoingCallSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2, string p3)
		{
			if (id_PlivoAppCallback_onOutgoingCallSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onOutgoingCallSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onOutgoingCallSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onOutgoingCallSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_PlivoAppCallback_onStarted_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onStarted' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onStarted", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onStarted (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, string p2)
		{
			if (id_PlivoAppCallback_onStarted_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onStarted_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onStarted", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onStarted_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_PlivoAppCallback_onStartedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onStartedSwigExplicitPlivoAppCallback' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='java.lang.String']]"
		[Register ("PlivoAppCallback_onStartedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V", "")]
		public static unsafe void PlivoAppCallback_onStartedSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, string p2)
		{
			if (id_PlivoAppCallback_onStartedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_PlivoAppCallback_onStartedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onStartedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onStartedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_PlivoAppCallback_onStopped_JLcom_plivo_endpoint_backend_PlivoAppCallback_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onStopped' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int']]"
		[Register ("PlivoAppCallback_onStopped", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;I)V", "")]
		public static unsafe void PlivoAppCallback_onStopped (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2)
		{
			if (id_PlivoAppCallback_onStopped_JLcom_plivo_endpoint_backend_PlivoAppCallback_I == IntPtr.Zero)
				id_PlivoAppCallback_onStopped_JLcom_plivo_endpoint_backend_PlivoAppCallback_I = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onStopped", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onStopped_JLcom_plivo_endpoint_backend_PlivoAppCallback_I, __args);
			} finally {
			}
		}

		static IntPtr id_PlivoAppCallback_onStoppedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='PlivoAppCallback_onStoppedSwigExplicitPlivoAppCallback' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[3][@type='int']]"
		[Register ("PlivoAppCallback_onStoppedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;I)V", "")]
		public static unsafe void PlivoAppCallback_onStoppedSwigExplicitPlivoAppCallback (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1, int p2)
		{
			if (id_PlivoAppCallback_onStoppedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_I == IntPtr.Zero)
				id_PlivoAppCallback_onStoppedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_I = JNIEnv.GetStaticMethodID (class_ref, "PlivoAppCallback_onStoppedSwigExplicitPlivoAppCallback", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_PlivoAppCallback_onStoppedSwigExplicitPlivoAppCallback_JLcom_plivo_endpoint_backend_PlivoAppCallback_I, __args);
			} finally {
			}
		}

		static IntPtr id_Reject_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='Reject' and count(parameter)=1 and parameter[1][@type='int']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SendDTMF' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
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

		static IntPtr id_SwigDirector_PlivoAppCallback_onDebugMessage_Lcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onDebugMessage' and count(parameter)=2 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onDebugMessage", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onDebugMessage (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, string p1)
		{
			if (id_SwigDirector_PlivoAppCallback_onDebugMessage_Lcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onDebugMessage_Lcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onDebugMessage", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onDebugMessage_Lcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onIncomingCall_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onIncomingCall' and count(parameter)=5 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onIncomingCall", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onIncomingCall (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1, string p2, string p3, string p4)
		{
			if (id_SwigDirector_PlivoAppCallback_onIncomingCall_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onIncomingCall_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onIncomingCall", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onIncomingCall_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onIncomingCallHangup_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onIncomingCallHangup' and count(parameter)=3 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onIncomingCallHangup", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onIncomingCallHangup (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1, string p2)
		{
			if (id_SwigDirector_PlivoAppCallback_onIncomingCallHangup_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onIncomingCallHangup_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onIncomingCallHangup", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onIncomingCallHangup_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onIncomingCallRejected_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onIncomingCallRejected' and count(parameter)=3 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onIncomingCallRejected", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onIncomingCallRejected (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1, string p2)
		{
			if (id_SwigDirector_PlivoAppCallback_onIncomingCallRejected_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onIncomingCallRejected_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onIncomingCallRejected", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onIncomingCallRejected_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onLogin_Lcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onLogin' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("SwigDirector_PlivoAppCallback_onLogin", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onLogin (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0)
		{
			if (id_SwigDirector_PlivoAppCallback_onLogin_Lcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onLogin_Lcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onLogin", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onLogin_Lcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onLoginFailed_Lcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onLoginFailed' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("SwigDirector_PlivoAppCallback_onLoginFailed", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onLoginFailed (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0)
		{
			if (id_SwigDirector_PlivoAppCallback_onLoginFailed_Lcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onLoginFailed_Lcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onLoginFailed", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onLoginFailed_Lcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onLogout_Lcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onLogout' and count(parameter)=1 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("SwigDirector_PlivoAppCallback_onLogout", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onLogout (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0)
		{
			if (id_SwigDirector_PlivoAppCallback_onLogout_Lcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onLogout_Lcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onLogout", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onLogout_Lcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onOutgoingCall_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onOutgoingCall' and count(parameter)=3 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onOutgoingCall", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onOutgoingCall (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1, string p2)
		{
			if (id_SwigDirector_PlivoAppCallback_onOutgoingCall_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onOutgoingCall_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onOutgoingCall", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onOutgoingCall_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onOutgoingCallAnswered_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onOutgoingCallAnswered' and count(parameter)=3 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onOutgoingCallAnswered", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onOutgoingCallAnswered (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1, string p2)
		{
			if (id_SwigDirector_PlivoAppCallback_onOutgoingCallAnswered_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onOutgoingCallAnswered_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onOutgoingCallAnswered", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onOutgoingCallAnswered_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onOutgoingCallHangup_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onOutgoingCallHangup' and count(parameter)=3 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onOutgoingCallHangup", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onOutgoingCallHangup (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1, string p2)
		{
			if (id_SwigDirector_PlivoAppCallback_onOutgoingCallHangup_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onOutgoingCallHangup_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onOutgoingCallHangup", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onOutgoingCallHangup_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onOutgoingCallInvalid_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onOutgoingCallInvalid' and count(parameter)=3 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onOutgoingCallInvalid", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onOutgoingCallInvalid (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1, string p2)
		{
			if (id_SwigDirector_PlivoAppCallback_onOutgoingCallInvalid_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onOutgoingCallInvalid_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onOutgoingCallInvalid", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onOutgoingCallInvalid_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onOutgoingCallRejected_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onOutgoingCallRejected' and count(parameter)=3 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onOutgoingCallRejected", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onOutgoingCallRejected (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1, string p2)
		{
			if (id_SwigDirector_PlivoAppCallback_onOutgoingCallRejected_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onOutgoingCallRejected_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onOutgoingCallRejected", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onOutgoingCallRejected_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onOutgoingCallRinging_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onOutgoingCallRinging' and count(parameter)=3 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onOutgoingCallRinging", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onOutgoingCallRinging (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1, string p2)
		{
			if (id_SwigDirector_PlivoAppCallback_onOutgoingCallRinging_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onOutgoingCallRinging_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onOutgoingCallRinging", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onOutgoingCallRinging_Lcom_plivo_endpoint_backend_PlivoAppCallback_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onStarted_Lcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onStarted' and count(parameter)=2 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='java.lang.String']]"
		[Register ("SwigDirector_PlivoAppCallback_onStarted", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onStarted (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, string p1)
		{
			if (id_SwigDirector_PlivoAppCallback_onStarted_Lcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onStarted_Lcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onStarted", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onStarted_Lcom_plivo_endpoint_backend_PlivoAppCallback_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_SwigDirector_PlivoAppCallback_onStopped_Lcom_plivo_endpoint_backend_PlivoAppCallback_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='SwigDirector_PlivoAppCallback_onStopped' and count(parameter)=2 and parameter[1][@type='com.plivo.endpoint.backend.PlivoAppCallback'] and parameter[2][@type='int']]"
		[Register ("SwigDirector_PlivoAppCallback_onStopped", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;I)V", "")]
		public static unsafe void SwigDirector_PlivoAppCallback_onStopped (global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p0, int p1)
		{
			if (id_SwigDirector_PlivoAppCallback_onStopped_Lcom_plivo_endpoint_backend_PlivoAppCallback_I == IntPtr.Zero)
				id_SwigDirector_PlivoAppCallback_onStopped_Lcom_plivo_endpoint_backend_PlivoAppCallback_I = JNIEnv.GetStaticMethodID (class_ref, "SwigDirector_PlivoAppCallback_onStopped", "(Lcom/plivo/endpoint/backend/PlivoAppCallback;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_SwigDirector_PlivoAppCallback_onStopped_Lcom_plivo_endpoint_backend_PlivoAppCallback_I, __args);
			} finally {
			}
		}

		static IntPtr id_UnMute_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='UnMute' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_delete_PlivoAppCallback_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='delete_PlivoAppCallback' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("delete_PlivoAppCallback", "(J)V", "")]
		public static unsafe void Delete_PlivoAppCallback (long p0)
		{
			if (id_delete_PlivoAppCallback_J == IntPtr.Zero)
				id_delete_PlivoAppCallback_J = JNIEnv.GetStaticMethodID (class_ref, "delete_PlivoAppCallback", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_delete_PlivoAppCallback_J, __args);
			} finally {
			}
		}

		static IntPtr id_new_PlivoAppCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='new_PlivoAppCallback' and count(parameter)=0]"
		[Register ("new_PlivoAppCallback", "()J", "")]
		public static unsafe long New_PlivoAppCallback ()
		{
			if (id_new_PlivoAppCallback == IntPtr.Zero)
				id_new_PlivoAppCallback = JNIEnv.GetStaticMethodID (class_ref, "new_PlivoAppCallback", "()J");
			try {
				return JNIEnv.CallStaticLongMethod  (class_ref, id_new_PlivoAppCallback);
			} finally {
			}
		}

		static IntPtr id_plivoDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='plivoDestroy' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='plivoRestart' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='plivoStart' and count(parameter)=0]"
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

		static IntPtr id_setCallbackObject_JLcom_plivo_endpoint_backend_PlivoAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.plivo.endpoint.backend']/class[@name='plivoJNI']/method[@name='setCallbackObject' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.plivo.endpoint.backend.PlivoAppCallback']]"
		[Register ("setCallbackObject", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V", "")]
		public static unsafe void SetCallbackObject (long p0, global::Com.Plivo.Endpoint.Backend.PlivoAppCallback p1)
		{
			if (id_setCallbackObject_JLcom_plivo_endpoint_backend_PlivoAppCallback_ == IntPtr.Zero)
				id_setCallbackObject_JLcom_plivo_endpoint_backend_PlivoAppCallback_ = JNIEnv.GetStaticMethodID (class_ref, "setCallbackObject", "(JLcom/plivo/endpoint/backend/PlivoAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCallbackObject_JLcom_plivo_endpoint_backend_PlivoAppCallback_, __args);
			} finally {
			}
		}

	}
}
