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
    [XmlTypeAttribute("SignedDataObjectPropertiesType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("SignedDataObjectProperties", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignedDataObjectPropertiesType
    {
        
        [XmlIgnoreAttribute()]
        private List<DataObjectFormatType> _dataObjectFormat;
        
        [XmlElementAttribute("DataObjectFormat")]
        public List<DataObjectFormatType> DataObjectFormat
        {
            get
            {
                return _dataObjectFormat;
            }
            set
            {
                _dataObjectFormat = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DataObjectFormat-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DataObjectFormat collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DataObjectFormatSpecified
        {
            get
            {
                return ((this.DataObjectFormat != null) 
                            && (this.DataObjectFormat.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CommitmentTypeIndicationType> _commitmentTypeIndication;
        
        [XmlElementAttribute("CommitmentTypeIndication")]
        public List<CommitmentTypeIndicationType> CommitmentTypeIndication
        {
            get
            {
                return _commitmentTypeIndication;
            }
            set
            {
                _commitmentTypeIndication = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CommitmentTypeIndication-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CommitmentTypeIndication collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CommitmentTypeIndicationSpecified
        {
            get
            {
                return ((this.CommitmentTypeIndication != null) 
                            && (this.CommitmentTypeIndication.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<XAdEsTimeStampType> _allDataObjectsTimeStamp;
        
        [XmlElementAttribute("AllDataObjectsTimeStamp")]
        public List<XAdEsTimeStampType> AllDataObjectsTimeStamp
        {
            get
            {
                return _allDataObjectsTimeStamp;
            }
            set
            {
                _allDataObjectsTimeStamp = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AllDataObjectsTimeStamp-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AllDataObjectsTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AllDataObjectsTimeStampSpecified
        {
            get
            {
                return ((this.AllDataObjectsTimeStamp != null) 
                            && (this.AllDataObjectsTimeStamp.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<XAdEsTimeStampType> _individualDataObjectsTimeStamp;
        
        [XmlElementAttribute("IndividualDataObjectsTimeStamp")]
        public List<XAdEsTimeStampType> IndividualDataObjectsTimeStamp
        {
            get
            {
                return _individualDataObjectsTimeStamp;
            }
            set
            {
                _individualDataObjectsTimeStamp = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die IndividualDataObjectsTimeStamp-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the IndividualDataObjectsTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IndividualDataObjectsTimeStampSpecified
        {
            get
            {
                return ((this.IndividualDataObjectsTimeStamp != null) 
                            && (this.IndividualDataObjectsTimeStamp.Count != 0));
            }
        }
        
        [XmlAttributeAttribute("Id")]
        public string Id { get; set; }
    }
}
