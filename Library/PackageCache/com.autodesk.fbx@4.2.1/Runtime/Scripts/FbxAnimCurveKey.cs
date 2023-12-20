#if UNITY_EDITOR || FBXSDK_RUNTIME
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Autodesk.Fbx {

public class FbxAnimCurveKey : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxAnimCurveKey(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimCurveKey obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxAnimCurveDef.ETangentMode GetTangentMode(bool pIncludeOverrides) {
    FbxAnimCurveDef.ETangentMode ret = (FbxAnimCurveDef.ETangentMode)NativeMethods.FbxAnimCurveKey_GetTangentMode__SWIG_0(swigCPtr, pIncludeOverrides);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxAnimCurveDef.ETangentMode GetTangentMode() {
    FbxAnimCurveDef.ETangentMode ret = (FbxAnimCurveDef.ETangentMode)NativeMethods.FbxAnimCurveKey_GetTangentMode__SWIG_1(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTangentMode(FbxAnimCurveDef.ETangentMode pTangentMode) {
    NativeMethods.FbxAnimCurveKey_SetTangentMode(swigCPtr, (int)pTangentMode);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public FbxAnimCurveDef.EWeightedMode GetTangentWeightMode() {
    FbxAnimCurveDef.EWeightedMode ret = (FbxAnimCurveDef.EWeightedMode)NativeMethods.FbxAnimCurveKey_GetTangentWeightMode(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTangentWeightMode(FbxAnimCurveDef.EWeightedMode pTangentWeightMode, FbxAnimCurveDef.EWeightedMode pMask) {
    NativeMethods.FbxAnimCurveKey_SetTangentWeightMode__SWIG_0(swigCPtr, (int)pTangentWeightMode, (int)pMask);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetTangentWeightMode(FbxAnimCurveDef.EWeightedMode pTangentWeightMode) {
    NativeMethods.FbxAnimCurveKey_SetTangentWeightMode__SWIG_1(swigCPtr, (int)pTangentWeightMode);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetTangentWeightAndAdjustTangent(FbxAnimCurveDef.EDataIndex pIndex, double pWeight) {
    NativeMethods.FbxAnimCurveKey_SetTangentWeightAndAdjustTangent(swigCPtr, (int)pIndex, pWeight);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public FbxAnimCurveDef.EVelocityMode GetTangentVelocityMode() {
    FbxAnimCurveDef.EVelocityMode ret = (FbxAnimCurveDef.EVelocityMode)NativeMethods.FbxAnimCurveKey_GetTangentVelocityMode(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetTangentVelocityMode(FbxAnimCurveDef.EVelocityMode pTangentVelocityMode, FbxAnimCurveDef.EVelocityMode pMask) {
    NativeMethods.FbxAnimCurveKey_SetTangentVelocityMode__SWIG_0(swigCPtr, (int)pTangentVelocityMode, (int)pMask);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetTangentVelocityMode(FbxAnimCurveDef.EVelocityMode pTangentVelocityMode) {
    NativeMethods.FbxAnimCurveKey_SetTangentVelocityMode__SWIG_1(swigCPtr, (int)pTangentVelocityMode);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public float GetDataFloat(FbxAnimCurveDef.EDataIndex pIndex) {
    float ret = NativeMethods.FbxAnimCurveKey_GetDataFloat(swigCPtr, (int)pIndex);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDataFloat(FbxAnimCurveDef.EDataIndex pIndex, float pValue) {
    NativeMethods.FbxAnimCurveKey_SetDataFloat(swigCPtr, (int)pIndex, pValue);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetTangentVisibility(FbxAnimCurveDef.ETangentVisibility pVisibility) {
    NativeMethods.FbxAnimCurveKey_SetTangentVisibility(swigCPtr, (int)pVisibility);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public FbxAnimCurveDef.ETangentVisibility GetTangentVisibility() {
    FbxAnimCurveDef.ETangentVisibility ret = (FbxAnimCurveDef.ETangentVisibility)NativeMethods.FbxAnimCurveKey_GetTangentVisibility(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetBreak(bool pVal) {
    NativeMethods.FbxAnimCurveKey_SetBreak(swigCPtr, pVal);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public bool GetBreak() {
    bool ret = NativeMethods.FbxAnimCurveKey_GetBreak(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

#endif // UNITY_EDITOR || FBXSDK_RUNTIME