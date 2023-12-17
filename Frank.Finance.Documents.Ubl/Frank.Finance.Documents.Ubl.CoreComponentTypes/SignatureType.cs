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
    [XmlTypeAttribute("SignatureType", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureType
    {
        
        [XmlElementAttribute("SignedInfo")]
        public SignedInfoType SignedInfo { get; set; }
        
        [XmlElementAttribute("SignatureValue")]
        public SignatureValueType SignatureValue { get; set; }
        
        [XmlElementAttribute("KeyInfo")]
        public KeyInfoType KeyInfo { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ObjectType> _object;
        
        [XmlElementAttribute("Object")]
        public List<ObjectType> Object
        {
            get
            {
                return _object;
            }
            set
            {
                _object = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Object-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Object collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ObjectSpecified
        {
            get
            {
                return ((this.Object != null) 
                            && (this.Object.Count != 0));
            }
        }
        
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
