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

public class CHSReqQueryLockVolumeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSReqQueryLockVolumeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSReqQueryLockVolumeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSReqQueryLockVolumeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSReqQueryLockVolumeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryLockVolumeField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSReqQueryLockVolumeField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryLockVolumeField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSReqQueryLockVolumeField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public char LockType {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryLockVolumeField_LockType_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSReqQueryLockVolumeField_LockType_get(swigCPtr);
      return ret;
    } 
  }

  public CHSReqQueryLockVolumeField() : this(HSMarketCppWrapperPINVOKE.new_CHSReqQueryLockVolumeField(), true) {
  }

}

}
