//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcBrokerTradingParamsField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerTradingParamsField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerTradingParamsField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerTradingParamsField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcBrokerTradingParamsField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char MarginPriceType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_MarginPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_MarginPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char Algorithm {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_Algorithm_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_Algorithm_get(swigCPtr);
      return ret;
    } 
  }

  public char AvailIncludeCloseProfit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_AvailIncludeCloseProfit_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_AvailIncludeCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public char OptionRoyaltyPriceType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_OptionRoyaltyPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerTradingParamsField_OptionRoyaltyPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerTradingParamsField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcBrokerTradingParamsField(), true) {
  }

}