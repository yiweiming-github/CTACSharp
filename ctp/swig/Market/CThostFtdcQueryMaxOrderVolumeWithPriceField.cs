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

public class CThostFtdcQueryMaxOrderVolumeWithPriceField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQueryMaxOrderVolumeWithPriceField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQueryMaxOrderVolumeWithPriceField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQueryMaxOrderVolumeWithPriceField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcQueryMaxOrderVolumeWithPriceField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char OffsetFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_OffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_OffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int MaxVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_MaxVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_MaxVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double Price {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_Price_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcQueryMaxOrderVolumeWithPriceField_Price_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQueryMaxOrderVolumeWithPriceField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcQueryMaxOrderVolumeWithPriceField(), true) {
  }

}

}
