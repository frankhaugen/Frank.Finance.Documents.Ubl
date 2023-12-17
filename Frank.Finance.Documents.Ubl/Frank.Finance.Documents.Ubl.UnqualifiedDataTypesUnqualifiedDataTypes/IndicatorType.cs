//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace Frank.Finance.Documents.Ubl.UnqualifiedDataTypesUnqualifiedDataTypes
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
    /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UBLUDT0000012</ccts:UniqueID></para>
    /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">UDT</ccts:CategoryCode></para>
    /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Indicator. Type</ccts:DictionaryEntryName></para>
    /// <para xml:lang="en"><ccts:VersionID xmlns:ccts="urn:un:unece:uncefact:documentation:2">1.0</ccts:VersionID></para>
    /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">A list of two mutually exclusive Boolean values that express the only possible states
    ///                    of a property.
    ///                </ccts:Definition></para>
    /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Indicator</ccts:RepresentationTermName></para>
    /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("IndicatorType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    [XmlRootAttribute("IndicatorType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AcceptedIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AdValoremIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AnimalFoodApprovedIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AnimalFoodIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AuctionConstraintIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BackOrderAllowedIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BalanceBroughtForwardIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BasedOnConsensusIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BindingOnBuyerIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BulkCargoIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CandidateReductionConstraintIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CatalogueIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ChargeIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CompletionIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ConsolidatableIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ContainerizedIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CopyIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CustomsImportClassifiedIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DangerousGoodsApprovedIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FollowupContractIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FreeOfChargeIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FrozenDocumentIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FullyPaidSharesIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.GeneralCargoIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.GovernmentAgreementConstraintIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.HazardousRiskIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.HumanFoodApprovedIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.HumanFoodIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.IndicationIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ItemUpdateRequestIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.LegalStatusIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.LivestockIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MarkAttentionIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MarkCareIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OnCarriageIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OptionalLineItemIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OrderableIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OtherConditionsIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PartialDeliveryIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PowerIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PreCarriageIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PrepaidIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PricingUpdateRequestIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PrizeIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PublishAwardIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.RefrigeratedIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.RefrigerationOnIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.RequiredCurriculaIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ReturnabilityIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ReturnableMaterialIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.SoleProprietorshipIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.SpecialSecurityIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.SplitConsignmentIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.StatusAvailableIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TaxEvidenceIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TaxIncludedIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ThirdPartyPayerIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ToOrderIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.UnknownPriceIndicatorType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.VariantConstraintIndicatorType))]
    public partial class IndicatorType
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft den Text ab oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [XmlTextAttribute()]
        public bool Value { get; set; }
    }
}
