using Frank.Finance.Documents.Ubl.Invoice;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;
using System.Linq;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class InvoiceExtensions
{
    public static IContainer InvoiceDetails(this IContainer container, InvoiceType invoice)
    {
        container.Column(col =>
        {
            col.Item().Mono("Invoice Number", invoice.Id?.Value);
            col.Item().Mono("UUID", invoice.Uuid?.Value);
            col.Item().Date("Issue Date", invoice.IssueDate?.Value);
            col.Item().Date("Issue Time", invoice.IssueTime?.Value);
            col.Item().Date("Due Date", invoice.DueDate?.Value);
            col.Item().Date("Tax Point Date", invoice.TaxPointDate?.Value);
            col.Item().Mono("UBL Version", invoice.UblVersionId?.Value);
            col.Item().Mono("Customization ID", invoice.CustomizationId?.Value);
            col.Item().Mono("Profile ID", invoice.ProfileId?.Value);
            col.Item().Mono("Profile Execution ID", invoice.ProfileExecutionId?.Value);
            col.Item().Field("Copy Indicator", invoice.CopyIndicator?.Value.ToString());
            col.Item().Mono("Document Currency", invoice.DocumentCurrencyCode?.Value);
            col.Item().Mono("Tax Currency", invoice.TaxCurrencyCode?.Value);
            col.Item().Mono("Pricing Currency", invoice.PricingCurrencyCode?.Value);
            col.Item().Mono("Payment Currency", invoice.PaymentCurrencyCode?.Value);
            col.Item().Mono("Payment Alternative Currency", invoice.PaymentAlternativeCurrencyCode?.Value);
            col.Item().Mono("Accounting Cost Code", invoice.AccountingCostCode?.Value);
            col.Item().Field("Accounting Cost", invoice.AccountingCost?.Value);
            col.Item().Field("Line Count", invoice.LineCountNumeric?.Value.ToString());
            col.Item().Mono("Buyer Reference", invoice.BuyerReference?.Value);
            invoice.Signature?.ForEach(signature => col.Item().Mono("Signature ID", signature.Id?.Value));
            col.Spacing(5);
            col.Item().SectionHeading("DOCUMENT REFERENCES");
            invoice.AdditionalDocumentReferenceSpecified.Let(specified => col.Item().Field("Additional Document Reference Specified", specified.ToString()));
            invoice.AdditionalDocumentReference?.ForEach(doc => col.Item().Mono(doc.DocumentDescription.Select(desc => desc.Value).Join(" "), doc.Id?.Value));
            invoice.ContractDocumentReference?.ForEach(doc => col.Item().Mono("Contract Document Reference", doc.Id?.Value));
            invoice.ProjectReference?.ForEach(proj => col.Item().Mono("Project Reference", proj.Id?.Value));
            invoice.OrderReference?.Let(orderRef => col.Item().Mono("Order Reference", orderRef.Id?.Value));
            invoice.BillingReference?.ForEach(doc => col.Item().Mono("Billing Reference", doc.InvoiceDocumentReference?.Id?.Value));
            invoice.DespatchDocumentReference?.ForEach(doc => col.Item().Mono(doc.DocumentDescription.Select(desc => desc.Value).Join(" "), doc.Id?.Value));
            invoice.ReceiptDocumentReference?.ForEach(doc => col.Item().Mono(doc.DocumentDescription.Select(desc => desc.Value).Join(" "), doc.Id?.Value));
            invoice.StatementDocumentReference?.ForEach(doc => col.Item().Mono(doc.DocumentDescription.Select(desc => desc.Value).Join(" "), doc.Id?.Value));
            col.Spacing(5);
            col.Item().SectionHeading("PAYMENT TERMS");
            // invoice.PaymentTerms?.ForEach(term => term.Note?.ForEach(note => col.Item().Field("Payment Terms", note.Value)));
            invoice.PaymentTerms?.ForEach(term => col.Item().Field(term.PaymentMeansId.Select(id => id.Value).Join(", "), term.Note?.Select(note => note.Value).Join(", ")));
        });
        return container;
    }

    public static IContainer Totals(this IContainer container, InvoiceType invoice)
    {
        container.Column(col =>
        {
            // Legal Monetary Total
            col.Item().Money("Line Extension Amount", invoice.LegalMonetaryTotal?.LineExtensionAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Tax Exclusive Amount", invoice.LegalMonetaryTotal?.TaxExclusiveAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Tax Inclusive Amount", invoice.LegalMonetaryTotal?.TaxInclusiveAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Allowance Total Amount", invoice.LegalMonetaryTotal?.AllowanceTotalAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Charge Total Amount", invoice.LegalMonetaryTotal?.ChargeTotalAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Prepaid Amount", invoice.LegalMonetaryTotal?.PrepaidAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Payable Rounding Amount", invoice.LegalMonetaryTotal?.PayableRoundingAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Payable Amount", invoice.LegalMonetaryTotal?.PayableAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            
            // Tax Totals
            invoice.TaxTotal?.ForEach((tax, index) => 
            {
                col.Item().Money($"Tax Amount {index + 1}", tax.TaxAmount?.Value, invoice.DocumentCurrencyCode?.Value);
                col.Item().Money($"Rounding Amount {index + 1}", tax.RoundingAmount?.Value, invoice.DocumentCurrencyCode?.Value);
                col.Item().Field($"Tax Evidence Indicator {index + 1}", tax.TaxEvidenceIndicator?.Value.ToString());
            });
            
            // Withholding Tax Totals
            invoice.WithholdingTaxTotal?.ForEach((tax, index) => 
            {
                col.Item().Money($"Withholding Tax Amount {index + 1}", tax.TaxAmount?.Value, invoice.DocumentCurrencyCode?.Value);
                col.Item().Money($"Withholding Rounding Amount {index + 1}", tax.RoundingAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            });
        });
        return container;
    }

    public static IContainer Notes(this IContainer container, InvoiceType invoice)
    {
        if (invoice.Note?.Count > 0) 
        {
            container.Column(col =>
            {
                invoice.Note.ForEach(note => col.Item().Text(note.Value));
            });
        }
        return container;
    }

    public static IContainer Summary(this IContainer container, InvoiceType invoice)
    {
        container.Column(col =>
        {
            col.Item().Mono("Invoice Number", invoice.Id?.Value);
            col.Item().Date("Issue Date", invoice.IssueDate?.Value);
            col.Item().Field("Line Item Count", invoice.InvoiceLine?.Count.ToString() ?? "0");
            
            // Document References
            invoice.OrderReference?.Let(orderRef => col.Item().Mono("Order Reference", orderRef.Id?.Value));
            invoice.BillingReference?.ForEach(doc => col.Item().Mono("Billing Reference", doc.InvoiceDocumentReference?.Id?.Value));
            invoice.DespatchDocumentReference?.ForEach(doc => col.Item().Mono("Despatch Document Reference", doc.Id?.Value));
            invoice.ReceiptDocumentReference?.ForEach(doc => col.Item().Mono("Receipt Document Reference", doc.Id?.Value));
            invoice.StatementDocumentReference?.ForEach(doc => col.Item().Mono("Statement Document Reference", doc.Id?.Value));
            invoice.OriginatorDocumentReference?.ForEach(doc => col.Item().Mono("Originator Document Reference", doc.Id?.Value));
            invoice.ContractDocumentReference?.ForEach(doc => col.Item().Mono("Contract Document Reference", doc.Id?.Value));
            invoice.AdditionalDocumentReference?.ForEach(doc => col.Item().Mono("Additional Document Reference", doc.Id?.Value));
            
            // Project References
            invoice.ProjectReference?.ForEach(proj => col.Item().Mono("Project Reference", proj.Id?.Value));
            
            // Exchange Rates
            invoice.TaxExchangeRate?.Let(rate => col.Item().Field("Tax Exchange Rate", rate.CalculationRate?.Value.ToString()));
            invoice.PricingExchangeRate?.Let(rate => col.Item().Field("Pricing Exchange Rate", rate.CalculationRate?.Value.ToString()));
            invoice.PaymentExchangeRate?.Let(rate => col.Item().Field("Payment Exchange Rate", rate.CalculationRate?.Value.ToString()));
            invoice.PaymentAlternativeExchangeRate?.Let(rate => col.Item().Field("Payment Alternative Exchange Rate", rate.CalculationRate?.Value.ToString()));
        });
        return container;
    }

    public static IContainer InvoicePeriods(this IContainer container, InvoiceType invoice)
    {
        if (invoice.InvoicePeriod?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("INVOICE PERIODS");
                invoice.InvoicePeriod.ForEach(period => 
                {
                    col.Item().Date("Start Date", period.StartDate?.Value);
                    col.Item().Date("End Date", period.EndDate?.Value);
                    period.DurationMeasure?.Let(measure => col.Item().Field("Duration", $"{measure.Value} {measure.UnitCode}"));
                });
            });
        }
        return container;
    }

    public static IContainer Parties(this IContainer container, InvoiceType invoice)
    {
        container.Column(col =>
        {
            col.Item().SectionHeading("PARTIES");
            
            // Payee Party
            if (invoice.PayeeParty != null)
            {
                col.Item().Text("Payee Party").Bold();
                col.Item().Party(invoice.PayeeParty);
            }
            
            // Buyer Customer Party
            if (invoice.BuyerCustomerParty != null)
            {
                col.Item().Text("Buyer Customer Party").Bold();
                col.Item().Party(invoice.BuyerCustomerParty.Party);
            }
            
            // Seller Supplier Party
            if (invoice.SellerSupplierParty != null)
            {
                col.Item().Text("Seller Supplier Party").Bold();
                col.Item().Party(invoice.SellerSupplierParty.Party);
            }
            
            // Tax Representative Party
            if (invoice.TaxRepresentativeParty != null)
            {
                col.Item().Text("Tax Representative Party").Bold();
                col.Item().Party(invoice.TaxRepresentativeParty);
            }
        });
        return container;
    }

    public static IContainer Delivery(this IContainer container, InvoiceType invoice)
    {
        if (invoice.Delivery?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("DELIVERY INFORMATION");
                invoice.Delivery.ForEach(delivery => 
                {
                    col.Item().Date("Actual Delivery Date", delivery.ActualDeliveryDate?.Value);
                    col.Item().Date("Actual Delivery Time", delivery.ActualDeliveryTime?.Value);
                    col.Item().Field("Delivery ID", delivery.Id?.Value);
                    col.Item().Field("Tracking ID", delivery.TrackingId?.Value);
                    if (delivery.DeliveryAddress != null)
                    {
                        col.Item().Text("Delivery Address").Bold();
                        col.Item().Address(delivery.DeliveryAddress);
                    }
                    if (delivery.DeliveryParty != null)
                    {
                        col.Item().Text("Delivery Party").Bold();
                        col.Item().Party(delivery.DeliveryParty);
                    }
                });
            });
        }
        return container;
    }

    public static IContainer DeliveryTerms(this IContainer container, InvoiceType invoice)
    {
        if (invoice.DeliveryTerms != null)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("DELIVERY TERMS");
                col.Item().Field("Special Terms", invoice.DeliveryTerms.SpecialTerms?.Select(term => term.Value).Join(", "));
                col.Item().Field("Loss Risk Responsibility Code", invoice.DeliveryTerms.LossRiskResponsibilityCode?.Value);
                col.Item().Field("Loss Risk", invoice.DeliveryTerms.LossRisk?.Select(risk => risk.Value).Join(", "));
                col.Item().Field("Amount", invoice.DeliveryTerms.Amount?.Value.ToString());
                col.Item().Field("Allowance Charge", invoice.DeliveryTerms.AllowanceCharge?.Amount?.Value.ToString());
                if (invoice.DeliveryTerms.DeliveryLocation?.Address != null)
                {
                    col.Item().Text("Delivery Location").Bold();
                    col.Item().Address(invoice.DeliveryTerms.DeliveryLocation.Address);
                }
            });
        }
        return container;
    }

    public static IContainer PaymentMeans(this IContainer container, InvoiceType invoice)
    {
        if (invoice.PaymentMeans?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("PAYMENT MEANS");
                invoice.PaymentMeans.ForEach(payment => 
                {
                    col.Item().Field("Payment Means Code", payment.PaymentMeansCode?.Value);
                    col.Item().Date("Payment Due Date", payment.PaymentDueDate?.Value);
                    col.Item().Field("Payment Channel Code", payment.PaymentChannelCode?.Value);
                    col.Item().Field("Instruction ID", payment.InstructionId?.Value);
                    col.Item().Field("Instruction Note", payment.InstructionNote?.Select(note => note.Value).Join(", "));
                    col.Item().Field("Payment ID", payment.PaymentId?.Select(id => id.Value).Join(", "));
                    if (payment.PayeeFinancialAccount != null)
                    {
                        col.Item().Text("Payee Financial Account").Bold();
                        col.Item().Field("Account ID", payment.PayeeFinancialAccount.Id?.Value);
                        col.Item().Field("Account Name", payment.PayeeFinancialAccount.Name?.Value);
                        col.Item().Field("Account Type Code", payment.PayeeFinancialAccount.FinancialInstitutionBranch?.FinancialInstitution?.Name?.Value);
                    }
                });
            });
        }
        return container;
    }

    public static IContainer PaymentTerms(this IContainer container, InvoiceType invoice)
    {
        if (invoice.PaymentTerms?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("PAYMENT TERMS");
                invoice.PaymentTerms.ForEach(term => 
                {
                    col.Item().Field("Note", term.Note?.Select(note => note.Value).Join(", "));
                    col.Item().Field("Penalty Surcharge Percent", term.PenaltySurchargePercent?.Value.ToString());
                    col.Item().Field("Penalty Amount", term.PenaltyAmount?.Value.ToString());
                });
            });
        }
        return container;
    }

    public static IContainer PrepaidPayments(this IContainer container, InvoiceType invoice)
    {
        if (invoice.PrepaidPayment?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("PREPAID PAYMENTS");
                invoice.PrepaidPayment.ForEach(payment => 
                {
                    col.Item().Field("ID", payment.Id?.Value);
                    col.Item().Field("Paid Amount", payment.PaidAmount?.Value.ToString());
                    col.Item().Date("Received Date", payment.ReceivedDate?.Value);
                    col.Item().Date("Paid Date", payment.PaidDate?.Value);
                    col.Item().Field("Instruction ID", payment.InstructionId?.Value);
                });
            });
        }
        return container;
    }

    public static IContainer AllowanceCharges(this IContainer container, InvoiceType invoice)
    {
        if (invoice.AllowanceCharge?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("ALLOWANCE CHARGES");
                invoice.AllowanceCharge.ForEach(charge => 
                {
                    col.Item().Field("Charge Indicator", charge.ChargeIndicator?.Value.ToString());
                    col.Item().Field("Allowance Charge Reason Code", charge.AllowanceChargeReasonCode?.Value);
                    col.Item().Field("Allowance Charge Reason", charge.AllowanceChargeReason?.Select(reason => reason.Value).Join(", "));
                    col.Item().Field("Multiplier Factor Numeric", charge.MultiplierFactorNumeric?.Value.ToString());
                    col.Item().Field("Sequence Numeric", charge.SequenceNumeric?.Value.ToString());
                    col.Item().Field("Amount", charge.Amount?.Value.ToString());
                    col.Item().Field("Base Amount", charge.BaseAmount?.Value.ToString());
                    col.Item().Field("Accounting Cost Code", charge.AccountingCostCode?.Value);
                    col.Item().Field("Accounting Cost", charge.AccountingCost?.Value);
                });
            });
        }
        return container;
    }

    public static IContainer Signatures(this IContainer container, InvoiceType invoice)
    {
        if (invoice.Signature?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("SIGNATURES");
                invoice.Signature.ForEach(signature => 
                {
                    col.Item().Field("ID", signature.Id?.Value);
                    col.Item().Field("Signature Method", signature.SignatureMethod?.Value);
                    col.Item().Field("Note", signature.Note?.Select(note => note.Value).Join(", "));
                    col.Item().Date("Validation Date", signature.ValidationDate?.Value);
                    col.Item().Field("Validation Time", signature.ValidationTime?.Value.ToString());
                    col.Item().Field("Validator ID", signature.ValidatorId?.Value);
                    col.Item().Field("Canonicalization Method", signature.CanonicalizationMethod?.Value);
                });
            });
        }
        return container;
    }
}
