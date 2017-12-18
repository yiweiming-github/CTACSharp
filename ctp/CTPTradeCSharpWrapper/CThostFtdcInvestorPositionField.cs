//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInvestorPositionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorPositionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorPositionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorPositionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcInvestorPositionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char PosiDirection {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PosiDirection_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PosiDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PositionDate_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PositionDate_get(swigCPtr);
      return ret;
    } 
  }

  public int YdPosition {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_YdPosition_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_YdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int Position {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_Position_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_Position_get(swigCPtr);
      return ret;
    } 
  }

  public int LongFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_LongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_LongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int ShortFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_ShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_ShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double LongFrozenAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_LongFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_LongFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortFrozenAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_ShortFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_ShortFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int OpenVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_OpenVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_OpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int CloseVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_OpenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_OpenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionCost {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PositionCost_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PositionCost_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PreMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PreMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UseMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_UseMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_UseMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCash {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_FrozenCash_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_FrozenCash_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double CashIn {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CashIn_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CashIn_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenCost {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_OpenCost_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_OpenCost_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeMargin {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_ExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_ExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public int CombPosition {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CombPosition_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CombPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int CombLongFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CombLongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CombLongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int CombShortFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CombShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CombShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByTrade {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseProfitByTrade_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_CloseProfitByTrade_get(swigCPtr);
      return ret;
    } 
  }

  public int TodayPosition {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_TodayPosition_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_TodayPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByMoney {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_MarginRateByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_MarginRateByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_MarginRateByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_MarginRateByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int StrikeFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_StrikeFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_StrikeFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikeFrozenAmount {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_StrikeFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_StrikeFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int AbandonFrozen {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_AbandonFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorPositionField_AbandonFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorPositionField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcInvestorPositionField(), true) {
  }

}
