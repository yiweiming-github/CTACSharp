//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInstrumentMarginRateAdjustField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInstrumentMarginRateAdjustField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInstrumentMarginRateAdjustField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInstrumentMarginRateAdjustField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcInstrumentMarginRateAdjustField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int IsRelative {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_IsRelative_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_IsRelative_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInstrumentMarginRateAdjustField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcInstrumentMarginRateAdjustField(), true) {
  }

}
