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

public class CThostFtdcExchangeExecOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeExecOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeExecOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeExecOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcExchangeExecOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ExecOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ExecOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderLocalID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ExecOrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ExecOrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderActionStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_OrderActionStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_OrderActionStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionType_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeExecOrderActionField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcExchangeExecOrderActionField(), true) {
  }

}

}
