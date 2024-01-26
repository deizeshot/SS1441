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
    internal unsafe struct cef_domnode_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_domnode_t*, CefDomNodeType> _get_type;
        internal delegate* unmanaged<cef_domnode_t*, int> _is_text;
        internal delegate* unmanaged<cef_domnode_t*, int> _is_element;
        internal delegate* unmanaged<cef_domnode_t*, int> _is_editable;
        internal delegate* unmanaged<cef_domnode_t*, int> _is_form_control_element;
        internal delegate* unmanaged<cef_domnode_t*, CefDomFormControlType> _get_form_control_element_type;
        internal delegate* unmanaged<cef_domnode_t*, cef_domnode_t*, int> _is_same;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_userfree*> _get_name;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_userfree*> _get_value;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_t*, int> _set_value;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_userfree*> _get_as_markup;
        internal delegate* unmanaged<cef_domnode_t*, cef_domdocument_t*> _get_document;
        internal delegate* unmanaged<cef_domnode_t*, cef_domnode_t*> _get_parent;
        internal delegate* unmanaged<cef_domnode_t*, cef_domnode_t*> _get_previous_sibling;
        internal delegate* unmanaged<cef_domnode_t*, cef_domnode_t*> _get_next_sibling;
        internal delegate* unmanaged<cef_domnode_t*, int> _has_children;
        internal delegate* unmanaged<cef_domnode_t*, cef_domnode_t*> _get_first_child;
        internal delegate* unmanaged<cef_domnode_t*, cef_domnode_t*> _get_last_child;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_userfree*> _get_element_tag_name;
        internal delegate* unmanaged<cef_domnode_t*, int> _has_element_attributes;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_t*, int> _has_element_attribute;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_t*, cef_string_userfree*> _get_element_attribute;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_map*, void> _get_element_attributes;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_t*, cef_string_t*, int> _set_element_attribute;
        internal delegate* unmanaged<cef_domnode_t*, cef_string_userfree*> _get_element_inner_text;
        internal delegate* unmanaged<cef_domnode_t*, cef_rect_t> _get_element_bounds;
        
        // AddRef
        
        public static void add_ref(cef_domnode_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_domnode_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_domnode_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_domnode_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // GetType
        
        public static CefDomNodeType get_type(cef_domnode_t* self)
        {
            return self->_get_type(self);
        }
        
        // IsText
        
        public static int is_text(cef_domnode_t* self)
        {
            return self->_is_text(self);
        }
        
        // IsElement
        
        public static int is_element(cef_domnode_t* self)
        {
            return self->_is_element(self);
        }
        
        // IsEditable
        
        public static int is_editable(cef_domnode_t* self)
        {
            return self->_is_editable(self);
        }
        
        // IsFormControlElement
        
        public static int is_form_control_element(cef_domnode_t* self)
        {
            return self->_is_form_control_element(self);
        }
        
        // GetFormControlElementType
        
        public static CefDomFormControlType get_form_control_element_type(cef_domnode_t* self)
        {
            return self->_get_form_control_element_type(self);
        }
        
        // IsSame
        
        public static int is_same(cef_domnode_t* self, cef_domnode_t* that)
        {
            return self->_is_same(self, that);
        }
        
        // GetName
        
        public static cef_string_userfree* get_name(cef_domnode_t* self)
        {
            return self->_get_name(self);
        }
        
        // GetValue
        
        public static cef_string_userfree* get_value(cef_domnode_t* self)
        {
            return self->_get_value(self);
        }
        
        // SetValue
        
        public static int set_value(cef_domnode_t* self, cef_string_t* value)
        {
            return self->_set_value(self, value);
        }
        
        // GetAsMarkup
        
        public static cef_string_userfree* get_as_markup(cef_domnode_t* self)
        {
            return self->_get_as_markup(self);
        }
        
        // GetDocument
        
        public static cef_domdocument_t* get_document(cef_domnode_t* self)
        {
            return self->_get_document(self);
        }
        
        // GetParent
        
        public static cef_domnode_t* get_parent(cef_domnode_t* self)
        {
            return self->_get_parent(self);
        }
        
        // GetPreviousSibling
        
        public static cef_domnode_t* get_previous_sibling(cef_domnode_t* self)
        {
            return self->_get_previous_sibling(self);
        }
        
        // GetNextSibling
        
        public static cef_domnode_t* get_next_sibling(cef_domnode_t* self)
        {
            return self->_get_next_sibling(self);
        }
        
        // HasChildren
        
        public static int has_children(cef_domnode_t* self)
        {
            return self->_has_children(self);
        }
        
        // GetFirstChild
        
        public static cef_domnode_t* get_first_child(cef_domnode_t* self)
        {
            return self->_get_first_child(self);
        }
        
        // GetLastChild
        
        public static cef_domnode_t* get_last_child(cef_domnode_t* self)
        {
            return self->_get_last_child(self);
        }
        
        // GetElementTagName
        
        public static cef_string_userfree* get_element_tag_name(cef_domnode_t* self)
        {
            return self->_get_element_tag_name(self);
        }
        
        // HasElementAttributes
        
        public static int has_element_attributes(cef_domnode_t* self)
        {
            return self->_has_element_attributes(self);
        }
        
        // HasElementAttribute
        
        public static int has_element_attribute(cef_domnode_t* self, cef_string_t* attrName)
        {
            return self->_has_element_attribute(self, attrName);
        }
        
        // GetElementAttribute
        
        public static cef_string_userfree* get_element_attribute(cef_domnode_t* self, cef_string_t* attrName)
        {
            return self->_get_element_attribute(self, attrName);
        }
        
        // GetElementAttributes
        
        public static void get_element_attributes(cef_domnode_t* self, cef_string_map* attrMap)
        {
            self->_get_element_attributes(self, attrMap);
        }
        
        // SetElementAttribute
        
        public static int set_element_attribute(cef_domnode_t* self, cef_string_t* attrName, cef_string_t* value)
        {
            return self->_set_element_attribute(self, attrName, value);
        }
        
        // GetElementInnerText
        
        public static cef_string_userfree* get_element_inner_text(cef_domnode_t* self)
        {
            return self->_get_element_inner_text(self);
        }
        
        // GetElementBounds
        
        public static cef_rect_t get_element_bounds(cef_domnode_t* self)
        {
            return self->_get_element_bounds(self);
        }
        
    }
}
