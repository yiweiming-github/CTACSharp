//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcLinkManField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcLinkManField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcLinkManField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcLinkManField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcLinkManField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char PersonType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_PersonType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_PersonType_get(swigCPtr);
      return ret;
    } 
  }

  public char IdentifiedCardType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_IdentifiedCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_IdentifiedCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public string PersonName {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_PersonName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_PersonName_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public int Priority {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_Priority_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_Priority_get(swigCPtr);
      return ret;
    } 
  }

  public string UOAZipCode {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_UOAZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_UOAZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string PersonFullName {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_PersonFullName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcLinkManField_PersonFullName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcLinkManField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcLinkManField(), true) {
  }

}
