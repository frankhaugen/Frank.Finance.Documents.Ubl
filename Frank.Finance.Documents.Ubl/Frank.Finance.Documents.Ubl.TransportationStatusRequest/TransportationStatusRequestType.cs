//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace Frank.Finance.Documents.Ubl.TransportationStatusRequest
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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Details</ccts:DictionaryEntryName><ccts:Definition>A document requesting a Transportation Status report.</ccts:Definition><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass></ccts:Component></para>
    /// <para>This element MUST be conveyed as the root element in any instance document based on this
    ///                Schema expression</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("TransportationStatusRequestType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:TransportationStatusRequest-2")]
    [XmlRootAttribute("TransportationStatusRequest", Namespace="urn:oasis:names:specification:ubl:schema:xsd:TransportationStatusRequest-2")]
    public partial class TransportationStatusRequestType
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. UBL Version Identifier.
        ///                                Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies the earliest version of the UBL 2 schema for this document type
        ///                                that defines all of the elements that might be encountered in the current instance.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>UBL Version Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>2.0.5</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UBLVersionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.UblVersionIdType UblVersionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Customization Identifier.
        ///                                Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined customization of UBL for a specific use.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Customization Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>NES</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CustomizationID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CustomizationIdType CustomizationId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Profile Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined profile of the customization of UBL being used.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Profile Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BasicProcurementProcess</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProfileID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ProfileIdType ProfileId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Profile Execution Identifier.
        ///                                Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies an instance of executing a profile, to associate all
        ///                                transactions in a collaboration.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Profile Execution Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BPP-1001</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProfileExecutionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ProfileExecutionIdType ProfileExecutionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An identifier for this document, assigned by the sender.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Carrier Assigned_ Identifier.
        ///                                Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A reference number assigned by a carrier or its agent to identify a
        ///                                specific shipment, such as a booking reference number when cargo space is reserved prior
        ///                                to loading.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Carrier Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CarrierAssignedID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CarrierAssignedIdType CarrierAssignedId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. UUID. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for an instance of this document.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UUID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Issue Date. Date
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The date, assigned by the sender, on which this document was issued.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Issue Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("IssueDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IssueDateType IssueDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Issue Time. Time
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The time, assigned by the sender, at which this document was issued.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Issue Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("IssueTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IssueTimeType IssueTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Name</ccts:DictionaryEntryName><ccts:Definition>Text, assigned by the sender, that identifies this document to business
        ///                                users.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Description. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A textual description of the document instance.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Note. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Free-form text pertinent to this document, conveying information that is
        ///                                not contained explicitly in other structures.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Shipping Order Identifier.
        ///                                Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A reference number for a shipping order.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Shipping Order Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ShippingOrderID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ShippingOrderIdType ShippingOrderId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Other_ Instruction. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An instruction regarding this message.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Other</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instruction</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OtherInstruction", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OtherInstructionType OtherInstruction { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Transportation Status Type Code.
        ///                                Code
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of status requested in a Transportation Status
        ///                                document.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Transportation Status Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportationStatusTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TransportationStatusTypeCodeType TransportationStatusTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Sender_ Party. Party
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The party sending this document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Sender</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SenderParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PartyType SenderParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Receiver_ Party. Party
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The party receiving this document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Receiver</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ReceiverParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PartyType ReceiverParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Transport Execution Plan_ Document
        ///                                Reference. Document Reference
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A reference to the Transport Execution Plan associated with the transport
        ///                                service for which status is requested.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Transport Execution Plan</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportExecutionPlanDocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.DocumentReferenceType TransportExecutionPlanDocumentReference { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.ConsignmentType> _consignment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Consignment
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A consignment regarding which status is requested.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Consignment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consignment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consignment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Consignment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.ConsignmentType> Consignment
        {
            get
            {
                return _consignment;
            }
            set
            {
                _consignment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Consignment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Consignment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ConsignmentSpecified
        {
            get
            {
                return ((this.Consignment != null) 
                            && (this.Consignment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.DocumentReferenceType> _documentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Document Reference
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A reference to another document associated with this document.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DocumentReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.DocumentReferenceType> DocumentReference
        {
            get
            {
                return _documentReference;
            }
            set
            {
                _documentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DocumentReferenceSpecified
        {
            get
            {
                return ((this.DocumentReference != null) 
                            && (this.DocumentReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.SignatureType> _signature;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Signature
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A signature applied to this document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTerm>Signature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Signature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Signature</ccts:RepresentationTerm></ccts:Component></para>
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
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.LocationType> _requestedStatusLocation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Requested Status_ Location.
        ///                                Location
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A location for which status is requested.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Requested Status</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequestedStatusLocation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.LocationType> RequestedStatusLocation
        {
            get
            {
                return _requestedStatusLocation;
            }
            set
            {
                _requestedStatusLocation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequestedStatusLocation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequestedStatusLocation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequestedStatusLocationSpecified
        {
            get
            {
                return ((this.RequestedStatusLocation != null) 
                            && (this.RequestedStatusLocation.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PeriodType> _requestedStatusPeriod;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Status Request. Requested Status_ Period. Period
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A period for which status is requested.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Status Request</ccts:ObjectClass><ccts:PropertyTermQualifier>Requested Status</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequestedStatusPeriod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PeriodType> RequestedStatusPeriod
        {
            get
            {
                return _requestedStatusPeriod;
            }
            set
            {
                _requestedStatusPeriod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequestedStatusPeriod-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequestedStatusPeriod collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequestedStatusPeriodSpecified
        {
            get
            {
                return ((this.RequestedStatusPeriod != null) 
                            && (this.RequestedStatusPeriod.Count != 0));
            }
        }
    }
}