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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Pricing Reference. Details</ccts:DictionaryEntryName><ccts:Definition>A reference to the basis for pricing. This may be based on a catalogue or a quoted
    ///                        amount from a price list and include some alternative pricing conditions.
    ///                    </ccts:Definition><ccts:ObjectClass>Pricing Reference</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("PricingReferenceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("PricingReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PricingReferenceType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Pricing Reference. Original_ Item Location Quantity. Item Location
        ///                                Quantity
        ///                            </ccts:DictionaryEntryName><ccts:Definition>An original set of location-specific properties (e.g., price and quantity)
        ///                                associated with this item.
        ///                            </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Pricing Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Original</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Location Quantity</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Location Quantity</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Location Quantity</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OriginalItemLocationQuantity")]
        public ItemLocationQuantityType OriginalItemLocationQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PriceType> _alternativeConditionPrice;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Pricing Reference. Alternative Condition_ Price. Price
        ///                            </ccts:DictionaryEntryName><ccts:Definition>The price expressed in terms other than the actual price, e.g., the list
        ///                                price v. the contracted price, or the price in bags v. the price in kilos, or the list
        ///                                price in bags v. the contracted price in kilos.
        ///                            </ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Pricing Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Alternative Condition</ccts:PropertyTermQualifier><ccts:PropertyTerm>Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AlternativeConditionPrice")]
        public List<PriceType> AlternativeConditionPrice
        {
            get
            {
                return _alternativeConditionPrice;
            }
            set
            {
                _alternativeConditionPrice = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AlternativeConditionPrice-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AlternativeConditionPrice collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AlternativeConditionPriceSpecified
        {
            get
            {
                return ((this.AlternativeConditionPrice != null) 
                            && (this.AlternativeConditionPrice.Count != 0));
            }
        }
    }
}
