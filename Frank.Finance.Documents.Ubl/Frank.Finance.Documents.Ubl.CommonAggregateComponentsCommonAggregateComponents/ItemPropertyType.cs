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
    [XmlTypeAttribute("ItemPropertyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AdditionalItemProperty))]
    [XmlIncludeAttribute(typeof(ItemProperty))]
    [XmlIncludeAttribute(typeof(KeywordItemProperty))]
    public partial class ItemPropertyType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this property of an item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Name</ccts:DictionaryEntryName><ccts:Definition>The name of this item property.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>Energy Rating , Collar Size , Fat Content</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Name Code. Code</ccts:DictionaryEntryName><ccts:Definition>The name of this item property, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>Name Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("NameCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NameCodeType NameCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Test Method. Text</ccts:DictionaryEntryName><ccts:Definition>The method of testing the value of this item property.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>Test Method</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>100 watts , 15 European , 20% +/- 5%</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TestMethod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TestMethodType TestMethod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Value. Text</ccts:DictionaryEntryName><ccts:Definition>The value of this item property, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>100 watts , 15 European , 20% +/- 5%</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Value", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValueType Value { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Value_ Quantity. Quantity
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The value of this item property, expressed as a quantity.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTermQualifier>Value</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValueQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValueQuantityType ValueQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValueQualifierType> _valueQualifier;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Value Qualifier. Text</ccts:DictionaryEntryName><ccts:Definition>Text qualifying the value of the property.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>Value Qualifier</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValueQualifier", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValueQualifierType> ValueQualifier
        {
            get
            {
                return _valueQualifier;
            }
            set
            {
                _valueQualifier = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ValueQualifier-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ValueQualifier collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ValueQualifierSpecified
        {
            get
            {
                return ((this.ValueQualifier != null) 
                            && (this.ValueQualifier.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Importance Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the importance of this property in using it to describe a
        ///                                related Item.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>Importance Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ImportanceCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ImportanceCodeType ImportanceCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ListValueType> _listValue;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. List Value. Text</ccts:DictionaryEntryName><ccts:Definition>The value expressed as a text in case the property is a value in a list.
        ///                                For example, a colour.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>List Value</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ListValue", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ListValueType> ListValue
        {
            get
            {
                return _listValue;
            }
            set
            {
                _listValue = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ListValue-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ListValue collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ListValueSpecified
        {
            get
            {
                return ((this.ListValue != null) 
                            && (this.ListValue.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Usability_ Period. Period
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The period during which this item property is valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTermQualifier>Usability</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("UsabilityPeriod")]
        public PeriodType UsabilityPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ItemPropertyGroupType> _itemPropertyGroup;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Item Property Group</ccts:DictionaryEntryName><ccts:Definition>A description of the property group to which this item property belongs.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>Item Property Group</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Property Group</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Property Group</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ItemPropertyGroup")]
        public List<ItemPropertyGroupType> ItemPropertyGroup
        {
            get
            {
                return _itemPropertyGroup;
            }
            set
            {
                _itemPropertyGroup = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ItemPropertyGroup-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ItemPropertyGroup collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ItemPropertyGroupSpecified
        {
            get
            {
                return ((this.ItemPropertyGroup != null) 
                            && (this.ItemPropertyGroup.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Range_ Dimension. Dimension
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The range of values for the dimensions of this property.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTermQualifier>Range</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RangeDimension")]
        public DimensionType RangeDimension { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Property. Item Property Range</ccts:DictionaryEntryName><ccts:Definition>A range of values for this item property.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Property</ccts:ObjectClass><ccts:PropertyTerm>Item Property Range</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Property Range</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Property Range</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ItemPropertyRange")]
        public ItemPropertyRangeType ItemPropertyRange { get; set; }
    }
}
