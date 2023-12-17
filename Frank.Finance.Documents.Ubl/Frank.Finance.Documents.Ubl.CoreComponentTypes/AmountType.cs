//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace Frank.Finance.Documents.Ubl.CoreComponentTypes
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
    /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000001</ccts:UniqueID></para>
    /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">CCT</ccts:CategoryCode></para>
    /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Amount. Type</ccts:DictionaryEntryName></para>
    /// <para xml:lang="en"><ccts:VersionID xmlns:ccts="urn:un:unece:uncefact:documentation:2">1.0</ccts:VersionID></para>
    /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">A number of monetary units specified in a currency where the unit of the currency is
    ///                    explicit or implied.
    ///                </ccts:Definition></para>
    /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Amount</ccts:RepresentationTermName></para>
    /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">decimal</ccts:PrimitiveType></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("AmountType", Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    [XmlRootAttribute("AmountType", Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AdvertisementAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AllowanceTotalAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.UnqualifiedDataTypesUnqualifiedDataTypes.AmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AnnualAverageAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AverageAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.AverageSubsequentContractAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BalanceAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BaseAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CallBaseAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CallExtensionAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ChargeTotalAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CorporateStockAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CorrectionAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CorrectionUnitAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CreditLineAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DebitLineAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DeclaredCarriageValueAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DeclaredCustomsValueAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DeclaredForCarriageValueAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DeclaredStatisticsValueAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DocumentationFeeAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.EstimatedAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.EstimatedOverallContractAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FaceValueAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FeeAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.FreeOnBoardValueAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.HigherTenderAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.InsurancePremiumAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.InsuranceValueAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.InventoryValueAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.LiabilityAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.LineExtensionAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.LowerTenderAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MarketValueAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MaximumAdvertisementAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MaximumAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MaximumPaidAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MinimumAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PaidAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PartyCapacityAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PayableAlternativeAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PayableAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PayableRoundingAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PenaltyAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PerUnitAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PrepaidAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PriceAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.RequiredFeeAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.RoundingAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.SettlementDiscountAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TaxableAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TaxAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TaxEnergyAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TaxEnergyBalanceAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TaxEnergyOnAccountAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TaxExclusiveAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TaxInclusiveAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ThresholdAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalBalanceAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalCreditAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalDebitAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalInvoiceAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalPaymentAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalTaskAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalTaxAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TransactionCurrencyTaxAmountType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValueAmountType))]
    public partial class AmountType
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft den Text ab oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [XmlTextAttribute()]
        public decimal Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000001-SC2</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Amount Currency. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The currency of the amount.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Amount Currency</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identification</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// <para xml:lang="en"><ccts:UsageRule xmlns:ccts="urn:un:unece:uncefact:documentation:2">Reference UNECE Rec 9, using 3-letter alphabetic codes.</ccts:UsageRule></para>
        /// </summary>
        [XmlAttributeAttribute("currencyID")]
        public string CurrencyId { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000001-SC3</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Amount Currency. Code List Version. Identifier
        ///                            </ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The VersionID of the UN/ECE Rec9 code list.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Amount Currency</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List Version</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [XmlAttributeAttribute("currencyCodeListVersionID")]
        public string CurrencyCodeListVersionId { get; set; }
    }
}