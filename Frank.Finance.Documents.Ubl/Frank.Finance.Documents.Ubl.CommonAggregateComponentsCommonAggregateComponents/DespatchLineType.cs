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
    [XmlTypeAttribute("DespatchLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(DespatchLine))]
    [XmlIncludeAttribute(typeof(HandlingUnitDespatchLine))]
    public partial class DespatchLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this despatch line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for this despatch line.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UUID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text conveying information that is not contained explicitly in
        ///                                other structures.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Line Status Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the status of this despatch line with respect to its
        ///                                original state.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTerm>Line Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Line Status</ccts:DataTypeQualifier><ccts:DataType>Line Status_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("LineStatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.LineStatusCodeType LineStatusCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Delivered_ Quantity. Quantity
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The quantity despatched (picked up).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivered</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DeliveredQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DeliveredQuantityType DeliveredQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Backorder_ Quantity. Quantity
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The quantity on back order at the supplier.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Backorder</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("BackorderQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BackorderQuantityType BackorderQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BackorderReasonType> _backorderReason;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Backorder_ Reason. Text</ccts:DictionaryEntryName><ccts:Definition>The reason for the back order.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Backorder</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reason</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("BackorderReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BackorderReasonType> BackorderReason
        {
            get
            {
                return _backorderReason;
            }
            set
            {
                _backorderReason = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BackorderReason-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the BackorderReason collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool BackorderReasonSpecified
        {
            get
            {
                return ((this.BackorderReason != null) 
                            && (this.BackorderReason.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Outstanding_ Quantity. Quantity
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The quantity outstanding (which will follow in a later despatch).
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Outstanding</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OutstandingQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OutstandingQuantityType OutstandingQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OutstandingReasonType> _outstandingReason;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Outstanding_ Reason. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The reason for the outstanding quantity.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Outstanding</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reason</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OutstandingReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OutstandingReasonType> OutstandingReason
        {
            get
            {
                return _outstandingReason;
            }
            set
            {
                _outstandingReason = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OutstandingReason-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OutstandingReason collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OutstandingReasonSpecified
        {
            get
            {
                return ((this.OutstandingReason != null) 
                            && (this.OutstandingReason.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Oversupply_ Quantity. Quantity
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The quantity over-supplied, i.e., the quantity over and above that
        ///                                ordered.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Oversupply</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OversupplyQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OversupplyQuantityType OversupplyQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<OrderLineReferenceType> _orderLineReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Order Line Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to an order line associated with this despatch line.
        ///                            </ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTerm>Order Line Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Order Line Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Order Line Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OrderLineReference")]
        public List<OrderLineReferenceType> OrderLineReference
        {
            get
            {
                return _orderLineReference;
            }
            set
            {
                _orderLineReference = value;
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _documentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document associated with this despatch line.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DocumentReference")]
        public List<DocumentReferenceType> DocumentReference
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Item</ccts:DictionaryEntryName><ccts:Definition>The item associated with this despatch line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Item")]
        public ItemType Item { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ShipmentType> _shipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Despatch Line. Shipment</ccts:DictionaryEntryName><ccts:Definition>A shipment associated with this despatch line.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Despatch Line</ccts:ObjectClass><ccts:PropertyTerm>Shipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Shipment")]
        public List<ShipmentType> Shipment
        {
            get
            {
                return _shipment;
            }
            set
            {
                _shipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Shipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Shipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ShipmentSpecified
        {
            get
            {
                return ((this.Shipment != null) 
                            && (this.Shipment.Count != 0));
            }
        }
    }
}