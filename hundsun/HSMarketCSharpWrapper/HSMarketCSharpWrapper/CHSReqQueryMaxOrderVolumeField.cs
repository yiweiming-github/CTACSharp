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

public class CHSReqQueryMaxOrderVolumeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSReqQueryMaxOrderVolumeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSReqQueryMaxOrderVolumeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSReqQueryMaxOrderVolumeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSReqQueryMaxOrderVolumeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommand {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OrderCommand_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OrderCommand_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeType {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_HedgeType_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_HedgeType_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSReqQueryMaxOrderVolumeField_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public CHSReqQueryMaxOrderVolumeField() : this(HSMarketCppWrapperPINVOKE.new_CHSReqQueryMaxOrderVolumeField(), true) {
  }

}

}
