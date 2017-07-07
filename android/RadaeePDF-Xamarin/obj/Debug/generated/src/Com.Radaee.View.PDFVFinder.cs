using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/radaee/view/PDFVFinder", DoNotGenerateAcw=true)]
	public partial class PDFVFinder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFVFinder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFVFinder); }
		}

		protected PDFVFinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/constructor[@name='PDFVFinder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe PDFVFinder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PDFVFinder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_find;
#pragma warning disable 0169
		static Delegate GetFindHandler ()
		{
			if (cb_find == null)
				cb_find = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Find);
			return cb_find;
		}

		static int n_Find (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVFinder __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Find ();
		}
#pragma warning restore 0169

		static IntPtr id_find;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/method[@name='find' and count(parameter)=0]"
		[Register ("find", "()I", "GetFindHandler")]
		protected virtual unsafe int Find ()
		{
			if (id_find == IntPtr.Zero)
				id_find = JNIEnv.GetMethodID (class_ref, "find", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_find);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find", "()I"));
			} finally {
			}
		}

		static Delegate cb_find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II;
#pragma warning disable 0169
		static Delegate GetFind_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_IIHandler ()
		{
			if (cb_find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II == null)
				cb_find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_Find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II);
			return cb_find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II;
		}

		static void n_Find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Radaee.View.PDFVFinder __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.PDFVPage p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Find_draw (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/method[@name='find_draw' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.radaee.view.PDFVPage'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("find_draw", "(Landroid/graphics/Canvas;Lcom/radaee/view/PDFVPage;II)V", "GetFind_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_IIHandler")]
		protected virtual unsafe void Find_draw (global::Android.Graphics.Canvas p0, global::Com.Radaee.View.PDFVPage p1, int p2, int p3)
		{
			if (id_find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II == IntPtr.Zero)
				id_find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II = JNIEnv.GetMethodID (class_ref, "find_draw", "(Landroid/graphics/Canvas;Lcom/radaee/view/PDFVPage;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_find_draw_Landroid_graphics_Canvas_Lcom_radaee_view_PDFVPage_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find_draw", "(Landroid/graphics/Canvas;Lcom/radaee/view/PDFVPage;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II;
#pragma warning disable 0169
		static Delegate GetFind_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_IIHandler ()
		{
			if (cb_find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II == null)
				cb_find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_Find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II);
			return cb_find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II;
		}

		static void n_Find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Radaee.View.PDFVFinder __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.BMP p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.BMP> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.PDFVPage p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Find_draw (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/method[@name='find_draw' and count(parameter)=4 and parameter[1][@type='com.radaee.pdf.BMP'] and parameter[2][@type='com.radaee.view.PDFVPage'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("find_draw", "(Lcom/radaee/pdf/BMP;Lcom/radaee/view/PDFVPage;II)V", "GetFind_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_IIHandler")]
		protected virtual unsafe void Find_draw (global::Com.Radaee.Pdf.BMP p0, global::Com.Radaee.View.PDFVPage p1, int p2, int p3)
		{
			if (id_find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II == IntPtr.Zero)
				id_find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II = JNIEnv.GetMethodID (class_ref, "find_draw", "(Lcom/radaee/pdf/BMP;Lcom/radaee/view/PDFVPage;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_find_draw_Lcom_radaee_pdf_BMP_Lcom_radaee_view_PDFVPage_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find_draw", "(Lcom/radaee/pdf/BMP;Lcom/radaee/view/PDFVPage;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II;
#pragma warning disable 0169
		static Delegate GetFind_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_IIHandler ()
		{
			if (cb_find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II == null)
				cb_find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_Find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II);
			return cb_find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II;
		}

		static void n_Find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Radaee.View.PDFVFinder __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.DIB p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.DIB> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.View.PDFVPage p1 = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVPage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Find_draw_to_dib (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/method[@name='find_draw_to_dib' and count(parameter)=4 and parameter[1][@type='com.radaee.pdf.DIB'] and parameter[2][@type='com.radaee.view.PDFVPage'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("find_draw_to_dib", "(Lcom/radaee/pdf/DIB;Lcom/radaee/view/PDFVPage;II)V", "GetFind_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_IIHandler")]
		protected virtual unsafe void Find_draw_to_dib (global::Com.Radaee.Pdf.DIB p0, global::Com.Radaee.View.PDFVPage p1, int p2, int p3)
		{
			if (id_find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II == IntPtr.Zero)
				id_find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II = JNIEnv.GetMethodID (class_ref, "find_draw_to_dib", "(Lcom/radaee/pdf/DIB;Lcom/radaee/view/PDFVPage;II)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_find_draw_to_dib_Lcom_radaee_pdf_DIB_Lcom_radaee_view_PDFVPage_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find_draw_to_dib", "(Lcom/radaee/pdf/DIB;Lcom/radaee/view/PDFVPage;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_find_end;
#pragma warning disable 0169
		static Delegate GetFind_endHandler ()
		{
			if (cb_find_end == null)
				cb_find_end = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Find_end);
			return cb_find_end;
		}

		static void n_Find_end (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVFinder __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Find_end ();
		}
#pragma warning restore 0169

		static IntPtr id_find_end;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/method[@name='find_end' and count(parameter)=0]"
		[Register ("find_end", "()V", "GetFind_endHandler")]
		protected virtual unsafe void Find_end ()
		{
			if (id_find_end == IntPtr.Zero)
				id_find_end = JNIEnv.GetMethodID (class_ref, "find_end", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_find_end);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find_end", "()V"));
			} finally {
			}
		}

		static Delegate cb_find_get_page;
#pragma warning disable 0169
		static Delegate GetFind_get_pageHandler ()
		{
			if (cb_find_get_page == null)
				cb_find_get_page = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Find_get_page);
			return cb_find_get_page;
		}

		static int n_Find_get_page (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVFinder __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Find_get_page ();
		}
#pragma warning restore 0169

		static IntPtr id_find_get_page;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/method[@name='find_get_page' and count(parameter)=0]"
		[Register ("find_get_page", "()I", "GetFind_get_pageHandler")]
		protected virtual unsafe int Find_get_page ()
		{
			if (id_find_get_page == IntPtr.Zero)
				id_find_get_page = JNIEnv.GetMethodID (class_ref, "find_get_page", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_find_get_page);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find_get_page", "()I"));
			} finally {
			}
		}

		static Delegate cb_find_get_pos;
#pragma warning disable 0169
		static Delegate GetFind_get_posHandler ()
		{
			if (cb_find_get_pos == null)
				cb_find_get_pos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Find_get_pos);
			return cb_find_get_pos;
		}

		static IntPtr n_Find_get_pos (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVFinder __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Find_get_pos ());
		}
#pragma warning restore 0169

		static IntPtr id_find_get_pos;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/method[@name='find_get_pos' and count(parameter)=0]"
		[Register ("find_get_pos", "()[F", "GetFind_get_posHandler")]
		protected virtual unsafe float[] Find_get_pos ()
		{
			if (id_find_get_pos == IntPtr.Zero)
				id_find_get_pos = JNIEnv.GetMethodID (class_ref, "find_get_pos", "()[F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_find_get_pos), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find_get_pos", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_find_prepare_I;
#pragma warning disable 0169
		static Delegate GetFind_prepare_IHandler ()
		{
			if (cb_find_prepare_I == null)
				cb_find_prepare_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Find_prepare_I);
			return cb_find_prepare_I;
		}

		static int n_Find_prepare_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Radaee.View.PDFVFinder __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Find_prepare (p0);
		}
#pragma warning restore 0169

		static IntPtr id_find_prepare_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/method[@name='find_prepare' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("find_prepare", "(I)I", "GetFind_prepare_IHandler")]
		protected virtual unsafe int Find_prepare (int p0)
		{
			if (id_find_prepare_I == IntPtr.Zero)
				id_find_prepare_I = JNIEnv.GetMethodID (class_ref, "find_prepare", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_find_prepare_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find_prepare", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetFind_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZHandler ()
		{
			if (cb_find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ == null)
				cb_find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, bool, bool>) n_Find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ);
			return cb_find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ;
		}

		static void n_Find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, bool p3, bool p4)
		{
			global::Com.Radaee.View.PDFVFinder __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Radaee.Pdf.Document p0 = global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Find_start (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVFinder']/method[@name='find_start' and count(parameter)=5 and parameter[1][@type='com.radaee.pdf.Document'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("find_start", "(Lcom/radaee/pdf/Document;ILjava/lang/String;ZZ)V", "GetFind_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZHandler")]
		protected virtual unsafe void Find_start (global::Com.Radaee.Pdf.Document p0, int p1, string p2, bool p3, bool p4)
		{
			if (id_find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ == IntPtr.Zero)
				id_find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ = JNIEnv.GetMethodID (class_ref, "find_start", "(Lcom/radaee/pdf/Document;ILjava/lang/String;ZZ)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_find_start_Lcom_radaee_pdf_Document_ILjava_lang_String_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "find_start", "(Lcom/radaee/pdf/Document;ILjava/lang/String;ZZ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
