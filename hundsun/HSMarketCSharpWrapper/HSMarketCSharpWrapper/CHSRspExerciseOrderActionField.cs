//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Market {

public class CHSRspExerciseOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspExerciseOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspExerciseOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspExerciseOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSRspExerciseOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExerciseOrderSysID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_ExerciseOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_ExerciseOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExerciseRef {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_ExerciseRef_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_ExerciseRef_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspExerciseOrderActionField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspExerciseOrderActionField() : this(HSMarketCppWrapperPINVOKE.new_CHSRspExerciseOrderActionField(), true) {
  }

}

}
