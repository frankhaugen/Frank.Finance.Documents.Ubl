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
    [XmlTypeAttribute("CRLIdentifierType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CrlIdentifierType
    {
        
        [XmlElementAttribute("Issuer")]
        public string Issuer { get; set; }
        
        [XmlElementAttribute("IssueTime", DataType="dateTime")]
        public DateTime IssueTime { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [XmlElementAttribute("Number")]
        public int NumberValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Number-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Number property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NumberValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public Nullable<int> Number
        {
            get
            {
                if (this.NumberValueSpecified)
                {
                    return this.NumberValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NumberValue = value.GetValueOrDefault();
                this.NumberValueSpecified = value.HasValue;
            }
        }
        
        [XmlAttributeAttribute("URI")]
        public string Uri { get; set; }
    }
}
