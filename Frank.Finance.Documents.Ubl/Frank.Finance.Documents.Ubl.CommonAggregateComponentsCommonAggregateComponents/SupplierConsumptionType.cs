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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Supplier Consumption. Details</ccts:DictionaryEntryName><ccts:Definition>The consumption in case the consumption is for one and only one supplier.
    ///                    </ccts:Definition><ccts:ObjectClass>Supplier Consumption</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("SupplierConsumptionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("SupplierConsumption", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SupplierConsumptionType
    {
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Supplier Consumption. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in
        ///                                other structures.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Supplier Consumption</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>This is what you pay for electricity to DONG Energy North Utility
        ///                            </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DescriptionType> Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Description-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return ((this.Description != null) 
                            && (this.Description.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Supplier Consumption. Utility Supplier_ Party. Party
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The party supplying the utility.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Supplier Consumption</ccts:ObjectClass><ccts:PropertyTermQualifier>Utility Supplier</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UtilitySupplierParty")]
        public PartyType UtilitySupplierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Supplier Consumption. Utility Customer_ Party. Party
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The utility customer.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Supplier Consumption</ccts:ObjectClass><ccts:PropertyTermQualifier>Utility Customer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UtilityCustomerParty")]
        public PartyType UtilityCustomerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Supplier Consumption. Consumption</ccts:DictionaryEntryName><ccts:Definition>The consumption regarding this supplier</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Supplier Consumption</ccts:ObjectClass><ccts:PropertyTerm>Consumption</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consumption</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consumption</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Consumption")]
        public ConsumptionType Consumption { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Supplier Consumption. Contract</ccts:DictionaryEntryName><ccts:Definition>A contract setting forth conditions regulating the consumption.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Supplier Consumption</ccts:ObjectClass><ccts:PropertyTerm>Contract</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contract</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contract</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Contract")]
        public ContractType Contract { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ConsumptionLineType> _consumptionLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Supplier Consumption. Consumption Line</ccts:DictionaryEntryName><ccts:Definition>The consumption of a utility product.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Supplier Consumption</ccts:ObjectClass><ccts:PropertyTerm>Consumption Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consumption Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consumption Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ConsumptionLine")]
        public List<ConsumptionLineType> ConsumptionLine
        {
            get
            {
                return _consumptionLine;
            }
            set
            {
                _consumptionLine = value;
            }
        }
    }
}