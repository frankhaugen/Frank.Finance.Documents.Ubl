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
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("ProcurementProjectLotType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(InterestedProcurementProjectLot))]
    [XmlIncludeAttribute(typeof(ProcurementProjectLot))]
    public partial class ProcurementProjectLotType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project Lot. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this procurement project lot.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Procurement Project Lot</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project Lot. Tendering Terms
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Tendering terms for this procurement project lot.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project Lot</ccts:ObjectClass><ccts:PropertyTerm>Tendering Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tendering Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tendering Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TenderingTerms")]
        public TenderingTermsType TenderingTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project Lot. Procurement Project
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A description of the procurement project to be divided.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project Lot</ccts:ObjectClass><ccts:PropertyTerm>Procurement Project</ccts:PropertyTerm><ccts:AssociatedObjectClass>Procurement Project</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Procurement Project</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProcurementProject")]
        public ProcurementProjectType ProcurementProject { get; set; }
    }
}
