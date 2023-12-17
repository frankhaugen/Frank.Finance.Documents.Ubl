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
    /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UBLUDT0000018</ccts:UniqueID></para>
    /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">UDT</ccts:CategoryCode></para>
    /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity. Type</ccts:DictionaryEntryName></para>
    /// <para xml:lang="en"><ccts:VersionID xmlns:ccts="urn:un:unece:uncefact:documentation:2">1.0</ccts:VersionID></para>
    /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">A counted number of non-monetary units, possibly including a fractional part.
    ///                </ccts:Definition></para>
    /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity</ccts:RepresentationTermName></para>
    /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">decimal</ccts:PrimitiveType></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [XmlTypeAttribute("QuantityType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    [XmlRootAttribute("QuantityType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ActualTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BackorderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BaseQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BasicConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.BatchQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ChargeableQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ChildConsignmentQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ConsignmentQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ConsumerUnitQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ConsumptionEnergyQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ConsumptionWaterQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ContentUnitQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CreditedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CrewQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.CustomsTariffQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DebitedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DeliveredQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.DifferenceTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.EmployeeQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.EstimatedConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.EstimatedOverallContractQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ExpectedOperatorQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ExpectedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.GasPressureQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.InvoicedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.LatestMeterQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MaximumBackorderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MaximumOperatorQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MaximumOrderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MaximumQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MaximumVariantQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MinimumBackorderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MinimumInventoryQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MinimumOrderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MinimumQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.MultipleOrderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.NormalTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OperatingYearsQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OutstandingQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.OversupplyQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PackQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PassengerQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PerformanceValueQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.PreviousMeterQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.QuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ReceivedElectronicTenderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ReceivedForeignTenderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ReceivedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ReceivedTenderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.RejectedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ReturnableQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.SharesNumberQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ShortQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TargetInventoryQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ThresholdQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TimeDeltaDaysQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalDeliveredQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalGoodsItemQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalMeteredQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalPackageQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalPackagesQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.TotalTransportHandlingUnitQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.ValueQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.Finance.Documents.Ubl.CommonBasicComponentsCommonBasicComponents.VarianceQuantityType))]
    public partial class QuantityType : Frank.Finance.Documents.Ubl.CoreComponentTypes.QuantityType
    {
    }
}
