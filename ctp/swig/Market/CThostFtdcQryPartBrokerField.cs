//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Market {

public class CThostFtdcQryPartBrokerField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryPartBrokerField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryPartBrokerField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryPartBrokerField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcQryPartBrokerField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQryPartBrokerField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQryPartBrokerField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQryPartBrokerField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQryPartBrokerField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQryPartBrokerField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQryPartBrokerField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryPartBrokerField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcQryPartBrokerField(), true) {
  }

}

}
