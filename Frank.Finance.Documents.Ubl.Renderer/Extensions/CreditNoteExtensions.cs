using Frank.Finance.Documents.Ubl.CreditNote;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;
using System.Linq;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class CreditNoteExtensions
{
    public static IContainer CreditNoteDetails(this IContainer container, CreditNoteType creditNote)
    {
        container.Column(col =>
        {
            col.Item().Mono("Credit Note Number", creditNote.Id?.Value);
            col.Item().Mono("UUID", creditNote.Uuid?.Value);
            col.Item().Date("Issue Date", creditNote.IssueDate?.Value);
            col.Item().Date("Issue Time", creditNote.IssueTime?.Value);
            col.Item().Date("Tax Point Date", creditNote.TaxPointDate?.Value);
            col.Item().Mono("UBL Version", creditNote.UblVersionId?.Value);
            col.Item().Mono("Customization ID", creditNote.CustomizationId?.Value);
            col.Item().Mono("Profile ID", creditNote.ProfileId?.Value);
            col.Item().Mono("Profile Execution ID", creditNote.ProfileExecutionId?.Value);
            col.Item().Field("Copy Indicator", creditNote.CopyIndicator?.Value.ToString());
            col.Item().Mono("Document Currency", creditNote.DocumentCurrencyCode?.Value);
            col.Item().Mono("Tax Currency", creditNote.TaxCurrencyCode?.Value);
            col.Item().Mono("Pricing Currency", creditNote.PricingCurrencyCode?.Value);
            col.Item().Mono("Payment Currency", creditNote.PaymentCurrencyCode?.Value);
            col.Item().Mono("Payment Alternative Currency", creditNote.PaymentAlternativeCurrencyCode?.Value);
            col.Item().Mono("Accounting Cost Code", creditNote.AccountingCostCode?.Value);
            col.Item().Field("Accounting Cost", creditNote.AccountingCost?.Value);
            col.Item().Field("Line Count", creditNote.LineCountNumeric?.Value.ToString());
            col.Item().Mono("Buyer Reference", creditNote.BuyerReference?.Value);
            creditNote.Signature?.ForEach(signature => col.Item().Mono("Signature ID", signature.Id?.Value));
            col.Spacing(5);
            col.Item().SectionHeading("DOCUMENT REFERENCES");
            creditNote.AdditionalDocumentReferenceSpecified.Let(specified => col.Item().Field("Additional Document Reference Specified", specified.ToString()));
            creditNote.AdditionalDocumentReference?.ForEach(doc => col.Item().Mono(doc.DocumentDescription.Select(desc => desc.Value).Join(" "), doc.Id?.Value));
            creditNote.ContractDocumentReference?.ForEach(doc => col.Item().Mono("Contract Document Reference", doc.Id?.Value));
            creditNote.OrderReference?.Let(orderRef => col.Item().Mono("Order Reference", orderRef.Id?.Value));
            creditNote.BillingReference?.ForEach(doc => col.Item().Mono("Billing Reference", doc.InvoiceDocumentReference?.Id?.Value));
            creditNote.DespatchDocumentReference?.ForEach(doc => col.Item().Mono(doc.DocumentDescription.Select(desc => desc.Value).Join(" "), doc.Id?.Value));
            creditNote.ReceiptDocumentReference?.ForEach(doc => col.Item().Mono(doc.DocumentDescription.Select(desc => desc.Value).Join(" "), doc.Id?.Value));
            creditNote.StatementDocumentReference?.ForEach(doc => col.Item().Mono(doc.DocumentDescription.Select(desc => desc.Value).Join(" "), doc.Id?.Value));
            col.Spacing(5);
            col.Item().SectionHeading("PAYMENT TERMS");
            creditNote.PaymentTerms?.ForEach(term => col.Item().Field(term.PaymentMeansId.Select(id => id.Value).Join(", "), term.Note?.Select(note => note.Value).Join(", ")));
        });
        return container;
    }

    public static IContainer CreditNoteTotals(this IContainer container, CreditNoteType creditNote)
    {
        container.Column(col =>
        {
            // Legal Monetary Total
            col.Item().Money("Line Extension Amount", creditNote.LegalMonetaryTotal?.LineExtensionAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
            col.Item().Money("Tax Exclusive Amount", creditNote.LegalMonetaryTotal?.TaxExclusiveAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
            col.Item().Money("Tax Inclusive Amount", creditNote.LegalMonetaryTotal?.TaxInclusiveAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
            col.Item().Money("Allowance Total Amount", creditNote.LegalMonetaryTotal?.AllowanceTotalAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
            col.Item().Money("Charge Total Amount", creditNote.LegalMonetaryTotal?.ChargeTotalAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
            col.Item().Money("Prepaid Amount", creditNote.LegalMonetaryTotal?.PrepaidAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
            col.Item().Money("Payable Rounding Amount", creditNote.LegalMonetaryTotal?.PayableRoundingAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
            col.Item().Money("Payable Amount", creditNote.LegalMonetaryTotal?.PayableAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
            
            // Tax Totals
            creditNote.TaxTotal?.ForEach((tax, index) => 
            {
                col.Item().Money($"Tax Amount {index + 1}", tax.TaxAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
                col.Item().Money($"Rounding Amount {index + 1}", tax.RoundingAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
                col.Item().Field($"Tax Evidence Indicator {index + 1}", tax.TaxEvidenceIndicator?.Value.ToString());
            });
            
            // Withholding Tax Totals
            creditNote.TaxTotal?.ForEach((tax, index) => 
            {
                col.Item().Money($"Withholding Tax Amount {index + 1}", tax.TaxAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
                col.Item().Money($"Withholding Rounding Amount {index + 1}", tax.RoundingAmount?.Value, creditNote.DocumentCurrencyCode?.Value);
            });
        });
        return container;
    }

    public static IContainer CreditNoteNotes(this IContainer container, CreditNoteType creditNote)
    {
        if (creditNote.Note?.Count > 0) 
        {
            container.Column(col =>
            {
                creditNote.Note.ForEach(note => col.Item().Text(note.Value));
            });
        }
        return container;
    }

    public static IContainer CreditNoteSummary(this IContainer container, CreditNoteType creditNote)
    {
        container.Column(col =>
        {
            col.Item().Mono("Credit Note Number", creditNote.Id?.Value);
            col.Item().Date("Issue Date", creditNote.IssueDate?.Value);
            col.Item().Field("Line Item Count", creditNote.CreditNoteLine?.Count.ToString() ?? "0");
            
            // Document References
            creditNote.OrderReference?.Let(orderRef => col.Item().Mono("Order Reference", orderRef.Id?.Value));
            creditNote.BillingReference?.ForEach(doc => col.Item().Mono("Billing Reference", doc.InvoiceDocumentReference?.Id?.Value));
            creditNote.DespatchDocumentReference?.ForEach(doc => col.Item().Mono("Despatch Document Reference", doc.Id?.Value));
            creditNote.ReceiptDocumentReference?.ForEach(doc => col.Item().Mono("Receipt Document Reference", doc.Id?.Value));
            creditNote.StatementDocumentReference?.ForEach(doc => col.Item().Mono("Statement Document Reference", doc.Id?.Value));
            creditNote.OriginatorDocumentReference?.ForEach(doc => col.Item().Mono("Originator Document Reference", doc.Id?.Value));
            creditNote.ContractDocumentReference?.ForEach(doc => col.Item().Mono("Contract Document Reference", doc.Id?.Value));
            creditNote.AdditionalDocumentReference?.ForEach(doc => col.Item().Mono("Additional Document Reference", doc.Id?.Value));
            
            // Exchange Rates
            creditNote.TaxExchangeRate?.Let(rate => col.Item().Field("Tax Exchange Rate", rate.CalculationRate?.Value.ToString()));
            creditNote.PricingExchangeRate?.Let(rate => col.Item().Field("Pricing Exchange Rate", rate.CalculationRate?.Value.ToString()));
            creditNote.PaymentExchangeRate?.Let(rate => col.Item().Field("Payment Exchange Rate", rate.CalculationRate?.Value.ToString()));
            creditNote.PaymentAlternativeExchangeRate?.Let(rate => col.Item().Field("Payment Alternative Exchange Rate", rate.CalculationRate?.Value.ToString()));
        });
        return container;
    }

    public static IContainer CreditNoteSignatures(this IContainer container, CreditNoteType creditNote)
    {
        if (creditNote.Signature?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("SIGNATURES");
                creditNote.Signature.ForEach(signature => 
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

    public static IContainer CreditNotePeriods(this IContainer container, CreditNoteType creditNote)
    {
        // CreditNote doesn't have CreditNotePeriod property
        return container;
    }

    public static IContainer CreditNoteParties(this IContainer container, CreditNoteType creditNote)
    {
        container.Column(col =>
        {
            col.Item().SectionHeading("PARTIES");
            
            // Payee Party
            if (creditNote.PayeeParty != null)
            {
                col.Item().Text("Payee Party").Bold();
                col.Item().Party(creditNote.PayeeParty);
            }
            
            // Buyer Customer Party
            if (creditNote.BuyerCustomerParty != null)
            {
                col.Item().Text("Buyer Customer Party").Bold();
                col.Item().Party(creditNote.BuyerCustomerParty.Party);
            }
            
            // Seller Supplier Party
            if (creditNote.SellerSupplierParty != null)
            {
                col.Item().Text("Seller Supplier Party").Bold();
                col.Item().Party(creditNote.SellerSupplierParty.Party);
            }
            
            // Tax Representative Party
            if (creditNote.TaxRepresentativeParty != null)
            {
                col.Item().Text("Tax Representative Party").Bold();
                col.Item().Party(creditNote.TaxRepresentativeParty);
            }
        });
        return container;
    }

    public static IContainer CreditNoteDelivery(this IContainer container, CreditNoteType creditNote)
    {
        if (creditNote.Delivery?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("DELIVERY INFORMATION");
                creditNote.Delivery.ForEach(delivery => 
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

    public static IContainer CreditNoteDeliveryTerms(this IContainer container, CreditNoteType creditNote)
    {
        if (creditNote.DeliveryTerms?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("DELIVERY TERMS");
                creditNote.DeliveryTerms.ForEach(terms =>
                {
                    col.Item().Field("Special Terms", terms.SpecialTerms?.Select(term => term.Value).Join(", "));
                    col.Item().Field("Loss Risk Responsibility Code", terms.LossRiskResponsibilityCode?.Value);
                    col.Item().Field("Loss Risk", terms.LossRisk?.Select(risk => risk.Value).Join(", "));
                    col.Item().Field("Amount", terms.Amount?.Value.ToString());
                    col.Item().Field("Allowance Charge", terms.AllowanceCharge?.Amount?.Value.ToString());
                    if (terms.DeliveryLocation?.Address != null)
                    {
                        col.Item().Text("Delivery Location").Bold();
                        col.Item().Address(terms.DeliveryLocation.Address);
                    }
                });
            });
        }
        return container;
    }

    public static IContainer CreditNotePaymentMeans(this IContainer container, CreditNoteType creditNote)
    {
        if (creditNote.PaymentMeans?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("PAYMENT MEANS");
                creditNote.PaymentMeans.ForEach(payment => 
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

    public static IContainer CreditNotePaymentTerms(this IContainer container, CreditNoteType creditNote)
    {
        if (creditNote.PaymentTerms?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("PAYMENT TERMS");
                creditNote.PaymentTerms.ForEach(term => 
                {
                    col.Item().Field("Note", term.Note?.Select(note => note.Value).Join(", "));
                    col.Item().Field("Penalty Surcharge Percent", term.PenaltySurchargePercent?.Value.ToString());
                    col.Item().Field("Penalty Amount", term.PenaltyAmount?.Value.ToString());
                });
            });
        }
        return container;
    }

    public static IContainer CreditNotePrepaidPayments(this IContainer container, CreditNoteType creditNote)
    {
        // CreditNote doesn't have PrepaidPayment property
        return container;
    }

    public static IContainer CreditNoteAllowanceCharges(this IContainer container, CreditNoteType creditNote)
    {
        if (creditNote.AllowanceCharge?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("ALLOWANCE CHARGES");
                creditNote.AllowanceCharge.ForEach(charge => 
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
}
