//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Contract Extension. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe possible extensions to a contract.</ccts:Definition><ccts:ObjectClass>Contract Extension</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("ContractExtensionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("ContractExtension", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ContractExtensionType
    {
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OptionsDescriptionType> _optionsDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Contract Extension. Options Description. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A description for the possible options that can be carried out during the
        ///                                execution of the contract.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Contract Extension</ccts:ObjectClass><ccts:PropertyTerm>Options Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OptionsDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OptionsDescriptionType> OptionsDescription
        {
            get
            {
                return _optionsDescription;
            }
            set
            {
                _optionsDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OptionsDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OptionsDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OptionsDescriptionSpecified
        {
            get
            {
                return ((this.OptionsDescription != null) 
                            && (this.OptionsDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Contract Extension. Minimum_ Number. Numeric
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The fixed minimum number of contract extensions or renewals.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Contract Extension</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Number</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MinimumNumberNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MinimumNumberNumericType MinimumNumberNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Contract Extension. Maximum_ Number. Numeric
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The maximum allowed number of contract extensions.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Contract Extension</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Number</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MaximumNumberNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MaximumNumberNumericType MaximumNumberNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Contract Extension. Option Validity_ Period. Period
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The period during which the option for extending the contract is
        ///                                available.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Contract Extension</ccts:ObjectClass><ccts:PropertyTermQualifier>Option Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OptionValidityPeriod")]
        public PeriodType OptionValidityPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<RenewalType> _renewal;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Contract Extension. Renewal</ccts:DictionaryEntryName><ccts:Definition>The period allowed for each contract extension.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Contract Extension</ccts:ObjectClass><ccts:PropertyTerm>Renewal</ccts:PropertyTerm><ccts:AssociatedObjectClass>Renewal</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Renewal</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Renewal")]
        public List<RenewalType> Renewal
        {
            get
            {
                return _renewal;
            }
            set
            {
                _renewal = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Renewal-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Renewal collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RenewalSpecified
        {
            get
            {
                return ((this.Renewal != null) 
                            && (this.Renewal.Count != 0));
            }
        }
    }
}