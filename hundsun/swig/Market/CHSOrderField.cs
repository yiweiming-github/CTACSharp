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

public class CHSOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSOrderField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerOrderID {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_BrokerOrderID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_BrokerOrderID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSOrderField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSOrderField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSOrderField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeType {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_HedgeType_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSOrderField_HedgeType_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSOrderField_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_OrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSOrderField_OrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSOrderField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_TradeVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSOrderField_TradeVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CancelVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_CancelVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSOrderField_CancelVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double TradePrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_TradePrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSOrderField_TradePrice_get(swigCPtr);
      return ret;
    } 
  }

  public int TradingDay {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_TradingDay_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSOrderField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int InsertDate {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_InsertDate_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSOrderField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public int InsertTime {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_InsertTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSOrderField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public int ReportTime {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_ReportTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSOrderField_ReportTime_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommand {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_OrderCommand_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_OrderCommand_get(swigCPtr);
      return ret;
    } 
  }

  public double MinVolume {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_MinVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSOrderField_MinVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double SpringPrice {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_SpringPrice_set(swigCPtr, value);
    } 
    get {
      double ret = HSMarketCppWrapperPINVOKE.CHSOrderField_SpringPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char SwapOrderFlag {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_SwapOrderFlag_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSOrderField_SwapOrderFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ForceCloseReason {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_ForceCloseReason_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_ForceCloseReason_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSMarketCppWrapperPINVOKE.CHSOrderField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      HSMarketCppWrapperPINVOKE.CHSOrderField_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = HSMarketCppWrapperPINVOKE.CHSOrderField_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public CHSOrderField() : this(HSMarketCppWrapperPINVOKE.new_CHSOrderField(), true) {
  }

}

}