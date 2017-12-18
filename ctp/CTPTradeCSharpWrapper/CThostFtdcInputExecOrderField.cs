//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInputExecOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputExecOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputExecOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputExecOrderField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcInputExecOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderRef {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_ExecOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_ExecOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_ActionType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_ActionType_get(swigCPtr);
      return ret;
    } 
  }

  public char PosiDirection {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_PosiDirection_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_PosiDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char ReservePositionFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_ReservePositionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_ReservePositionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char CloseFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_CloseFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderField_CloseFlag_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputExecOrderField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcInputExecOrderField(), true) {
  }

}
