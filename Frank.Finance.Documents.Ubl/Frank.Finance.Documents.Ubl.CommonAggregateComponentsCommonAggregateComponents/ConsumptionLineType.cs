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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a line item for utility consumption. To specify more than one
    ///                        utility item, use separate consumption lines.
    ///                    </ccts:Definition><ccts:ObjectClass>Consumption Line</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("ConsumptionLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("ConsumptionLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ConsumptionLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this consumption line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>1</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Parent_ Document Line Reference Identifier.
        ///                                Identifier
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An identifier for the transaction line on a related document (such as an
        ///                                invoice) that covers this consumption line.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Parent</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Line Reference Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>Consumption</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ParentDocumentLineReferenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ParentDocumentLineReferenceIdType ParentDocumentLineReferenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Invoiced_ Quantity. Quantity
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The quantity invoiced.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Invoiced</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("InvoicedQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.InvoicedQuantityType InvoicedQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Line Extension Amount. Amount
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The monetary amount, including discount, to be charged for this consumption
        ///                                line.
        ///                            </ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTerm>Line Extension Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("LineExtensionAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.LineExtensionAmountType LineExtensionAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Period</ccts:DictionaryEntryName><ccts:Definition>The period of time covered by this consumption line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Period")]
        public PeriodType Period { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DeliveryType> _delivery;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Delivery</ccts:DictionaryEntryName><ccts:Definition>A delivery of the utility item on this consumption line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTerm>Delivery</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Delivery")]
        public List<DeliveryType> Delivery
        {
            get
            {
                return _delivery;
            }
            set
            {
                _delivery = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Delivery-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Delivery collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeliverySpecified
        {
            get
            {
                return ((this.Delivery != null) 
                            && (this.Delivery.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AllowanceChargeType> _allowanceCharge;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Allowance Charge</ccts:DictionaryEntryName><ccts:Definition>An allowance or charge that applies to this consumption line.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTerm>Allowance Charge</ccts:PropertyTerm><ccts:AssociatedObjectClass>Allowance Charge</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Allowance Charge</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AllowanceCharge")]
        public List<AllowanceChargeType> AllowanceCharge
        {
            get
            {
                return _allowanceCharge;
            }
            set
            {
                _allowanceCharge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AllowanceCharge-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AllowanceCharge collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AllowanceChargeSpecified
        {
            get
            {
                return ((this.AllowanceCharge != null) 
                            && (this.AllowanceCharge.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TaxTotalType> _taxTotal;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Tax Total</ccts:DictionaryEntryName><ccts:Definition>A total amount of taxes of a particular kind applicable to this consumption
        ///                                line.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTerm>Tax Total</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Total</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Total</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TaxTotal")]
        public List<TaxTotalType> TaxTotal
        {
            get
            {
                return _taxTotal;
            }
            set
            {
                _taxTotal = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TaxTotal-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TaxTotal collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TaxTotalSpecified
        {
            get
            {
                return ((this.TaxTotal != null) 
                            && (this.TaxTotal.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Utility Item</ccts:DictionaryEntryName><ccts:Definition>The utility item consumed.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTerm>Utility Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Utility Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Utility Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UtilityItem")]
        public UtilityItemType UtilityItem { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Price</ccts:DictionaryEntryName><ccts:Definition>The price associated with this consumption line, expressed in a data
        ///                                structure containing multiple properties.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTerm>Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Price")]
        public PriceType Price { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Line. Unstructured Price</ccts:DictionaryEntryName><ccts:Definition>The price associated with this consumption line expressed in a less
        ///                                structured form that includes just the amount and the time of use.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Line</ccts:ObjectClass><ccts:PropertyTerm>Unstructured Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Unstructured Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Unstructured Price</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UnstructuredPrice")]
        public UnstructuredPriceType UnstructuredPrice { get; set; }
    }
}
