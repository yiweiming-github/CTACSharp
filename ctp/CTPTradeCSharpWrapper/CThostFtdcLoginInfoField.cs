//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcLoginInfoField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcLoginInfoField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcLoginInfoField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcLoginInfoField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcLoginInfoField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int FrontID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_LoginDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_LoginDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_LoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_LoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string InterfaceProductInfo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_InterfaceProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_InterfaceProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string ProtocolInfo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_ProtocolInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_ProtocolInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string SystemName {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_SystemName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_SystemName_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string MaxOrderRef {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_MaxOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_MaxOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string SHFETime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_SHFETime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_SHFETime_get(swigCPtr);
      return ret;
    } 
  }

  public string DCETime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_DCETime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_DCETime_get(swigCPtr);
      return ret;
    } 
  }

  public string CZCETime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_CZCETime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_CZCETime_get(swigCPtr);
      return ret;
    } 
  }

  public string FFEXTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_FFEXTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_FFEXTime_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string OneTimePassword {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_OneTimePassword_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_OneTimePassword_get(swigCPtr);
      return ret;
    } 
  }

  public string INETime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_INETime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLoginInfoField_INETime_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcLoginInfoField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcLoginInfoField(), true) {
  }

}