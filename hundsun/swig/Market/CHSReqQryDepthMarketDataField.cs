//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Market {

public class CHSReqQryDepthMarketDataField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSReqQryDepthMarketDataField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSReqQryDepthMarketDataField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSReqQryDepthMarketDataField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSReqQryDepthMarketDataField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQryDepthMarketDataField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSReqQryDepthMarketDataField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQryDepthMarketDataField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSReqQryDepthMarketDataField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CHSReqQryDepthMarketDataField() : this(HSMarketCppWrapperPINVOKE.new_CHSReqQryDepthMarketDataField(), true) {
  }

}

}