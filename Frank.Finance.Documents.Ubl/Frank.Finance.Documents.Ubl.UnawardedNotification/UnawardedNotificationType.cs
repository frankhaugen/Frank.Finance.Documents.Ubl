//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace Frank.Finance.Documents.Ubl.UnawardedNotification
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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Details</ccts:DictionaryEntryName><ccts:Definition>A document communicating to a tenderer that the contract has been awarded to
    ///                        different tenderer.
    ///                    </ccts:Definition><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass></ccts:Component></para>
    /// <para>This element MUST be conveyed as the root element in any instance document based on this
    ///                Schema expression</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("UnawardedNotificationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnawardedNotification-2")]
    [XmlRootAttribute("UnawardedNotification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnawardedNotification-2")]
    public partial class UnawardedNotificationType
    {
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonExtensionComponentsCommonExtensionComponents.UblExtensionType> _ublExtensions;
        
        /// <summary>
        /// <para>A container for all extensions present in the document.</para>
        /// </summary>
        [XmlArrayAttribute("UBLExtensions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [XmlArrayItemAttribute("UBLExtension", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonExtensionComponentsCommonExtensionComponents.UblExtensionType> UblExtensions
        {
            get
            {
                return _ublExtensions;
            }
            set
            {
                _ublExtensions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die UblExtensions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the UblExtensions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool UblExtensionsSpecified
        {
            get
            {
                return ((this.UblExtensions != null) 
                            && (this.UblExtensions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. UBL Version Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies the earliest version of the UBL 2 schema for this document type
        ///                                that defines all of the elements that might be encountered in the current instance.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>UBL Version Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>2.0.5</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UBLVersionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.UblVersionIdType UblVersionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Customization Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined customization of UBL for a specific use.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Customization Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>NES</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CustomizationID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CustomizationIdType CustomizationId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Profile Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined profile of the customization of UBL being used.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Profile Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BasicProcurementProcess</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProfileID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ProfileIdType ProfileId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Profile Execution Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies an instance of executing a profile, to associate all
        ///                                transactions in a collaboration.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Profile Execution Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BPP-1001</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProfileExecutionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ProfileExecutionIdType ProfileExecutionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this document, assigned by the sender.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Copy_ Indicator. Indicator
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Indicates whether this document is a copy (true) or not (false).
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTermQualifier>Copy</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CopyIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CopyIndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. UUID. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for an instance of this document.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UUID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Contract Folder Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An identifier, assigned by the sender, for the process file (i.e., record)
        ///                                to which this document belongs.
        ///                            </ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Contract Folder Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContractFolderID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ContractFolderIdType ContractFolderId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Issue Date. Date
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The date, assigned by the sender, on which this document was issued.
        ///                            </ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Issue Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("IssueDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IssueDateType IssueDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Issue Time. Time
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The time, assigned by the sender, at which this document was issued.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Issue Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("IssueTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IssueTimeType IssueTime { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ContractNameType> _contractName;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Contract Name. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The name, expressed as text, of this procurement project.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Contract Name</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContractName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ContractNameType> ContractName
        {
            get
            {
                return _contractName;
            }
            set
            {
                _contractName = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContractName-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContractName collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContractNameSpecified
        {
            get
            {
                return ((this.ContractName != null) 
                            && (this.ContractName.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text pertinent to this document, conveying information that is
        ///                                not contained explicitly in other structures.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NoteType> Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Note-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Note collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NoteSpecified
        {
            get
            {
                return ((this.Note != null) 
                            && (this.Note.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.SignatureType> _signature;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Signature</ccts:DictionaryEntryName><ccts:Definition>A signature applied to this document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Signature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Signature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Signature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Signature", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.SignatureType> Signature
        {
            get
            {
                return _signature;
            }
            set
            {
                _signature = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Signature-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Signature collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SignatureSpecified
        {
            get
            {
                return ((this.Signature != null) 
                            && (this.Signature.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Sender_ Party. Party
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The party sending this document.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTermQualifier>Sender</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SenderParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PartyType SenderParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Receiver_ Party. Party
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The party receiving this document.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTermQualifier>Receiver</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ReceiverParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PartyType ReceiverParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Minutes_ Document Reference. Document
        ///                                Reference
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A reference to a set of minutes associated with this award.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTermQualifier>Minutes</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MinutesDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.DocumentReferenceType MinutesDocumentReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.DocumentReferenceType> _additionalDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Additional_ Document Reference. Document
        ///                                Reference
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A reference to an additional document associated with this document. It can
        ///                                be used to include annex documents such as the minutes of the awarding process meetings.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.DocumentReferenceType> AdditionalDocumentReference
        {
            get
            {
                return _additionalDocumentReference;
            }
            set
            {
                _additionalDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalDocumentReferenceSpecified
        {
            get
            {
                return ((this.AdditionalDocumentReference != null) 
                            && (this.AdditionalDocumentReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.TenderResultType> _tenderResult;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Tender Result</ccts:DictionaryEntryName><ccts:Definition>An association to the Tender Result being notified</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Tender Result</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tender Result</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tender Result</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TenderResult", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.TenderResultType> TenderResult
        {
            get
            {
                return _tenderResult;
            }
            set
            {
                _tenderResult = value;
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Unawarded Notification. Appeal Terms</ccts:DictionaryEntryName><ccts:Definition>Terms of appeal for this tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Unawarded Notification</ccts:ObjectClass><ccts:PropertyTerm>Appeal Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Appeal Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Appeal Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AppealTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.AppealTermsType AppealTerms { get; set; }
    }
}