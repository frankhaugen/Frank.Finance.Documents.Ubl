//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace Frank.Finance.Documents.Ubl.CoreComponentTypes
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
    [XmlTypeAttribute("RSAKeyValueType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("RSAKeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class RsaKeyValueType
    {
        
        [XmlElementAttribute("Modulus", DataType="base64Binary")]
        public Byte[] Modulus { get; set; }
        
        [XmlElementAttribute("Exponent", DataType="base64Binary")]
        public Byte[] Exponent { get; set; }
    }
}
