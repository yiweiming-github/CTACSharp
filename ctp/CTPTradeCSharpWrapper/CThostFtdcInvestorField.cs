//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInvestorField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcInvestorField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorGroupID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_InvestorGroupID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_InvestorGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorName {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_InvestorName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_InvestorName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdentifiedCardType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_IdentifiedCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_IdentifiedCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string Mobile {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_Mobile_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_Mobile_get(swigCPtr);
      return ret;
    } 
  }

  public string CommModelID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_CommModelID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_CommModelID_get(swigCPtr);
      return ret;
    } 
  }

  public string MarginModelID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_MarginModelID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcInvestorField_MarginModelID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcInvestorField(), true) {
  }

}
