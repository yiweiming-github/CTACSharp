//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcDisseminationField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcDisseminationField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcDisseminationField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcDisseminationField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcDisseminationField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public short SequenceSeries {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcDisseminationField_SequenceSeries_set(swigCPtr, value);
    } 
    get {
      short ret = CTPTradeCppWrapperPINVOKE.CThostFtdcDisseminationField_SequenceSeries_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcDisseminationField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcDisseminationField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcDisseminationField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcDisseminationField(), true) {
  }

}
