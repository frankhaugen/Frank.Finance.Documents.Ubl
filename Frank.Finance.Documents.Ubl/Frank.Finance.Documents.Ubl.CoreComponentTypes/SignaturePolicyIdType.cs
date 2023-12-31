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
    [XmlTypeAttribute("SignaturePolicyIdType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignaturePolicyIdType
    {
        
        [XmlElementAttribute("SigPolicyId")]
        public ObjectIdentifierType SigPolicyId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CoreComponentTypes.TransformType> _transforms;
        
        [XmlArrayAttribute("Transforms", Namespace="http://www.w3.org/2000/09/xmldsig#")]
        [XmlArrayItemAttribute("Transform", Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public List<Frank.Finance.Documents.Ubl.CoreComponentTypes.TransformType> Transforms
        {
            get
            {
                return _transforms;
            }
            set
            {
                _transforms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Transforms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Transforms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransformsSpecified
        {
            get
            {
                return ((this.Transforms != null) 
                            && (this.Transforms.Count != 0));
            }
        }
        
        [XmlElementAttribute("SigPolicyHash")]
        public DigestAlgAndValueType SigPolicyHash { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _sigPolicyQualifiers;
        
        [XmlArrayAttribute("SigPolicyQualifiers")]
        [XmlArrayItemAttribute("SigPolicyQualifier", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<AnyType> SigPolicyQualifiers
        {
            get
            {
                return _sigPolicyQualifiers;
            }
            set
            {
                _sigPolicyQualifiers = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SigPolicyQualifiers-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SigPolicyQualifiers collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SigPolicyQualifiersSpecified
        {
            get
            {
                return ((this.SigPolicyQualifiers != null) 
                            && (this.SigPolicyQualifiers.Count != 0));
            }
        }
    }
}
