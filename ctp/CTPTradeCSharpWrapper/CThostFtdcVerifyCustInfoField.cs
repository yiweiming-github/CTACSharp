//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcVerifyCustInfoField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcVerifyCustInfoField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcVerifyCustInfoField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcVerifyCustInfoField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcVerifyCustInfoField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string CustomerName {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyCustInfoField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyCustInfoField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyCustInfoField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyCustInfoField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyCustInfoField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyCustInfoField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyCustInfoField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcVerifyCustInfoField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcVerifyCustInfoField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcVerifyCustInfoField(), true) {
  }

}
