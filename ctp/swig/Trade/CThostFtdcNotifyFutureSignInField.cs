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

public class CThostFtdcNotifyFutureSignInField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcNotifyFutureSignInField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcNotifyFutureSignInField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcNotifyFutureSignInField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcNotifyFutureSignInField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string PinKey {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_PinKey_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_PinKey_get(swigCPtr);
      return ret;
    } 
  }

  public string MacKey {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_MacKey_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcNotifyFutureSignInField_MacKey_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcNotifyFutureSignInField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcNotifyFutureSignInField(), true) {
  }

}

}
