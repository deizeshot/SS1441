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
    internal unsafe struct cef_media_sink_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_media_sink_t*, cef_string_userfree*> _get_id;
        internal delegate* unmanaged<cef_media_sink_t*, cef_string_userfree*> _get_name;
        internal delegate* unmanaged<cef_media_sink_t*, CefMediaSinkIconType> _get_icon_type;
        internal delegate* unmanaged<cef_media_sink_t*, cef_media_sink_device_info_callback_t*, void> _get_device_info;
        internal delegate* unmanaged<cef_media_sink_t*, int> _is_cast_sink;
        internal delegate* unmanaged<cef_media_sink_t*, int> _is_dial_sink;
        internal delegate* unmanaged<cef_media_sink_t*, cef_media_source_t*, int> _is_compatible_with;
        
        // AddRef
        
        public static void add_ref(cef_media_sink_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_media_sink_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_media_sink_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_media_sink_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // GetId
        
        public static cef_string_userfree* get_id(cef_media_sink_t* self)
        {
            return self->_get_id(self);
        }
        
        // GetName
        
        public static cef_string_userfree* get_name(cef_media_sink_t* self)
        {
            return self->_get_name(self);
        }
        
        // GetIconType
        
        public static CefMediaSinkIconType get_icon_type(cef_media_sink_t* self)
        {
            return self->_get_icon_type(self);
        }
        
        // GetDeviceInfo
        
        public static void get_device_info(cef_media_sink_t* self, cef_media_sink_device_info_callback_t* callback)
        {
            self->_get_device_info(self, callback);
        }
        
        // IsCastSink
        
        public static int is_cast_sink(cef_media_sink_t* self)
        {
            return self->_is_cast_sink(self);
        }
        
        // IsDialSink
        
        public static int is_dial_sink(cef_media_sink_t* self)
        {
            return self->_is_dial_sink(self);
        }
        
        // IsCompatibleWith
        
        public static int is_compatible_with(cef_media_sink_t* self, cef_media_source_t* source)
        {
            return self->_is_compatible_with(self, source);
        }
        
    }
}