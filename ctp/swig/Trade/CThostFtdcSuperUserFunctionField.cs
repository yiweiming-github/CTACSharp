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

public class CThostFtdcSuperUserFunctionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSuperUserFunctionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSuperUserFunctionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSuperUserFunctionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcSuperUserFunctionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string UserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSuperUserFunctionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSuperUserFunctionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char FunctionCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSuperUserFunctionField_FunctionCode_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSuperUserFunctionField_FunctionCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSuperUserFunctionField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcSuperUserFunctionField(), true) {
  }

}

}
