using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Radaee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/radaee/view/PDFVCache", DoNotGenerateAcw=true)]
	public partial class PDFVCache : global::Java.Lang.Object {


		static IntPtr m_dib_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/field[@name='m_dib']"
		[Register ("m_dib")]
		protected global::Com.Radaee.Pdf.DIB MDib {
			get {
				if (m_dib_jfieldId == IntPtr.Zero)
					m_dib_jfieldId = JNIEnv.GetFieldID (class_ref, "m_dib", "Lcom/radaee/pdf/DIB;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_dib_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.DIB> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_dib_jfieldId == IntPtr.Zero)
					m_dib_jfieldId = JNIEnv.GetFieldID (class_ref, "m_dib", "Lcom/radaee/pdf/DIB;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_dib_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_dibh_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/field[@name='m_dibh']"
		[Register ("m_dibh")]
		protected int MDibh {
			get {
				if (m_dibh_jfieldId == IntPtr.Zero)
					m_dibh_jfieldId = JNIEnv.GetFieldID (class_ref, "m_dibh", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, m_dibh_jfieldId);
			}
			set {
				if (m_dibh_jfieldId == IntPtr.Zero)
					m_dibh_jfieldId = JNIEnv.GetFieldID (class_ref, "m_dibh", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_dibh_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_dibw_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/field[@name='m_dibw']"
		[Register ("m_dibw")]
		protected int MDibw {
			get {
				if (m_dibw_jfieldId == IntPtr.Zero)
					m_dibw_jfieldId = JNIEnv.GetFieldID (class_ref, "m_dibw", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, m_dibw_jfieldId);
			}
			set {
				if (m_dibw_jfieldId == IntPtr.Zero)
					m_dibw_jfieldId = JNIEnv.GetFieldID (class_ref, "m_dibw", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_dibw_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_doc_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/field[@name='m_doc']"
		[Register ("m_doc")]
		protected global::Com.Radaee.Pdf.Document MDoc {
			get {
				if (m_doc_jfieldId == IntPtr.Zero)
					m_doc_jfieldId = JNIEnv.GetFieldID (class_ref, "m_doc", "Lcom/radaee/pdf/Document;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_doc_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Document> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_doc_jfieldId == IntPtr.Zero)
					m_doc_jfieldId = JNIEnv.GetFieldID (class_ref, "m_doc", "Lcom/radaee/pdf/Document;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_doc_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_page_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/field[@name='m_page']"
		[Register ("m_page")]
		protected global::Com.Radaee.Pdf.Page MPage {
			get {
				if (m_page_jfieldId == IntPtr.Zero)
					m_page_jfieldId = JNIEnv.GetFieldID (class_ref, "m_page", "Lcom/radaee/pdf/Page;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, m_page_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Radaee.Pdf.Page> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (m_page_jfieldId == IntPtr.Zero)
					m_page_jfieldId = JNIEnv.GetFieldID (class_ref, "m_page", "Lcom/radaee/pdf/Page;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_page_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr m_pageno_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/field[@name='m_pageno']"
		[Register ("m_pageno")]
		protected int MPageno {
			get {
				if (m_pageno_jfieldId == IntPtr.Zero)
					m_pageno_jfieldId = JNIEnv.GetFieldID (class_ref, "m_pageno", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, m_pageno_jfieldId);
			}
			set {
				if (m_pageno_jfieldId == IntPtr.Zero)
					m_pageno_jfieldId = JNIEnv.GetFieldID (class_ref, "m_pageno", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_pageno_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_scale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/field[@name='m_scale']"
		[Register ("m_scale")]
		protected float MScale {
			get {
				if (m_scale_jfieldId == IntPtr.Zero)
					m_scale_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scale", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, m_scale_jfieldId);
			}
			set {
				if (m_scale_jfieldId == IntPtr.Zero)
					m_scale_jfieldId = JNIEnv.GetFieldID (class_ref, "m_scale", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_scale_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr m_status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/field[@name='m_status']"
		[Register ("m_status")]
		protected int MStatus {
			get {
				if (m_status_jfieldId == IntPtr.Zero)
					m_status_jfieldId = JNIEnv.GetFieldID (class_ref, "m_status", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, m_status_jfieldId);
			}
			set {
				if (m_status_jfieldId == IntPtr.Zero)
					m_status_jfieldId = JNIEnv.GetFieldID (class_ref, "m_status", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, m_status_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/radaee/view/PDFVCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PDFVCache); }
		}

		protected PDFVCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_radaee_pdf_Document_IFII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/constructor[@name='PDFVCache' and count(parameter)=5 and parameter[1][@type='com.radaee.pdf.Document'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/radaee/pdf/Document;IFII)V", "")]
		protected unsafe PDFVCache (global::Com.Radaee.Pdf.Document p0, int p1, float p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (PDFVCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/radaee/pdf/Document;IFII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/radaee/pdf/Document;IFII)V", __args);
					return;
				}

				if (id_ctor_Lcom_radaee_pdf_Document_IFII == IntPtr.Zero)
					id_ctor_Lcom_radaee_pdf_Document_IFII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/radaee/pdf/Document;IFII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_radaee_pdf_Document_IFII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_radaee_pdf_Document_IFII, __args);
			} finally {
			}
		}

		static Delegate cb_Clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_Clear == null)
				cb_Clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_Clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_Clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/method[@name='Clear' and count(parameter)=0]"
		[Register ("Clear", "()V", "GetClearHandler")]
		protected virtual unsafe void Clear ()
		{
			if (id_Clear == IntPtr.Zero)
				id_Clear = JNIEnv.GetMethodID (class_ref, "Clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_Render;
#pragma warning disable 0169
		static Delegate GetRenderHandler ()
		{
			if (cb_Render == null)
				cb_Render = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Render);
			return cb_Render;
		}

		static void n_Render (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Render ();
		}
#pragma warning restore 0169

		static IntPtr id_Render;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/method[@name='Render' and count(parameter)=0]"
		[Register ("Render", "()V", "GetRenderHandler")]
		protected virtual unsafe void Render ()
		{
			if (id_Render == IntPtr.Zero)
				id_Render = JNIEnv.GetMethodID (class_ref, "Render", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_Render);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "Render", "()V"));
			} finally {
			}
		}

		static Delegate cb_RenderThumb;
#pragma warning disable 0169
		static Delegate GetRenderThumbHandler ()
		{
			if (cb_RenderThumb == null)
				cb_RenderThumb = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RenderThumb);
			return cb_RenderThumb;
		}

		static void n_RenderThumb (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Radaee.View.PDFVCache __this = global::Java.Lang.Object.GetObject<global::Com.Radaee.View.PDFVCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RenderThumb ();
		}
#pragma warning restore 0169

		static IntPtr id_RenderThumb;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/method[@name='RenderThumb' and count(parameter)=0]"
		[Register ("RenderThumb", "()V", "GetRenderThumbHandler")]
		protected virtual unsafe void RenderThumb ()
		{
			if (id_RenderThumb == IntPtr.Zero)
				id_RenderThumb = JNIEnv.GetMethodID (class_ref, "RenderThumb", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_RenderThumb);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RenderThumb", "()V"));
			} finally {
			}
		}

		static IntPtr id_UIIsSame_FII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/method[@name='UIIsSame' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("UIIsSame", "(FII)Z", "")]
		protected unsafe bool UIIsSame (float p0, int p1, int p2)
		{
			if (id_UIIsSame_FII == IntPtr.Zero)
				id_UIIsSame_FII = JNIEnv.GetMethodID (class_ref, "UIIsSame", "(FII)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_UIIsSame_FII, __args);
			} finally {
			}
		}

		static IntPtr id_UIRenderCancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.radaee.view']/class[@name='PDFVCache']/method[@name='UIRenderCancel' and count(parameter)=0]"
		[Register ("UIRenderCancel", "()V", "")]
		protected unsafe void UIRenderCancel ()
		{
			if (id_UIRenderCancel == IntPtr.Zero)
				id_UIRenderCancel = JNIEnv.GetMethodID (class_ref, "UIRenderCancel", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_UIRenderCancel);
			} finally {
			}
		}

	}
}
