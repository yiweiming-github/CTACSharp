//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcCombinationLegField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcCombinationLegField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcCombinationLegField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcCombinationLegField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcCombinationLegField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string CombInstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_CombInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_CombInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public int LegID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_LegID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_LegID_get(swigCPtr);
      return ret;
    } 
  }

  public string LegInstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_LegInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_LegInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public int LegMultiple {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_LegMultiple_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_LegMultiple_get(swigCPtr);
      return ret;
    } 
  }

  public int ImplyLevel {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_ImplyLevel_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcCombinationLegField_ImplyLevel_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcCombinationLegField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcCombinationLegField(), true) {
  }

}
