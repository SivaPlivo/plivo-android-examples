using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Plivo.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='BackendListener']"
	[global::Android.Runtime.Register ("com/plivo/endpoint/BackendListener", DoNotGenerateAcw=true)]
	public partial class BackendListener : global::Com.Plivo.Endpoint.Backend.PlivoAppCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/plivo/endpoint/BackendListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BackendListener); }
		}

		protected BackendListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZLcom_plivo_endpoint_Endpoint_Lcom_plivo_endpoint_EventListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='BackendListener']/constructor[@name='BackendListener' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='com.plivo.endpoint.Endpoint'] and parameter[3][@type='com.plivo.endpoint.EventListener']]"
		[Register (".ctor", "(ZLcom/plivo/endpoint/Endpoint;Lcom/plivo/endpoint/EventListener;)V", "")]
		public unsafe BackendListener (bool p0, global::Com.Plivo.Endpoint.Endpoint p1, global::Com.Plivo.Endpoint.IEventListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BackendListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZLcom/plivo/endpoint/Endpoint;Lcom/plivo/endpoint/EventListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZLcom/plivo/endpoint/Endpoint;Lcom/plivo/endpoint/EventListener;)V", __args);
					return;
				}

				if (id_ctor_ZLcom_plivo_endpoint_Endpoint_Lcom_plivo_endpoint_EventListener_ == IntPtr.Zero)
					id_ctor_ZLcom_plivo_endpoint_Endpoint_Lcom_plivo_endpoint_EventListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZLcom/plivo/endpoint/Endpoint;Lcom/plivo/endpoint/EventListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZLcom_plivo_endpoint_Endpoint_Lcom_plivo_endpoint_EventListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZLcom_plivo_endpoint_Endpoint_Lcom_plivo_endpoint_EventListener_, __args);
			} finally {
			}
		}

	}
}
