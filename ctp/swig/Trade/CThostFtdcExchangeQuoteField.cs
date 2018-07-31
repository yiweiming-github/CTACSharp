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

public class CThostFtdcExchangeQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeQuoteField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcExchangeQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double AskPrice {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char AskOffsetFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidOffsetFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char AskHedgeFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidHedgeFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteLocalID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_QuoteLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_QuoteLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_QuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_QuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public char QuoteStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_QuoteStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_QuoteStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_AskOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_BidOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ForQuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeQuoteField_ForQuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeQuoteField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcExchangeQuoteField(), true) {
  }

}

}