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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a project to procure goods, works, or services.
    ///                    </ccts:Definition><ccts:ObjectClass>Procurement Project</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("ProcurementProjectType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("ProcurementProject", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ProcurementProjectType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this procurement project.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NameType> _name;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Name</ccts:DictionaryEntryName><ccts:Definition>A name of this procurement project.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NameType> Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this procurement project.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Procurement_ Type Code. Code
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of procurement project (e.g., goods, works,
        ///                                services).
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Procurement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProcurementTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ProcurementTypeCodeType ProcurementTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Procurement Sub_ Type Code. Code
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A code signifying the subcategory of the type of work for this project
        ///                                (e.g., land surveying, IT consulting).
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Procurement Sub</ccts:PropertyTermQualifier><ccts:PropertyTerm>Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProcurementSubTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ProcurementSubTypeCodeType ProcurementSubTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Quality Control Code. Code
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The indication of whether or not the control quality is included in the
        ///                                works project.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTerm>Quality Control Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("QualityControlCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.QualityControlCodeType QualityControlCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Required_ Fee. Amount
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The amount of the reimbursement fee for concession procurement projects.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Required</ccts:PropertyTermQualifier><ccts:PropertyTerm>Fee</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequiredFeeAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.RequiredFeeAmountType RequiredFeeAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FeeDescriptionType> _feeDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Fee_ Description. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Text describing the reimbursement fee for concession procurement
        ///                                projects.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Fee</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("FeeDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FeeDescriptionType> FeeDescription
        {
            get
            {
                return _feeDescription;
            }
            set
            {
                _feeDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FeeDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the FeeDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FeeDescriptionSpecified
        {
            get
            {
                return ((this.FeeDescription != null) 
                            && (this.FeeDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Requested_ Delivery Date. Date
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The requested delivery date for this procurement project.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Requested</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequestedDeliveryDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.RequestedDeliveryDateType RequestedDeliveryDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Estimated_ Overall Contract. Quantity
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The estimated overall quantity for this procurement project.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated</ccts:PropertyTermQualifier><ccts:PropertyTerm>Overall Contract</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EstimatedOverallContractQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.EstimatedOverallContractQuantityType EstimatedOverallContractQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text applying to the Procurement Project. This element may
        ///                                contain additional information about the lot/contract that is not contained explicitly
        ///                                in another structure.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Requested Tender Total
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Budget monetary amounts for the project as whole.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTerm>Requested Tender Total</ccts:PropertyTerm><ccts:AssociatedObjectClass>Requested Tender Total</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Requested Tender Total</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequestedTenderTotal")]
        public RequestedTenderTotalType RequestedTenderTotal { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Main_ Commodity Classification. Commodity
        ///                                Classification
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An association to the main classification category for the deliverable
        ///                                requested.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Main</ccts:PropertyTermQualifier><ccts:PropertyTerm>Commodity Classification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Commodity Classification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Commodity Classification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MainCommodityClassification")]
        public CommodityClassificationType MainCommodityClassification { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<CommodityClassificationType> _additionalCommodityClassification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Additional_ Commodity Classification.
        ///                                Commodity Classification
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An association to additional classification categories for the deliverable
        ///                                requested.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Commodity Classification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Commodity Classification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Commodity Classification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalCommodityClassification")]
        public List<CommodityClassificationType> AdditionalCommodityClassification
        {
            get
            {
                return _additionalCommodityClassification;
            }
            set
            {
                _additionalCommodityClassification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalCommodityClassification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalCommodityClassification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalCommodityClassificationSpecified
        {
            get
            {
                return ((this.AdditionalCommodityClassification != null) 
                            && (this.AdditionalCommodityClassification.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<LocationType> _realizedLocation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Realized_ Location. Location
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A place where this procurement project will be physically realized.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Realized</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RealizedLocation")]
        public List<LocationType> RealizedLocation
        {
            get
            {
                return _realizedLocation;
            }
            set
            {
                _realizedLocation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RealizedLocation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RealizedLocation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RealizedLocationSpecified
        {
            get
            {
                return ((this.RealizedLocation != null) 
                            && (this.RealizedLocation.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Planned_ Period. Period
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The period during which this procurement project is planned to take
        ///                                place.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Planned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PlannedPeriod")]
        public PeriodType PlannedPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Contract Extension</ccts:DictionaryEntryName><ccts:Definition>The contract extension for this tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTerm>Contract Extension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contract Extension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contract Extension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContractExtension")]
        public ContractExtensionType ContractExtension { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<RequestForTenderLineType> _requestForTenderLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Procurement Project. Request For Tender Line
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A good or service this project is intended to procure.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Procurement Project</ccts:ObjectClass><ccts:PropertyTerm>Request For Tender Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Request For Tender Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Request For Tender Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequestForTenderLine")]
        public List<RequestForTenderLineType> RequestForTenderLine
        {
            get
            {
                return _requestForTenderLine;
            }
            set
            {
                _requestForTenderLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequestForTenderLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequestForTenderLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequestForTenderLineSpecified
        {
            get
            {
                return ((this.RequestForTenderLine != null) 
                            && (this.RequestForTenderLine.Count != 0));
            }
        }
    }
}
