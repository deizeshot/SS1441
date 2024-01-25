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
    internal unsafe struct cef_task_runner_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_task_runner_t*, cef_task_runner_t*, int> _is_same;
        internal delegate* unmanaged<cef_task_runner_t*, int> _belongs_to_current_thread;
        internal delegate* unmanaged<cef_task_runner_t*, CefThreadId, int> _belongs_to_thread;
        internal delegate* unmanaged<cef_task_runner_t*, cef_task_t*, int> _post_task;
        internal delegate* unmanaged<cef_task_runner_t*, cef_task_t*, long, int> _post_delayed_task;
        
        // GetForCurrentThread
        [DllImport(libcef.DllName, EntryPoint = "cef_task_runner_get_for_current_thread", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_task_runner_t* get_for_current_thread();
        
        // GetForThread
        [DllImport(libcef.DllName, EntryPoint = "cef_task_runner_get_for_thread", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_task_runner_t* get_for_thread(CefThreadId threadId);
        
        // AddRef
        
        public static void add_ref(cef_task_runner_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_task_runner_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_task_runner_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_task_runner_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // IsSame
        
        public static int is_same(cef_task_runner_t* self, cef_task_runner_t* that)
        {
            return self->_is_same(self, that);
        }
        
        // BelongsToCurrentThread
        
        public static int belongs_to_current_thread(cef_task_runner_t* self)
        {
            return self->_belongs_to_current_thread(self);
        }
        
        // BelongsToThread
        
        public static int belongs_to_thread(cef_task_runner_t* self, CefThreadId threadId)
        {
            return self->_belongs_to_thread(self, threadId);
        }
        
        // PostTask
        
        public static int post_task(cef_task_runner_t* self, cef_task_t* task)
        {
            return self->_post_task(self, task);
        }
        
        // PostDelayedTask
        
        public static int post_delayed_task(cef_task_runner_t* self, cef_task_t* task, long delay_ms)
        {
            return self->_post_delayed_task(self, task, delay_ms);
        }
        
    }
}