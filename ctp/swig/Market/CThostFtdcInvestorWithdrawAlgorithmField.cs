//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Market {

public class CThostFtdcInvestorWithdrawAlgorithmField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorWithdrawAlgorithmField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorWithdrawAlgorithmField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorWithdrawAlgorithmField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcInvestorWithdrawAlgorithmField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double UsingRatio {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_UsingRatio_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_UsingRatio_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageRatio {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_FundMortgageRatio_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_FundMortgageRatio_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorWithdrawAlgorithmField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcInvestorWithdrawAlgorithmField(), true) {
  }

}

}
