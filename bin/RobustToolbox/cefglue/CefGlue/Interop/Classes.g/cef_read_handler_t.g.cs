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
    internal unsafe struct cef_read_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_read_handler_t*, void*, UIntPtr, UIntPtr, UIntPtr> _read;
        internal delegate* unmanaged<cef_read_handler_t*, long, int, int> _seek;
        internal delegate* unmanaged<cef_read_handler_t*, long> _tell;
        internal delegate* unmanaged<cef_read_handler_t*, int> _eof;
        internal delegate* unmanaged<cef_read_handler_t*, int> _may_block;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_read_handler_t* self)
        {
            var obj = (CefReadHandler)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_read_handler_t* self)
        {
            var obj = (CefReadHandler)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_read_handler_t* self)
        {
            var obj = (CefReadHandler)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_read_handler_t* self)
        {
            var obj = (CefReadHandler)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static UIntPtr read(cef_read_handler_t* self, void* ptr, UIntPtr size, UIntPtr n)
        {
            var obj = (CefReadHandler)self->_obj.Target;
            return obj.read(self, ptr, size, n);
        }
        
        [UnmanagedCallersOnly]
        public static int seek(cef_read_handler_t* self, long offset, int whence)
        {
            var obj = (CefReadHandler)self->_obj.Target;
            return obj.seek(self, offset, whence);
        }
        
        [UnmanagedCallersOnly]
        public static long tell(cef_read_handler_t* self)
        {
            var obj = (CefReadHandler)self->_obj.Target;
            return obj.tell(self);
        }
        
        [UnmanagedCallersOnly]
        public static int eof(cef_read_handler_t* self)
        {
            var obj = (CefReadHandler)self->_obj.Target;
            return obj.eof(self);
        }
        
        [UnmanagedCallersOnly]
        public static int may_block(cef_read_handler_t* self)
        {
            var obj = (CefReadHandler)self->_obj.Target;
            return obj.may_block(self);
        }
        
        internal static cef_read_handler_t* Alloc(CefReadHandler obj)
        {
            var ptr = (cef_read_handler_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_read_handler_t));
            *ptr = default(cef_read_handler_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_read_handler_t);
            ptr->_obj = GCHandle.Alloc(obj);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_read_handler_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_read_handler_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_read_handler_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_read_handler_t*, int>)&has_at_least_one_ref;
            ptr->_read = &read;
            ptr->_seek = &seek;
            ptr->_tell = &tell;
            ptr->_eof = &eof;
            ptr->_may_block = &may_block;
            return ptr;
        }
        
        internal static void Free(cef_read_handler_t* ptr)
        {
            ptr->_obj.Free();
            NativeMemory.Free((void*)ptr);
        }
        
    }
}