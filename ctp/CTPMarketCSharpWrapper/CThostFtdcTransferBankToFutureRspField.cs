//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTransferBankToFutureRspField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTransferBankToFutureRspField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTransferBankToFutureRspField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTransferBankToFutureRspField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcTransferBankToFutureRspField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string RetCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_RetCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_RetCode_get(swigCPtr);
      return ret;
    } 
  }

  public string RetInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_RetInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_RetInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string FutureAccount {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_FutureAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_FutureAccount_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmt {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_TradeAmt_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_TradeAmt_get(swigCPtr);
      return ret;
    } 
  }

  public double CustFee {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_CustFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_CustFee_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_CurrencyCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferBankToFutureRspField_CurrencyCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTransferBankToFutureRspField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcTransferBankToFutureRspField(), true) {
  }

}
