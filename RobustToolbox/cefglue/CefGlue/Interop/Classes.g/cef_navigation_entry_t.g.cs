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
    internal unsafe struct cef_navigation_entry_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_navigation_entry_t*, int> _is_valid;
        internal delegate* unmanaged<cef_navigation_entry_t*, cef_string_userfree*> _get_url;
        internal delegate* unmanaged<cef_navigation_entry_t*, cef_string_userfree*> _get_display_url;
        internal delegate* unmanaged<cef_navigation_entry_t*, cef_string_userfree*> _get_original_url;
        internal delegate* unmanaged<cef_navigation_entry_t*, cef_string_userfree*> _get_title;
        internal delegate* unmanaged<cef_navigation_entry_t*, CefTransitionType> _get_transition_type;
        internal delegate* unmanaged<cef_navigation_entry_t*, int> _has_post_data;
        internal delegate* unmanaged<cef_navigation_entry_t*, CefBaseTime> _get_completion_time;
        internal delegate* unmanaged<cef_navigation_entry_t*, int> _get_http_status_code;
        internal delegate* unmanaged<cef_navigation_entry_t*, cef_sslstatus_t*> _get_sslstatus;
        
        // AddRef
        
        public static void add_ref(cef_navigation_entry_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_navigation_entry_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_navigation_entry_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_navigation_entry_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // IsValid
        
        public static int is_valid(cef_navigation_entry_t* self)
        {
            return self->_is_valid(self);
        }
        
        // GetURL
        
        public static cef_string_userfree* get_url(cef_navigation_entry_t* self)
        {
            return self->_get_url(self);
        }
        
        // GetDisplayURL
        
        public static cef_string_userfree* get_display_url(cef_navigation_entry_t* self)
        {
            return self->_get_display_url(self);
        }
        
        // GetOriginalURL
        
        public static cef_string_userfree* get_original_url(cef_navigation_entry_t* self)
        {
            return self->_get_original_url(self);
        }
        
        // GetTitle
        
        public static cef_string_userfree* get_title(cef_navigation_entry_t* self)
        {
            return self->_get_title(self);
        }
        
        // GetTransitionType
        
        public static CefTransitionType get_transition_type(cef_navigation_entry_t* self)
        {
            return self->_get_transition_type(self);
        }
        
        // HasPostData
        
        public static int has_post_data(cef_navigation_entry_t* self)
        {
            return self->_has_post_data(self);
        }
        
        // GetCompletionTime
        
        public static CefBaseTime get_completion_time(cef_navigation_entry_t* self)
        {
            return self->_get_completion_time(self);
        }
        
        // GetHttpStatusCode
        
        public static int get_http_status_code(cef_navigation_entry_t* self)
        {
            return self->_get_http_status_code(self);
        }
        
        // GetSSLStatus
        
        public static cef_sslstatus_t* get_sslstatus(cef_navigation_entry_t* self)
        {
            return self->_get_sslstatus(self);
        }
        
    }
}
