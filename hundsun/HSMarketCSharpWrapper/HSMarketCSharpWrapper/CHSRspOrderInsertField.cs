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

public class CHSRspOrderInsertField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspOrderInsertField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspOrderInsertField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspOrderInsertField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSRspOrderInsertField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerOrderID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_BrokerOrderID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_BrokerOrderID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeType {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_HedgeType_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_HedgeType_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommand {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderCommand_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_OrderCommand_get(swigCPtr);
      return ret;
    } 
  }

  public int InsertTime {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_InsertTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public double MinVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_MinVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_MinVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double SpringPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_SpringPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_SpringPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char SwapOrderFlag {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_SwapOrderFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSRspOrderInsertField_SwapOrderFlag_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspOrderInsertField() : this(HSMarketCppWrapperPINVOKE.new_CHSRspOrderInsertField(), true) {
  }

}

}
