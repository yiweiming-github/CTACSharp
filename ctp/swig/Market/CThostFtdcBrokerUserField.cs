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

public class CThostFtdcBrokerUserField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerUserField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerUserField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerUserField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcBrokerUserField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserName {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_UserName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_UserName_get(swigCPtr);
      return ret;
    } 
  }

  public char UserType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_UserType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_UserType_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public int IsUsingOTP {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_IsUsingOTP_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserField_IsUsingOTP_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerUserField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcBrokerUserField(), true) {
  }

}

}
