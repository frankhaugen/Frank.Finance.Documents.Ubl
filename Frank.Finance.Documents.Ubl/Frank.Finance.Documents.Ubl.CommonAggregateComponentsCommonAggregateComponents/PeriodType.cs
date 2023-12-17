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
    [XmlTypeAttribute("PeriodType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ActivityPeriod))]
    [XmlIncludeAttribute(typeof(ApplicablePeriod))]
    [XmlIncludeAttribute(typeof(ConstitutionPeriod))]
    [XmlIncludeAttribute(typeof(ContractAcceptancePeriod))]
    [XmlIncludeAttribute(typeof(ContractFormalizationPeriod))]
    [XmlIncludeAttribute(typeof(DeliveryPeriod))]
    [XmlIncludeAttribute(typeof(DocumentAvailabilityPeriod))]
    [XmlIncludeAttribute(typeof(DurationPeriod))]
    [XmlIncludeAttribute(typeof(EffectivePeriod))]
    [XmlIncludeAttribute(typeof(EstimatedDeliveryPeriod))]
    [XmlIncludeAttribute(typeof(EstimatedDespatchPeriod))]
    [XmlIncludeAttribute(typeof(EstimatedDurationPeriod))]
    [XmlIncludeAttribute(typeof(EstimatedTransitPeriod))]
    [XmlIncludeAttribute(typeof(ExceptionObservationPeriod))]
    [XmlIncludeAttribute(typeof(ForecastPeriod))]
    [XmlIncludeAttribute(typeof(FrequencyPeriod))]
    [XmlIncludeAttribute(typeof(InventoryPeriod))]
    [XmlIncludeAttribute(typeof(InvitationSubmissionPeriod))]
    [XmlIncludeAttribute(typeof(InvoicePeriod))]
    [XmlIncludeAttribute(typeof(LineValidityPeriod))]
    [XmlIncludeAttribute(typeof(MainPeriod))]
    [XmlIncludeAttribute(typeof(NominationPeriod))]
    [XmlIncludeAttribute(typeof(NotificationPeriod))]
    [XmlIncludeAttribute(typeof(OptionValidityPeriod))]
    [XmlIncludeAttribute(typeof(ParticipationRequestReceptionPeriod))]
    [XmlIncludeAttribute(typeof(PaymentReversalPeriod))]
    [XmlIncludeAttribute(typeof(PenaltyPeriod))]
    [XmlIncludeAttribute(typeof(Period))]
    [XmlIncludeAttribute(typeof(PlannedPeriod))]
    [XmlIncludeAttribute(typeof(PresentationPeriod))]
    [XmlIncludeAttribute(typeof(PromisedDeliveryPeriod))]
    [XmlIncludeAttribute(typeof(ReminderPeriod))]
    [XmlIncludeAttribute(typeof(RequestedDeliveryPeriod))]
    [XmlIncludeAttribute(typeof(RequestedDespatchPeriod))]
    [XmlIncludeAttribute(typeof(RequestedStatusPeriod))]
    [XmlIncludeAttribute(typeof(RequestedValidityPeriod))]
    [XmlIncludeAttribute(typeof(ServiceEndTimePeriod))]
    [XmlIncludeAttribute(typeof(ServiceStartTimePeriod))]
    [XmlIncludeAttribute(typeof(SettlementPeriod))]
    [XmlIncludeAttribute(typeof(StatementPeriod))]
    [XmlIncludeAttribute(typeof(StatusPeriod))]
    [XmlIncludeAttribute(typeof(TenderSubmissionDeadlinePeriod))]
    [XmlIncludeAttribute(typeof(TenderValidityPeriod))]
    [XmlIncludeAttribute(typeof(TransitPeriod))]
    [XmlIncludeAttribute(typeof(TransportServiceProviderResponseDeadlinePeriod))]
    [XmlIncludeAttribute(typeof(TransportServiceProviderResponseRequiredPeriod))]
    [XmlIncludeAttribute(typeof(TransportUserResponseRequiredPeriod))]
    [XmlIncludeAttribute(typeof(UsabilityPeriod))]
    [XmlIncludeAttribute(typeof(ValidityPeriod))]
    [XmlIncludeAttribute(typeof(WarrantyValidityPeriod))]
    public partial class PeriodType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Period. Start Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which this period begins.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Period</ccts:ObjectClass><ccts:PropertyTerm>Start Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("StartDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.StartDateType StartDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Period. Start Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time at which this period begins.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Period</ccts:ObjectClass><ccts:PropertyTerm>Start Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("StartTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.StartTimeType StartTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Period. End Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which this period ends.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Period</ccts:ObjectClass><ccts:PropertyTerm>End Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EndDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.EndDateType EndDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Period. End Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time at which this period ends.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Period</ccts:ObjectClass><ccts:PropertyTerm>End Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EndTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.EndTimeType EndTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Period. Duration. Measure</ccts:DictionaryEntryName><ccts:Definition>The duration of this period, expressed as an ISO 8601 code.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Period</ccts:ObjectClass><ccts:PropertyTerm>Duration</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DurationMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DurationMeasureType DurationMeasure { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DescriptionCodeType> _descriptionCode;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Period. Description Code. Code</ccts:DictionaryEntryName><ccts:Definition>A description of this period, expressed as a code.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Period</ccts:ObjectClass><ccts:PropertyTerm>Description Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DescriptionCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DescriptionCodeType> DescriptionCode
        {
            get
            {
                return _descriptionCode;
            }
            set
            {
                _descriptionCode = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DescriptionCode-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DescriptionCode collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DescriptionCodeSpecified
        {
            get
            {
                return ((this.DescriptionCode != null) 
                            && (this.DescriptionCode.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Period. Description. Text</ccts:DictionaryEntryName><ccts:Definition>A description of this period, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Period</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
    }
}