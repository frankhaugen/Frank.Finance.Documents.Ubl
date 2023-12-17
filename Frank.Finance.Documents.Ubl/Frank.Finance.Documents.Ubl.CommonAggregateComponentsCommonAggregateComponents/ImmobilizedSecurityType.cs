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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Immobilized Security. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe an immobilized security to be used as a guarantee.
    ///                    </ccts:Definition><ccts:ObjectClass>Immobilized Security</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("ImmobilizedSecurityType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("ImmobilizedSecurity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ImmobilizedSecurityType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Immobilized Security. Immobilization Certificate Identifier.
        ///                                Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An identifier for the certificate of this immobilized security.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Immobilized Security</ccts:ObjectClass><ccts:PropertyTerm>Immobilization Certificate Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ImmobilizationCertificateID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ImmobilizationCertificateIdType ImmobilizationCertificateId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Immobilized Security. Security Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An identifier for the security being immobilized.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Immobilized Security</ccts:ObjectClass><ccts:PropertyTerm>Security Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SecurityID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.SecurityIdType SecurityId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Immobilized Security. Issue Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which this immobilized security was issued.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Immobilized Security</ccts:ObjectClass><ccts:PropertyTerm>Issue Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("IssueDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IssueDateType IssueDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Immobilized Security. Face Value. Amount
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The value of the security on the day it was immobilized.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Immobilized Security</ccts:ObjectClass><ccts:PropertyTerm>Face Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("FaceValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FaceValueAmountType FaceValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Immobilized Security. Market Value. Amount
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The current market value of the immobilized security.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Immobilized Security</ccts:ObjectClass><ccts:PropertyTerm>Market Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MarketValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MarketValueAmountType MarketValueAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Immobilized Security. Shares Number. Quantity
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The number of shares immobilized.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Immobilized Security</ccts:ObjectClass><ccts:PropertyTerm>Shares Number</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SharesNumberQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.SharesNumberQuantityType SharesNumberQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Immobilized Security. Issuer_ Party. Party
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The party issuing the immobilized security certificate.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Immobilized Security</ccts:ObjectClass><ccts:PropertyTermQualifier>Issuer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("IssuerParty")]
        public PartyType IssuerParty { get; set; }
    }
}
