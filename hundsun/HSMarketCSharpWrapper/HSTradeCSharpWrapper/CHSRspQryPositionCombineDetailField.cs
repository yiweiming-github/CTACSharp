//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Trade {

public class CHSRspQryPositionCombineDetailField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQryPositionCombineDetailField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQryPositionCombineDetailField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQryPositionCombineDetailField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspQryPositionCombineDetailField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CombPositionID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_CombPositionID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_CombPositionID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string CombStrategyID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_CombStrategyID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_CombStrategyID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeType {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_HedgeType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_HedgeType_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public double YdPositionVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_YdPositionVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_YdPositionVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double AvailablePositionVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_AvailablePositionVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_AvailablePositionVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double TotalCombVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_TotalCombVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_TotalCombVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double TotalSplitVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_TotalSplitVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_TotalSplitVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionMargin {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_PositionMargin_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_PositionMargin_get(swigCPtr);
      return ret;
    } 
  }

  public int OpenDate {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_OpenDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspQryPositionCombineDetailField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQryPositionCombineDetailField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspQryPositionCombineDetailField(), true) {
  }

}

}
