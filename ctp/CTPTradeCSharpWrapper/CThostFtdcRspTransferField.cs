//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRspTransferField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRspTransferField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRspTransferField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRspTransferField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcRspTransferField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_FutureSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_FutureSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradeAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TradeAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double FutureFetchAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_FutureFetchAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_FutureFetchAmount_get(swigCPtr);
      return ret;
    } 
  }

  public char FeePayFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_FeePayFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_FeePayFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double CustFee {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_CustFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_CustFee_get(swigCPtr);
      return ret;
    } 
  }

  public double BrokerFee {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BrokerFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BrokerFee_get(swigCPtr);
      return ret;
    } 
  }

  public string Message {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_Message_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_Message_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public char BankSecuAccType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankSecuAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankSecuAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSecuAcc {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankSecuAcc_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankSecuAcc_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public char TransferStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TransferStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_TransferStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcRspTransferField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRspTransferField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcRspTransferField(), true) {
  }

}
