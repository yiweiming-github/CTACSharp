//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTransferQryDetailRspField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTransferQryDetailRspField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTransferQryDetailRspField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTransferQryDetailRspField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcTransferQryDetailRspField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_FutureSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_FutureSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string FutureID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_FutureID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_FutureID_get(swigCPtr);
      return ret;
    } 
  }

  public string FutureAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_FutureAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_FutureAccount_get(swigCPtr);
      return ret;
    } 
  }

  public int BankSerial {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_BankSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBrchID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_BankBrchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_BankBrchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string CertCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_CertCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_CertCode_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_CurrencyCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_CurrencyCode_get(swigCPtr);
      return ret;
    } 
  }

  public double TxAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_TxAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_TxAmount_get(swigCPtr);
      return ret;
    } 
  }

  public char Flag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_Flag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTransferQryDetailRspField_Flag_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTransferQryDetailRspField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcTransferQryDetailRspField(), true) {
  }

}
