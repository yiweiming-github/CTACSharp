//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Trade {

public class CThostFtdcQryCombinationLegField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryCombinationLegField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryCombinationLegField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryCombinationLegField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcQryCombinationLegField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string CombInstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryCombinationLegField_CombInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryCombinationLegField_CombInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public int LegID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryCombinationLegField_LegID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryCombinationLegField_LegID_get(swigCPtr);
      return ret;
    } 
  }

  public string LegInstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryCombinationLegField_LegInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryCombinationLegField_LegInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryCombinationLegField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcQryCombinationLegField(), true) {
  }

}

}
