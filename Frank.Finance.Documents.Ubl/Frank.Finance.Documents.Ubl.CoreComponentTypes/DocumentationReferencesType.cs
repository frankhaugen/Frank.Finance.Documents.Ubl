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
    [XmlTypeAttribute("DocumentationReferencesType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class DocumentationReferencesType
    {
        
        [XmlIgnoreAttribute()]
        private List<string> _documentationReference;
        
        [XmlElementAttribute("DocumentationReference")]
        public List<string> DocumentationReference
        {
            get
            {
                return _documentationReference;
            }
            set
            {
                _documentationReference = value;
            }
        }
    }
}
