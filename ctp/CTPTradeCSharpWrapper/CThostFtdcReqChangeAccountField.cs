//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqChangeAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqChangeAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqChangeAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqChangeAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcReqChangeAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char Gender {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Gender_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Gender_get(swigCPtr);
      return ret;
    } 
  }

  public string CountryCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_CountryCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_CountryCode_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string MobilePhone {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_MobilePhone_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_MobilePhone_get(swigCPtr);
      return ret;
    } 
  }

  public string Fax {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Fax_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Fax_get(swigCPtr);
      return ret;
    } 
  }

  public string EMail {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_EMail_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_EMail_get(swigCPtr);
      return ret;
    } 
  }

  public char MoneyAccountStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_MoneyAccountStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_MoneyAccountStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string NewBankAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_NewBankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_NewBankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string NewBankPassWord {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_NewBankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_NewBankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcReqChangeAccountField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqChangeAccountField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcReqChangeAccountField(), true) {
  }

}
