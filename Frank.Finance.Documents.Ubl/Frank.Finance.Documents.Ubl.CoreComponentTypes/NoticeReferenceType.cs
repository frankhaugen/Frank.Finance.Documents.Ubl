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
    [XmlTypeAttribute("NoticeReferenceType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class NoticeReferenceType
    {
        
        [XmlElementAttribute("Organization")]
        public string Organization { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<int> _noticeNumbers;
        
        [XmlArrayAttribute("NoticeNumbers")]
        [XmlArrayItemAttribute("int", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<int> NoticeNumbers
        {
            get
            {
                return _noticeNumbers;
            }
            set
            {
                _noticeNumbers = value;
            }
        }
    }
}
