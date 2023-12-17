//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace Frank.Finance.Documents.Ubl.BillOfLading
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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Details</ccts:DictionaryEntryName><ccts:Definition>A document issued by the party who acts as an agent for a transportation carrier or
    ///                        other agents to the party who gives instructions for the transportation services (shipper,
    ///                        consignor, etc.) stating the details of the transportation, charges, and terms and conditions
    ///                        under which the transportation service is provided. The party issuing this document does not
    ///                        necessarily provide the physical transportation service. The information in the Bill of Lading
    ///                        corresponds to the information on the Forwarding Instructions. It is used for any mode of
    ///                        transport. A Bill of Lading can serve as a contractual document between the parties for the
    ///                        transportation service. The document evidences a contract of carriage by sea and the acceptance
    ///                        of responsibility for the goods by the carrier, by which the carrier undertakes to deliver the
    ///                        goods against surrender of the document. A provision in the document that the goods are to be
    ///                        delivered to the order of a named person, or to order, or to bearer, constitutes such an
    ///                        undertaking.
    ///                    </ccts:Definition><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:AlternativeBusinessTerms>House Bill of Landing, Master Bill, Bill
    ///                    </ccts:AlternativeBusinessTerms></ccts:Component></para>
    /// <para>This element MUST be conveyed as the root element in any instance document based on this
    ///                Schema expression</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("BillOfLadingType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:BillOfLading-2")]
    [XmlRootAttribute("BillOfLading", Namespace="urn:oasis:names:specification:ubl:schema:xsd:BillOfLading-2")]
    public partial class BillOfLadingType
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. UBL Version Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies the earliest version of the UBL 2 schema for this document type
        ///                                that defines all of the elements that might be encountered in the current instance.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>UBL Version Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>2.0.5</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UBLVersionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.UblVersionIdType UblVersionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Customization Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined customization of UBL for a specific use.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Customization Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>NES</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CustomizationID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CustomizationIdType CustomizationId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Profile Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined profile of the customization of UBL being used.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Profile Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BasicProcurementProcess</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProfileID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ProfileIdType ProfileId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Profile Execution Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Identifies an instance of executing a profile, to associate all
        ///                                transactions in a collaboration.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Profile Execution Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BPP-1001</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProfileExecutionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ProfileExecutionIdType ProfileExecutionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this document, assigned by the sender.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Bill of Lading Number</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Carrier Assigned_ Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Reference number (such as a booking reference number) assigned by a carrier
        ///                                or its agent to identify a specific shipment when cargo space is reserved prior to
        ///                                loading.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTermQualifier>Carrier Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Booking Reference Number</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CarrierAssignedID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CarrierAssignedIdType CarrierAssignedId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for an instance of this document.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UUID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Issue Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date, assigned by the sender, on which this document was issued.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Issue Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Transport Document Date</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("IssueDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IssueDateType IssueDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Issue Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time, assigned by the sender, at which this document was issued.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Issue Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("IssueTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IssueTimeType IssueTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Name</ccts:DictionaryEntryName><ccts:Definition>Text, assigned by the sender, that identifies this document to business
        ///                                users.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>House Bill , Consolidated Bill of Lading , Proforma , Sea Waybill
        ///                            </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Textual description of the document instance.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text pertinent to this document, conveying information that is
        ///                                not contained explicitly in other structures.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Document Status Code. Code
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A code signifying the status of the Bill Of Lading (revision, replacement,
        ///                                etc.).
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Document Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Document Status</ccts:DataTypeQualifier><ccts:DataType>Document Status_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DocumentStatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DocumentStatusCodeType DocumentStatusCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Shipping Order Identifier. Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Reference number to identify a Shipping Order or Forwarding Instruction.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Shipping Order Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Freight forwarding instruction, Shippers letter of
        ///                                instruction
        ///                            </ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ShippingOrderID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ShippingOrderIdType ShippingOrderId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. To Order_ Indicator. Indicator
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Indicates whether the transport document is consigned to order.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTermQualifier>To Order</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ToOrderIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ToOrderIndicatorType ToOrderIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Ad Valorem_ Indicator. Indicator
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A term used in commerce in reference to certain duties, called ad valorem
        ///                                duties, which are levied on commodities at certain rates per centum on their value.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTermQualifier>Ad Valorem</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdValoremIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AdValoremIndicatorType AdValoremIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Declared Carriage_ Value. Amount
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Value declared by the shipper or his agent solely for the purpose of
        ///                                varying the carrier's level of liability from that provided in the contract of carriage
        ///                                in case of loss or damage to goods or delayed delivery.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTermQualifier>Declared Carriage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Interest in Delivery</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DeclaredCarriageValueAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DeclaredCarriageValueAmountType DeclaredCarriageValueAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OtherInstructionType> _otherInstruction;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Other_ Instruction. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Other free-text instructions to the forwarders or carriers related to the
        ///                                shipment. This element should only be used where such information cannot be represented
        ///                                in other structured information entities within the document.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTermQualifier>Other</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instruction</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Bill of Lading Remark</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OtherInstruction", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OtherInstructionType> OtherInstruction
        {
            get
            {
                return _otherInstruction;
            }
            set
            {
                _otherInstruction = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OtherInstruction-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OtherInstruction collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OtherInstructionSpecified
        {
            get
            {
                return ((this.OtherInstruction != null) 
                            && (this.OtherInstruction.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Consignor_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party consigning goods as stipulated in the transport contract by the
        ///                                party ordering transport.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTermQualifier>Consignor</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Consignor (WCO ID 71 and 72)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ConsignorParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PartyType ConsignorParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Carrier_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party providing the transport of goods between named points.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTermQualifier>Carrier</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Transport Company, Shipping Line, NVOCC, Airline, Haulier,
        ///                                Courier, Carrier (WCO ID 49 and 50)
        ///                            </ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CarrierParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PartyType CarrierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Freight Forwarder_ Party. Party
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A party combining individual smaller consignments into a single larger
        ///                                shipment (a so-called consolidated consignment or shipment) that is sent to a
        ///                                counterpart who mirrors the consolidator's activity by dividing the consolidated
        ///                                consignment into its original components.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTermQualifier>Freight Forwarder</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Consolidator (WCO ID 192 AND 193)
        ///                            </ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("FreightForwarderParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PartyType FreightForwarderParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Shipment</ccts:DictionaryEntryName><ccts:Definition>An identifiable collection of one or more goods items to be transported
        ///                                between the seller party and the buyer party.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Shipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Shipment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.ShipmentType Shipment { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.DocumentReferenceType> _documentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to another document associated with this document.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
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
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.ExchangeRateType> _exchangeRate;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Exchange Rate</ccts:DictionaryEntryName><ccts:Definition>Information that directly relates to the rate of exchange (conversion)
        ///                                between two currencies.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Exchange Rate</ccts:PropertyTerm><ccts:AssociatedObjectClass>Exchange Rate</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Exchange Rate</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ExchangeRate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.ExchangeRateType> ExchangeRate
        {
            get
            {
                return _exchangeRate;
            }
            set
            {
                _exchangeRate = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ExchangeRate-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ExchangeRate collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ExchangeRateSpecified
        {
            get
            {
                return ((this.ExchangeRate != null) 
                            && (this.ExchangeRate.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.DocumentDistributionType> _documentDistribution;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Document Distribution</ccts:DictionaryEntryName><ccts:Definition>A list of interested parties to whom this document is distributed.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Document Distribution</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Distribution</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Distribution</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DocumentDistribution", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.DocumentDistributionType> DocumentDistribution
        {
            get
            {
                return _documentDistribution;
            }
            set
            {
                _documentDistribution = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DocumentDistribution-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentDistribution collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DocumentDistributionSpecified
        {
            get
            {
                return ((this.DocumentDistribution != null) 
                            && (this.DocumentDistribution.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.SignatureType> _signature;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Bill Of Lading. Signature</ccts:DictionaryEntryName><ccts:Definition>A signature applied to this document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Bill Of Lading</ccts:ObjectClass><ccts:PropertyTerm>Signature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Signature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Signature</ccts:RepresentationTerm></ccts:Component></para>
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
    }
}