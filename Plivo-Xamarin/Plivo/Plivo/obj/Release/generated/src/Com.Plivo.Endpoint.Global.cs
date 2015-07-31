using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Plivo.Endpoint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Global']"
	[global::Android.Runtime.Register ("com/plivo/endpoint/Global", DoNotGenerateAcw=true)]
	public partial class Global : global::Java.Lang.Object {


		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Global']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static bool Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_jfieldId);
			}
			set {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, DEBUG_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/plivo/endpoint/Global", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Global); }
		}

		protected Global (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.plivo.endpoint']/class[@name='Global']/constructor[@name='Global' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Global ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Global)) {
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

	}
}
