//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace Frank.Finance.Documents.Ubl.CommonExtensionComponentsCommonExtensionComponents
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("ExtensionContentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlRootAttribute("ExtensionContent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionContentType
    {
        
        /// <summary>
        /// <para>Any element in any namespace other than the UBL extension
        ///                        namespace is allowed to be the apex element of an extension.
        ///                        Only those elements found in the UBL schemas and in the
        ///                        trees of schemas imported in this module are validated.
        ///                        Any element for which there is no schema declaration in any
        ///                        of the trees of schemas passes validation and is not
        ///                        treated as a schema constraint violation.</para>
        /// </summary>
        [XmlAnyElementAttribute()]
        public XmlElement Any { get; set; }
    }
}
