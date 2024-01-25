﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_v8handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_v8handler_t*, cef_string_t*, cef_v8value_t*, UIntPtr, cef_v8value_t**, cef_v8value_t**, cef_string_t*, int> _execute;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_v8handler_t* self)
        {
            var obj = (CefV8Handler)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_v8handler_t* self)
        {
            var obj = (CefV8Handler)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_v8handler_t* self)
        {
            var obj = (CefV8Handler)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_v8handler_t* self)
        {
            var obj = (CefV8Handler)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int execute(cef_v8handler_t* self, cef_string_t* name, cef_v8value_t* @object, UIntPtr argumentsCount, cef_v8value_t** arguments, cef_v8value_t** retval, cef_string_t* exception)
        {
            var obj = (CefV8Handler)self->_obj.Target;
            return obj.execute(self, name, @object, argumentsCount, arguments, retval, exception);
        }
        
        internal static cef_v8handler_t* Alloc(CefV8Handler obj)
        {
            var ptr = (cef_v8handler_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_v8handler_t));
            *ptr = default(cef_v8handler_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_v8handler_t);
            ptr->_obj = GCHandle.Alloc(obj);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_v8handler_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_v8handler_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_v8handler_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_v8handler_t*, int>)&has_at_least_one_ref;
            ptr->_execute = &execute;
            return ptr;
        }
        
        internal static void Free(cef_v8handler_t* ptr)
        {
            ptr->_obj.Free();
            NativeMemory.Free((void*)ptr);
        }
        
    }
}