//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQryQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryQuoteField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcQryQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_QuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_QuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTimeStart {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_InsertTimeStart_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_InsertTimeStart_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTimeEnd {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_InsertTimeEnd_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcQryQuoteField_InsertTimeEnd_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryQuoteField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcQryQuoteField(), true) {
  }

}
