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

public class CThostFtdcRspRepealField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRspRepealField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRspRepealField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRspRepealField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcRspRepealField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int RepealTimeInterval {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_RepealTimeInterval_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_RepealTimeInterval_get(swigCPtr);
      return ret;
    } 
  }

  public int RepealedTimes {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_RepealedTimes_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_RepealedTimes_get(swigCPtr);
      return ret;
    } 
  }

  public char BankRepealFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankRepealFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankRepealFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BrokerRepealFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerRepealFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerRepealFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateRepealSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_PlateRepealSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_PlateRepealSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string BankRepealSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankRepealSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankRepealSerial_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureRepealSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_FutureRepealSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_FutureRepealSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureSerial {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_FutureSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_FutureSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmount {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradeAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TradeAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double FutureFetchAmount {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_FutureFetchAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_FutureFetchAmount_get(swigCPtr);
      return ret;
    } 
  }

  public char FeePayFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_FeePayFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_FeePayFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double CustFee {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_CustFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_CustFee_get(swigCPtr);
      return ret;
    } 
  }

  public double BrokerFee {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerFee_get(swigCPtr);
      return ret;
    } 
  }

  public string Message {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_Message_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_Message_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public char BankSecuAccType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankSecuAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankSecuAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSecuAcc {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankSecuAcc_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankSecuAcc_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public char TransferStatus {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TransferStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_TransferStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcRspRepealField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRspRepealField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcRspRepealField(), true) {
  }

}

}