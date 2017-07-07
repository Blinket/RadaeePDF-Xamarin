using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewHorz']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/radaee/view/PDFViewHorz", DoNotGenerateAcw=true)]
	public partial class PDFViewHorz : global::Com.Radaee.View.PDFView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFViewHorz", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFViewHorz); }
		}

		protected PDFViewHorz (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewHorz']/constructor[@name='PDFViewHorz' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PDFViewHorz (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PDFViewHorz)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_vSetDirection_Z;
#pragma warning disable 0169
		static Delegate GetVSetDirection_ZHandler ()
		{
			if (cb_vSetDirection_Z == null)
				cb_vSetDirection_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_VSetDirection_Z);
			return cb_vSetDirection_Z;
		}

		static void n_VSetDirection_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Radaee.View.PDFViewHorz __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFViewHorz> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VSetDirection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vSetDirection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFViewHorz']/method[@name='vSetDirection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("vSetDirection", "(Z)V", "GetVSetDirection_ZHandler")]
		public virtual unsafe void VSetDirection (bool p0)
		{
			if (id_vSetDirection_Z == IntPtr.Zero)
				id_vSetDirection_Z = JNIEnv.GetMethodID (class_ref, "vSetDirection", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_vSetDirection_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vSetDirection", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
