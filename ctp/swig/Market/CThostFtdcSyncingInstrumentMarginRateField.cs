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

public class CThostFtdcSyncingInstrumentMarginRateField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncingInstrumentMarginRateField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncingInstrumentMarginRateField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncingInstrumentMarginRateField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcSyncingInstrumentMarginRateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_LongMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_LongMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_LongMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_LongMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_ShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_ShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_ShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_ShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int IsRelative {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_IsRelative_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcSyncingInstrumentMarginRateField_IsRelative_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncingInstrumentMarginRateField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcSyncingInstrumentMarginRateField(), true) {
  }

}

}
