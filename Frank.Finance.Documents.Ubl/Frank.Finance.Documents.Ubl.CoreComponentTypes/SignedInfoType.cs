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
    [XmlTypeAttribute("SignedInfoType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("SignedInfo", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {
        
        [XmlElementAttribute("CanonicalizationMethod")]
        public CanonicalizationMethodType CanonicalizationMethod { get; set; }
        
        [XmlElementAttribute("SignatureMethod")]
        public SignatureMethodType SignatureMethod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ReferenceType> _reference;
        
        [XmlElementAttribute("Reference")]
        public List<ReferenceType> Reference
        {
            get
            {
                return _reference;
            }
            set
            {
                _reference = value;
            }
        }
        
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}