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

public class CThostFtdcTransferQryBankReqField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTransferQryBankReqField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTransferQryBankReqField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTransferQryBankReqField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcTransferQryBankReqField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string FutureAccount {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankReqField_FutureAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankReqField_FutureAccount_get(swigCPtr);
      return ret;
    } 
  }

  public char FuturePwdFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankReqField_FuturePwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankReqField_FuturePwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string FutureAccPwd {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankReqField_FutureAccPwd_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankReqField_FutureAccPwd_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankReqField_CurrencyCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferQryBankReqField_CurrencyCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTransferQryBankReqField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcTransferQryBankReqField(), true) {
  }

}

}
