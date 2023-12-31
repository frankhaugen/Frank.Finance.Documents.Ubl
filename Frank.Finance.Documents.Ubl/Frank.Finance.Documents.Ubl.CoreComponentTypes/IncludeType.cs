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
    [XmlTypeAttribute("IncludeType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("Include", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class IncludeType
    {
        
        [XmlAttributeAttribute("URI")]
        public string Uri { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlAttributeAttribute("referencedData")]
        public bool ReferencedDataValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReferencedData-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReferencedData property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ReferencedDataValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<bool> ReferencedData
        {
            get
            {
                if (this.ReferencedDataValueSpecified)
                {
                    return this.ReferencedDataValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReferencedDataValue = value.GetValueOrDefault();
                this.ReferencedDataValueSpecified = value.HasValue;
            }
        }
    }
}
