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

public class CThostFtdcInvestorPositionCombineDetailField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorPositionCombineDetailField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorPositionCombineDetailField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorPositionCombineDetailField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcInvestorPositionCombineDetailField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ComTradeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_ComTradeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_ComTradeID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_TradeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_TradeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public int TotalAmt {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_TotalAmt_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_TotalAmt_get(swigCPtr);
      return ret;
    } 
  }

  public double Margin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_Margin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_Margin_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_ExchMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_ExchMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByMoney {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_MarginRateByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_MarginRateByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_MarginRateByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_MarginRateByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int LegID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_LegID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_LegID_get(swigCPtr);
      return ret;
    } 
  }

  public int LegMultiple {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_LegMultiple_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_LegMultiple_get(swigCPtr);
      return ret;
    } 
  }

  public string CombInstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_CombInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_CombInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public int TradeGroupID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_TradeGroupID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionCombineDetailField_TradeGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorPositionCombineDetailField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcInvestorPositionCombineDetailField(), true) {
  }

}

}
