//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQryExchangeQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryExchangeQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryExchangeQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryExchangeQuoteField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcQryExchangeQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ParticipantID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryExchangeQuoteField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryExchangeQuoteField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcQryExchangeQuoteField(), true) {
  }

}
