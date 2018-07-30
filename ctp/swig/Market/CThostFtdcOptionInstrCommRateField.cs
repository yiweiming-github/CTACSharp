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

public class CThostFtdcOptionInstrCommRateField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcOptionInstrCommRateField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcOptionInstrCommRateField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcOptionInstrCommRateField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcOptionInstrCommRateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_OpenRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_OpenRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_OpenRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_OpenRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_CloseRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_CloseRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_CloseRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_CloseRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_CloseTodayRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_CloseTodayRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_CloseTodayRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_CloseTodayRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikeRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_StrikeRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_StrikeRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikeRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_StrikeRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcOptionInstrCommRateField_StrikeRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcOptionInstrCommRateField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcOptionInstrCommRateField(), true) {
  }

}

}
