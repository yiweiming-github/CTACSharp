//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Trade {

public class CHSRspLockInsertField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspLockInsertField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspLockInsertField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspLockInsertField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSTradeCppWrapperPINVOKE.delete_CHSRspLockInsertField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string LockOrderSysID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_LockOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_LockOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingInstrID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_UnderlyingInstrID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_UnderlyingInstrID_get(swigCPtr);
      return ret;
    } 
  }

  public char LockType {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_LockType_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_LockType_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderVolume {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_OrderVolume_set(swigCPtr, value);
    } 
    get {
      double ret = HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_OrderVolume_get(swigCPtr);
      return ret;
    } 
  }

  public string UnderlyingAccountID {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_UnderlyingAccountID_set(swigCPtr, value);
    } 
    get {
      string ret = HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_UnderlyingAccountID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int InsertTime {
    set {
      HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_InsertTime_set(swigCPtr, value);
    } 
    get {
      int ret = HSTradeCppWrapperPINVOKE.CHSRspLockInsertField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspLockInsertField() : this(HSTradeCppWrapperPINVOKE.new_CHSRspLockInsertField(), true) {
  }

}

}
