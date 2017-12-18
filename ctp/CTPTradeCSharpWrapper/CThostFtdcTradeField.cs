//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTradeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTradeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTradeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTradeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcTradeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public char TradingRole {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradingRole_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradingRole_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double Price {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_Price_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_Price_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public char TradeType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeType_get(swigCPtr);
      return ret;
    } 
  }

  public char PriceSource {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_PriceSource_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_PriceSource_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public int BrokerOrderSeq {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_BrokerOrderSeq_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_BrokerOrderSeq_get(swigCPtr);
      return ret;
    } 
  }

  public char TradeSource {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeSource_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcTradeField_TradeSource_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTradeField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcTradeField(), true) {
  }

}
