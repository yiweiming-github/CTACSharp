//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcBrokerUserRightAssignField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerUserRightAssignField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerUserRightAssignField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerUserRightAssignField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcBrokerUserRightAssignField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserRightAssignField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserRightAssignField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public int DRIdentityID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserRightAssignField_DRIdentityID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserRightAssignField_DRIdentityID_get(swigCPtr);
      return ret;
    } 
  }

  public int Tradeable {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserRightAssignField_Tradeable_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcBrokerUserRightAssignField_Tradeable_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerUserRightAssignField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcBrokerUserRightAssignField(), true) {
  }

}
