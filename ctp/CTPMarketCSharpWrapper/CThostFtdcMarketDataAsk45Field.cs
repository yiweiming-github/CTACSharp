//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcMarketDataAsk45Field : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataAsk45Field(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataAsk45Field obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMarketDataAsk45Field() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcMarketDataAsk45Field(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double AskPrice4 {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataAsk45Field_AskPrice4_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataAsk45Field_AskPrice4_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume4 {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataAsk45Field_AskVolume4_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataAsk45Field_AskVolume4_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice5 {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataAsk45Field_AskPrice5_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataAsk45Field_AskPrice5_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume5 {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataAsk45Field_AskVolume5_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcMarketDataAsk45Field_AskVolume5_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataAsk45Field() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcMarketDataAsk45Field(), true) {
  }

}
