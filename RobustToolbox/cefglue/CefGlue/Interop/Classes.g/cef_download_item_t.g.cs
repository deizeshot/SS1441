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
    internal unsafe struct cef_download_item_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_download_item_t*, int> _is_valid;
        internal delegate* unmanaged<cef_download_item_t*, int> _is_in_progress;
        internal delegate* unmanaged<cef_download_item_t*, int> _is_complete;
        internal delegate* unmanaged<cef_download_item_t*, int> _is_canceled;
        internal delegate* unmanaged<cef_download_item_t*, int> _is_interrupted;
        internal delegate* unmanaged<cef_download_item_t*, CefDownloadInterruptReason> _get_interrupt_reason;
        internal delegate* unmanaged<cef_download_item_t*, long> _get_current_speed;
        internal delegate* unmanaged<cef_download_item_t*, int> _get_percent_complete;
        internal delegate* unmanaged<cef_download_item_t*, long> _get_total_bytes;
        internal delegate* unmanaged<cef_download_item_t*, long> _get_received_bytes;
        internal delegate* unmanaged<cef_download_item_t*, CefBaseTime> _get_start_time;
        internal delegate* unmanaged<cef_download_item_t*, CefBaseTime> _get_end_time;
        internal delegate* unmanaged<cef_download_item_t*, cef_string_userfree*> _get_full_path;
        internal delegate* unmanaged<cef_download_item_t*, uint> _get_id;
        internal delegate* unmanaged<cef_download_item_t*, cef_string_userfree*> _get_url;
        internal delegate* unmanaged<cef_download_item_t*, cef_string_userfree*> _get_original_url;
        internal delegate* unmanaged<cef_download_item_t*, cef_string_userfree*> _get_suggested_file_name;
        internal delegate* unmanaged<cef_download_item_t*, cef_string_userfree*> _get_content_disposition;
        internal delegate* unmanaged<cef_download_item_t*, cef_string_userfree*> _get_mime_type;
        
        // AddRef
        
        public static void add_ref(cef_download_item_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_download_item_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_download_item_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_download_item_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // IsValid
        
        public static int is_valid(cef_download_item_t* self)
        {
            return self->_is_valid(self);
        }
        
        // IsInProgress
        
        public static int is_in_progress(cef_download_item_t* self)
        {
            return self->_is_in_progress(self);
        }
        
        // IsComplete
        
        public static int is_complete(cef_download_item_t* self)
        {
            return self->_is_complete(self);
        }
        
        // IsCanceled
        
        public static int is_canceled(cef_download_item_t* self)
        {
            return self->_is_canceled(self);
        }
        
        // IsInterrupted
        
        public static int is_interrupted(cef_download_item_t* self)
        {
            return self->_is_interrupted(self);
        }
        
        // GetInterruptReason
        
        public static CefDownloadInterruptReason get_interrupt_reason(cef_download_item_t* self)
        {
            return self->_get_interrupt_reason(self);
        }
        
        // GetCurrentSpeed
        
        public static long get_current_speed(cef_download_item_t* self)
        {
            return self->_get_current_speed(self);
        }
        
        // GetPercentComplete
        
        public static int get_percent_complete(cef_download_item_t* self)
        {
            return self->_get_percent_complete(self);
        }
        
        // GetTotalBytes
        
        public static long get_total_bytes(cef_download_item_t* self)
        {
            return self->_get_total_bytes(self);
        }
        
        // GetReceivedBytes
        
        public static long get_received_bytes(cef_download_item_t* self)
        {
            return self->_get_received_bytes(self);
        }
        
        // GetStartTime
        
        public static CefBaseTime get_start_time(cef_download_item_t* self)
        {
            return self->_get_start_time(self);
        }
        
        // GetEndTime
        
        public static CefBaseTime get_end_time(cef_download_item_t* self)
        {
            return self->_get_end_time(self);
        }
        
        // GetFullPath
        
        public static cef_string_userfree* get_full_path(cef_download_item_t* self)
        {
            return self->_get_full_path(self);
        }
        
        // GetId
        
        public static uint get_id(cef_download_item_t* self)
        {
            return self->_get_id(self);
        }
        
        // GetURL
        
        public static cef_string_userfree* get_url(cef_download_item_t* self)
        {
            return self->_get_url(self);
        }
        
        // GetOriginalUrl
        
        public static cef_string_userfree* get_original_url(cef_download_item_t* self)
        {
            return self->_get_original_url(self);
        }
        
        // GetSuggestedFileName
        
        public static cef_string_userfree* get_suggested_file_name(cef_download_item_t* self)
        {
            return self->_get_suggested_file_name(self);
        }
        
        // GetContentDisposition
        
        public static cef_string_userfree* get_content_disposition(cef_download_item_t* self)
        {
            return self->_get_content_disposition(self);
        }
        
        // GetMimeType
        
        public static cef_string_userfree* get_mime_type(cef_download_item_t* self)
        {
            return self->_get_mime_type(self);
        }
        
    }
}