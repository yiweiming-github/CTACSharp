//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.HS.Market {

public class CHSRspQueryBankBalanceField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CHSRspQueryBankBalanceField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CHSRspQueryBankBalanceField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CHSRspQueryBankBalanceField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HSMarketCppWrapperPINVOKE.delete_CHSRspQueryBankBalanceField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int TransferSerialID {
    set {
      HSMarketCppWrapperPINVOKE.CHSRspQueryBankBalanceField_TransferSerialID_set(swigCPtr, value);
    } 
    get {
      int ret = HSMarketCppWrapperPINVOKE.CHSRspQueryBankBalanceField_TransferSerialID_get(swigCPtr);
      return ret;
    } 
  }

  public CHSRspQueryBankBalanceField() : this(HSMarketCppWrapperPINVOKE.new_CHSRspQueryBankBalanceField(), true) {
  }

}

}
