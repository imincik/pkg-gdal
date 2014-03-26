/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OSGeo.OGR {

using System;
using System.Runtime.InteropServices;

public class DataSource : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;
  
  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public DataSource(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(DataSource obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(DataSource obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  public static HandleRef getCPtrAndSetReference(DataSource obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~DataSource() {
    Dispose();
  }

  public virtual void Dispose() {
  lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        OgrPINVOKE.delete_DataSource(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      swigParentRef = null;
      GC.SuppressFinalize(this);
    }
  }

  public string name {
    get {
      string ret = OgrPINVOKE.DataSource_name_get(swigCPtr);
      if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int GetRefCount() {
    int ret = OgrPINVOKE.DataSource_GetRefCount(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetSummaryRefCount() {
    int ret = OgrPINVOKE.DataSource_GetSummaryRefCount(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetLayerCount() {
    int ret = OgrPINVOKE.DataSource_GetLayerCount(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Driver GetDriver() {
    IntPtr cPtr = OgrPINVOKE.DataSource_GetDriver(swigCPtr);
    Driver ret = (cPtr == IntPtr.Zero) ? null : new Driver(cPtr, false, ThisOwn_false());
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetName() {
    string ret = OgrPINVOKE.DataSource_GetName(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int DeleteLayer(int index) {
    int ret = OgrPINVOKE.DataSource_DeleteLayer(swigCPtr, index);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SyncToDisk() {
    int ret = OgrPINVOKE.DataSource_SyncToDisk(swigCPtr);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Layer CreateLayer(string name, OSGeo.OSR.SpatialReference srs, wkbGeometryType geom_type, string[] options) {
    IntPtr cPtr = OgrPINVOKE.DataSource_CreateLayer(swigCPtr, name, OSGeo.OSR.SpatialReference.getCPtr(srs), (int)geom_type, (options != null)? new OgrPINVOKE.StringListMarshal(options)._ar : null);
    Layer ret = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, ThisOwn_false());
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Layer CopyLayer(Layer src_layer, string new_name, string[] options) {
    IntPtr cPtr = OgrPINVOKE.DataSource_CopyLayer(swigCPtr, Layer.getCPtr(src_layer), new_name, (options != null)? new OgrPINVOKE.StringListMarshal(options)._ar : null);
    Layer ret = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, ThisOwn_false());
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Layer GetLayerByIndex(int index) {
    IntPtr cPtr = OgrPINVOKE.DataSource_GetLayerByIndex(swigCPtr, index);
    Layer ret = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, ThisOwn_false());
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Layer GetLayerByName(string layer_name) {
    IntPtr cPtr = OgrPINVOKE.DataSource_GetLayerByName(swigCPtr, layer_name);
    Layer ret = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, ThisOwn_false());
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool TestCapability(string cap) {
    bool ret = OgrPINVOKE.DataSource_TestCapability(swigCPtr, cap);
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Layer ExecuteSQL(string statement, Geometry spatialFilter, string dialect) {
    IntPtr cPtr = OgrPINVOKE.DataSource_ExecuteSQL(swigCPtr, statement, Geometry.getCPtr(spatialFilter), dialect);
    Layer ret = (cPtr == IntPtr.Zero) ? null : new Layer(cPtr, false, ThisOwn_false());
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ReleaseResultSet(Layer layer) {
    OgrPINVOKE.DataSource_ReleaseResultSet(swigCPtr, Layer.getCPtrAndDisown(layer, ThisOwn_false()));
    if (OgrPINVOKE.SWIGPendingException.Pending) throw OgrPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
