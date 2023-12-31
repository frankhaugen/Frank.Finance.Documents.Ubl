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
    [XmlTypeAttribute("ClassificationCategoryType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(CategorizesClassificationCategory))]
    [XmlIncludeAttribute(typeof(ClassificationCategory))]
    public partial class ClassificationCategoryType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Category. Name</ccts:DictionaryEntryName><ccts:Definition>The name of this category within the classification scheme.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Category</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Code List Name</ccts:AlternativeBusinessTerms><ccts:Examples>UNSPSC Class , UNSPSC Segment , UNSPSC Family</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Category. Code Value. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The value of a code used to identify this category within the
        ///                                classification scheme.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Classification Category</ccts:ObjectClass><ccts:PropertyTerm>Code Value</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Code Value</ccts:AlternativeBusinessTerms><ccts:Examples>3420001, 3273666, HSJJD-213</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CodeValue", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CodeValueType CodeValue { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Category. Description. Text
        ///                            </ccts:DictionaryEntryName><ccts:Definition>Text describing this category.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Classification Category</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Code Name</ccts:AlternativeBusinessTerms><ccts:Examples>Electrical Goods , Wooden Toys</ccts:Examples></ccts:Component></para>
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
        private List<ClassificationCategoryType> _categorizesClassificationCategory;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Classification Category. Categorizes_ Classification Category.
        ///                                Classification Category
        ///                            </ccts:DictionaryEntryName><ccts:Definition>A recursive description of a subcategory of this category.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Classification Category</ccts:ObjectClass><ccts:PropertyTermQualifier>Categorizes</ccts:PropertyTermQualifier><ccts:PropertyTerm>Classification Category</ccts:PropertyTerm><ccts:AssociatedObjectClass>Classification Category</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Classification Category</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CategorizesClassificationCategory")]
        public List<ClassificationCategoryType> CategorizesClassificationCategory
        {
            get
            {
                return _categorizesClassificationCategory;
            }
            set
            {
                _categorizesClassificationCategory = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CategorizesClassificationCategory-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CategorizesClassificationCategory collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CategorizesClassificationCategorySpecified
        {
            get
            {
                return ((this.CategorizesClassificationCategory != null) 
                            && (this.CategorizesClassificationCategory.Count != 0));
            }
        }
    }
}
