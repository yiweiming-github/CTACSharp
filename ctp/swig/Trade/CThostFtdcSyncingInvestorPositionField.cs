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

public class CThostFtdcSyncingInvestorPositionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncingInvestorPositionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncingInvestorPositionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncingInvestorPositionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcSyncingInvestorPositionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char PosiDirection {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PosiDirection_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PosiDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionDate_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionDate_get(swigCPtr);
      return ret;
    } 
  }

  public int YdPosition {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_YdPosition_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_YdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int Position {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_Position_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_Position_get(swigCPtr);
      return ret;
    } 
  }

  public int LongFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_LongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_LongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int ShortFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_ShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_ShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double LongFrozenAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_LongFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_LongFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortFrozenAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_ShortFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_ShortFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int OpenVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int CloseVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionCost {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionCost_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionCost_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PreMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PreMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UseMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_UseMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_UseMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCash {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenCash_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenCash_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double CashIn {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CashIn_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CashIn_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenCost {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenCost_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_OpenCost_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_ExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_ExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public int CombPosition {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CombPosition_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CombPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int CombLongFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CombLongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CombLongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int CombShortFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CombShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CombShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByTrade {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfitByTrade_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_CloseProfitByTrade_get(swigCPtr);
      return ret;
    } 
  }

  public int TodayPosition {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_TodayPosition_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_TodayPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByMoney {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_MarginRateByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_MarginRateByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_MarginRateByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_MarginRateByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int StrikeFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_StrikeFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_StrikeFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikeFrozenAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_StrikeFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_StrikeFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int AbandonFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_AbandonFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcSyncingInvestorPositionField_AbandonFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncingInvestorPositionField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcSyncingInvestorPositionField(), true) {
  }

}

}