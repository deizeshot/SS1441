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
    internal unsafe struct cef_x509certificate_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_x509certificate_t*, cef_x509cert_principal_t*> _get_subject;
        internal delegate* unmanaged<cef_x509certificate_t*, cef_x509cert_principal_t*> _get_issuer;
        internal delegate* unmanaged<cef_x509certificate_t*, cef_binary_value_t*> _get_serial_number;
        internal delegate* unmanaged<cef_x509certificate_t*, CefBaseTime> _get_valid_start;
        internal delegate* unmanaged<cef_x509certificate_t*, CefBaseTime> _get_valid_expiry;
        internal delegate* unmanaged<cef_x509certificate_t*, cef_binary_value_t*> _get_derencoded;
        internal delegate* unmanaged<cef_x509certificate_t*, cef_binary_value_t*> _get_pemencoded;
        internal delegate* unmanaged<cef_x509certificate_t*, UIntPtr> _get_issuer_chain_size;
        internal delegate* unmanaged<cef_x509certificate_t*, UIntPtr*, cef_binary_value_t**, void> _get_derencoded_issuer_chain;
        internal delegate* unmanaged<cef_x509certificate_t*, UIntPtr*, cef_binary_value_t**, void> _get_pemencoded_issuer_chain;
        
        // AddRef
        
        public static void add_ref(cef_x509certificate_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_x509certificate_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_x509certificate_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_x509certificate_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // GetSubject
        
        public static cef_x509cert_principal_t* get_subject(cef_x509certificate_t* self)
        {
            return self->_get_subject(self);
        }
        
        // GetIssuer
        
        public static cef_x509cert_principal_t* get_issuer(cef_x509certificate_t* self)
        {
            return self->_get_issuer(self);
        }
        
        // GetSerialNumber
        
        public static cef_binary_value_t* get_serial_number(cef_x509certificate_t* self)
        {
            return self->_get_serial_number(self);
        }
        
        // GetValidStart
        
        public static CefBaseTime get_valid_start(cef_x509certificate_t* self)
        {
            return self->_get_valid_start(self);
        }
        
        // GetValidExpiry
        
        public static CefBaseTime get_valid_expiry(cef_x509certificate_t* self)
        {
            return self->_get_valid_expiry(self);
        }
        
        // GetDEREncoded
        
        public static cef_binary_value_t* get_derencoded(cef_x509certificate_t* self)
        {
            return self->_get_derencoded(self);
        }
        
        // GetPEMEncoded
        
        public static cef_binary_value_t* get_pemencoded(cef_x509certificate_t* self)
        {
            return self->_get_pemencoded(self);
        }
        
        // GetIssuerChainSize
        
        public static UIntPtr get_issuer_chain_size(cef_x509certificate_t* self)
        {
            return self->_get_issuer_chain_size(self);
        }
        
        // GetDEREncodedIssuerChain
        
        public static void get_derencoded_issuer_chain(cef_x509certificate_t* self, UIntPtr* chainCount, cef_binary_value_t** chain)
        {
            self->_get_derencoded_issuer_chain(self, chainCount, chain);
        }
        
        // GetPEMEncodedIssuerChain
        
        public static void get_pemencoded_issuer_chain(cef_x509certificate_t* self, UIntPtr* chainCount, cef_binary_value_t** chain)
        {
            self->_get_pemencoded_issuer_chain(self, chainCount, chain);
        }
        
    }
}