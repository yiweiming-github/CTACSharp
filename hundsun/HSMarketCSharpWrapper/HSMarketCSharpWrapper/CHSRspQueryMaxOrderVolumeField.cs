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

public class CHSRspQueryMaxOrderVolumeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQueryMaxOrderVolumeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQueryMaxOrderVolumeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQueryMaxOrderVolumeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSRspQueryMaxOrderVolumeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQueryMaxOrderVolumeField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspQueryMaxOrderVolumeField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public double MaxOrderVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQueryMaxOrderVolumeField_MaxOrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspQueryMaxOrderVolumeField_MaxOrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double MaxOrderVolumeUnit {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQueryMaxOrderVolumeField_MaxOrderVolumeUnit_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspQueryMaxOrderVolumeField_MaxOrderVolumeUnit_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQueryMaxOrderVolumeField() : this(HSMarketCppWrapperPINVOKE.new_CHSRspQueryMaxOrderVolumeField(), true) {
  }

}

}
