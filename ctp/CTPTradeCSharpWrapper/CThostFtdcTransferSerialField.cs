//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTransferSerialField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTransferSerialField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTransferSerialField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTransferSerialField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcTransferSerialField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int PlateSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public char FutureAccType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_FutureAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_FutureAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_FutureSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_FutureSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradeAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_TradeAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double CustFee {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_CustFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_CustFee_get(swigCPtr);
      return ret;
    } 
  }

  public double BrokerFee {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BrokerFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BrokerFee_get(swigCPtr);
      return ret;
    } 
  }

  public char AvailabilityFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_AvailabilityFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_AvailabilityFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OperatorCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_OperatorCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_OperatorCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankNewAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankNewAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_BankNewAccount_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferSerialField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTransferSerialField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcTransferSerialField(), true) {
  }

}
