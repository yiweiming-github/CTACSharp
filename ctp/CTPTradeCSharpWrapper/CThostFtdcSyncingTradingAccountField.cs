//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncingTradingAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncingTradingAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncingTradingAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncingTradingAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcSyncingTradingAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMortgage {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreMortgage_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreMortgage_get(swigCPtr);
      return ret;
    } 
  }

  public double PreCredit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreCredit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreCredit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreDeposit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreDeposit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreDeposit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreBalance {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreBalance_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double InterestBase {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_InterestBase_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_InterestBase_get(swigCPtr);
      return ret;
    } 
  }

  public double Interest {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Interest_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Interest_get(swigCPtr);
      return ret;
    } 
  }

  public double Deposit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Deposit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public double Withdraw {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Withdraw_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Withdraw_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCash {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenCash_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenCash_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_CurrMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_CurrMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double CashIn {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_CashIn_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_CashIn_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double Balance {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Balance_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Balance_get(swigCPtr);
      return ret;
    } 
  }

  public double Available {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Available_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Available_get(swigCPtr);
      return ret;
    } 
  }

  public double WithdrawQuota {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_WithdrawQuota_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_WithdrawQuota_get(swigCPtr);
      return ret;
    } 
  }

  public double Reserve {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Reserve_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Reserve_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public double Credit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Credit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Credit_get(swigCPtr);
      return ret;
    } 
  }

  public double Mortgage {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Mortgage_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_Mortgage_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_ExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_ExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double DeliveryMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_DeliveryMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_DeliveryMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeDeliveryMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_ExchangeDeliveryMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_ExchangeDeliveryMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ReserveBalance {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_ReserveBalance_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_ReserveBalance_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double PreFundMortgageIn {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreFundMortgageIn_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreFundMortgageIn_get(swigCPtr);
      return ret;
    } 
  }

  public double PreFundMortgageOut {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreFundMortgageOut_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_PreFundMortgageOut_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageIn {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageIn_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageIn_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageOut {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageOut_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageOut_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageAvailable {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageAvailable_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageAvailable_get(swigCPtr);
      return ret;
    } 
  }

  public double MortgageableFund {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_MortgageableFund_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_MortgageableFund_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductFrozenMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductCommission {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductCommission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductFrozenCommission {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductFrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductFrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductPositionProfit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductCloseProfit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductCloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductPositionProfitByAlg {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductPositionProfitByAlg_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductPositionProfitByAlg_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductExchangeMargin {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncingTradingAccountField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcSyncingTradingAccountField(), true) {
  }

}
