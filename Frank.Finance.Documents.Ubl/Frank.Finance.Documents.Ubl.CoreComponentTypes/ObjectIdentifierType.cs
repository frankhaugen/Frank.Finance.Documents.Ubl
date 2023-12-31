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
    [XmlTypeAttribute("ObjectIdentifierType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("ObjectIdentifier", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class ObjectIdentifierType
    {
        
        [XmlElementAttribute("Identifier")]
        public IdentifierType Identifier { get; set; }
        
        [XmlElementAttribute("Description")]
        public string Description { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<string> _documentationReferences;
        
        [XmlArrayAttribute("DocumentationReferences")]
        [XmlArrayItemAttribute("DocumentationReference", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<string> DocumentationReferences
        {
            get
            {
                return _documentationReferences;
            }
            set
            {
                _documentationReferences = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DocumentationReferences-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentationReferences collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DocumentationReferencesSpecified
        {
            get
            {
                return ((this.DocumentationReferences != null) 
                            && (this.DocumentationReferences.Count != 0));
            }
        }
    }
}
