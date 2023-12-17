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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Result Of Verification. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the result of an attempt to verify a signature.
    ///                    </ccts:Definition><ccts:ObjectClass>Result Of Verification</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("ResultOfVerificationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("ResultOfVerification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ResultOfVerificationType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Result Of Verification. Validator. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An identifier for the organization, person, service, or server that
        ///                                verified the signature.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Result Of Verification</ccts:ObjectClass><ccts:PropertyTerm>Validator</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValidatorID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValidatorIdType ValidatorId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Result Of Verification. Validation_ Result Code. Code
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A code signifying the result of the verification.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Result Of Verification</ccts:ObjectClass><ccts:PropertyTermQualifier>Validation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Result Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValidationResultCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValidationResultCodeType ValidationResultCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Result Of Verification. Validation Date. Date
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The date upon which verification took place.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Result Of Verification</ccts:ObjectClass><ccts:PropertyTerm>Validation Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValidationDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValidationDateType ValidationDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Result Of Verification. Validation Time. Time
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The time at which verification took place.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Result Of Verification</ccts:ObjectClass><ccts:PropertyTerm>Validation Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValidationTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValidationTimeType ValidationTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Result Of Verification. Validate_ Process. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The verification process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Result Of Verification</ccts:ObjectClass><ccts:PropertyTermQualifier>Validate</ccts:PropertyTermQualifier><ccts:PropertyTerm>Process</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValidateProcess", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValidateProcessType ValidateProcess { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Result Of Verification. Validate_ Tool. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The tool used to verify the signature.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Result Of Verification</ccts:ObjectClass><ccts:PropertyTermQualifier>Validate</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tool</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValidateTool", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValidateToolType ValidateTool { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Result Of Verification. Validate_ Tool Version. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The version of the tool used to verify the signature.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Result Of Verification</ccts:ObjectClass><ccts:PropertyTermQualifier>Validate</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tool Version</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValidateToolVersion", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValidateToolVersionType ValidateToolVersion { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Result Of Verification. Signatory_ Party. Party
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The signing party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Result Of Verification</ccts:ObjectClass><ccts:PropertyTermQualifier>Signatory</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SignatoryParty")]
        public PartyType SignatoryParty { get; set; }
    }
}
