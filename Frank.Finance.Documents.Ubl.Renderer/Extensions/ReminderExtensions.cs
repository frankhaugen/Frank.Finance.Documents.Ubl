using Frank.Finance.Documents.Ubl.Reminder;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;
using System.Linq;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class ReminderExtensions
{
    public static IContainer ReminderDetails(this IContainer container, ReminderType reminder)
    {
        container.Column(col =>
        {
            col.Item().Mono("Reminder Number", reminder.Id?.Value);
            col.Item().Mono("UUID", reminder.Uuid?.Value);
            col.Item().Date("Issue Date", reminder.IssueDate?.Value);
            col.Item().Date("Issue Time", reminder.IssueTime?.Value);
            col.Item().Date("Tax Point Date", reminder.TaxPointDate?.Value);
            col.Item().Mono("UBL Version", reminder.UblVersionId?.Value);
            col.Item().Mono("Customization ID", reminder.CustomizationId?.Value);
            col.Item().Mono("Profile ID", reminder.ProfileId?.Value);
            col.Item().Mono("Profile Execution ID", reminder.ProfileExecutionId?.Value);
            col.Item().Field("Copy Indicator", reminder.CopyIndicator?.Value.ToString());
            col.Item().Mono("Document Currency", reminder.DocumentCurrencyCode?.Value);
            col.Item().Mono("Tax Currency", reminder.TaxCurrencyCode?.Value);
            col.Item().Mono("Pricing Currency", reminder.PricingCurrencyCode?.Value);
            col.Item().Mono("Payment Currency", reminder.PaymentCurrencyCode?.Value);
            col.Item().Mono("Payment Alternative Currency", reminder.PaymentAlternativeCurrencyCode?.Value);
            col.Item().Mono("Accounting Cost Code", reminder.AccountingCostCode?.Value);
            col.Item().Field("Accounting Cost", reminder.AccountingCost?.Value);
            col.Item().Field("Line Count", reminder.LineCountNumeric?.Value.ToString());
            col.Item().Field("Reminder Sequence", reminder.ReminderSequenceNumeric?.Value.ToString());
            col.Item().Field("Reminder Type Code", reminder.ReminderTypeCode?.Value);
            reminder.Signature?.ForEach(signature => col.Item().Mono("Signature ID", signature.Id?.Value));
            col.Spacing(5);
            col.Item().SectionHeading("DOCUMENT REFERENCES");
            reminder.AdditionalDocumentReferenceSpecified.Let(specified => col.Item().Field("Additional Document Reference Specified", specified.ToString()));
            reminder.AdditionalDocumentReference?.ForEach(doc => col.Item().Mono(doc.DocumentDescription.Select(desc => desc.Value).Join(" "), doc.Id?.Value));
            col.Spacing(5);
            col.Item().SectionHeading("PAYMENT TERMS");
            reminder.PaymentTerms?.ForEach(term => col.Item().Field(term.PaymentMeansId.Select(id => id.Value).Join(", "), term.Note?.Select(note => note.Value).Join(", ")));
        });
        return container;
    }

    public static IContainer ReminderTotals(this IContainer container, ReminderType reminder)
    {
        container.Column(col =>
        {
            // Legal Monetary Total
            col.Item().Money("Line Extension Amount", reminder.LegalMonetaryTotal?.LineExtensionAmount?.Value, reminder.DocumentCurrencyCode?.Value);
            col.Item().Money("Tax Exclusive Amount", reminder.LegalMonetaryTotal?.TaxExclusiveAmount?.Value, reminder.DocumentCurrencyCode?.Value);
            col.Item().Money("Tax Inclusive Amount", reminder.LegalMonetaryTotal?.TaxInclusiveAmount?.Value, reminder.DocumentCurrencyCode?.Value);
            col.Item().Money("Allowance Total Amount", reminder.LegalMonetaryTotal?.AllowanceTotalAmount?.Value, reminder.DocumentCurrencyCode?.Value);
            col.Item().Money("Charge Total Amount", reminder.LegalMonetaryTotal?.ChargeTotalAmount?.Value, reminder.DocumentCurrencyCode?.Value);
            col.Item().Money("Prepaid Amount", reminder.LegalMonetaryTotal?.PrepaidAmount?.Value, reminder.DocumentCurrencyCode?.Value);
            col.Item().Money("Payable Rounding Amount", reminder.LegalMonetaryTotal?.PayableRoundingAmount?.Value, reminder.DocumentCurrencyCode?.Value);
            col.Item().Money("Payable Amount", reminder.LegalMonetaryTotal?.PayableAmount?.Value, reminder.DocumentCurrencyCode?.Value);
            
            // Tax Totals
            reminder.TaxTotal?.ForEach((tax, index) => 
            {
                col.Item().Money($"Tax Amount {index + 1}", tax.TaxAmount?.Value, reminder.DocumentCurrencyCode?.Value);
                col.Item().Money($"Rounding Amount {index + 1}", tax.RoundingAmount?.Value, reminder.DocumentCurrencyCode?.Value);
                col.Item().Field($"Tax Evidence Indicator {index + 1}", tax.TaxEvidenceIndicator?.Value.ToString());
            });
            
            // Withholding Tax Totals
            reminder.TaxTotal?.ForEach((tax, index) => 
            {
                col.Item().Money($"Withholding Tax Amount {index + 1}", tax.TaxAmount?.Value, reminder.DocumentCurrencyCode?.Value);
                col.Item().Money($"Withholding Rounding Amount {index + 1}", tax.RoundingAmount?.Value, reminder.DocumentCurrencyCode?.Value);
            });
        });
        return container;
    }

    public static IContainer ReminderNotes(this IContainer container, ReminderType reminder)
    {
        if (reminder.Note?.Count > 0) 
        {
            container.Column(col =>
            {
                reminder.Note.ForEach(note => col.Item().Text(note.Value));
            });
        }
        return container;
    }

    public static IContainer ReminderSummary(this IContainer container, ReminderType reminder)
    {
        container.Column(col =>
        {
            col.Item().Mono("Reminder Number", reminder.Id?.Value);
            col.Item().Date("Issue Date", reminder.IssueDate?.Value);
            col.Item().Field("Line Item Count", reminder.ReminderLine?.Count.ToString() ?? "0");
            col.Item().Field("Reminder Sequence", reminder.ReminderSequenceNumeric?.Value.ToString());
            col.Item().Field("Reminder Type Code", reminder.ReminderTypeCode?.Value);
            
            // Document References
            reminder.AdditionalDocumentReference?.ForEach(doc => col.Item().Mono("Additional Document Reference", doc.Id?.Value));
            
            // Exchange Rates
            reminder.TaxExchangeRate?.Let(rate => col.Item().Field("Tax Exchange Rate", rate.CalculationRate?.Value.ToString()));
            reminder.PricingExchangeRate?.Let(rate => col.Item().Field("Pricing Exchange Rate", rate.CalculationRate?.Value.ToString()));
            reminder.PaymentExchangeRate?.Let(rate => col.Item().Field("Payment Exchange Rate", rate.CalculationRate?.Value.ToString()));
            reminder.PaymentAlternativeExchangeRate?.Let(rate => col.Item().Field("Payment Alternative Exchange Rate", rate.CalculationRate?.Value.ToString()));
        });
        return container;
    }

    public static IContainer ReminderSignatures(this IContainer container, ReminderType reminder)
    {
        if (reminder.Signature?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("SIGNATURES");
                reminder.Signature.ForEach(signature => 
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

    public static IContainer ReminderPeriods(this IContainer container, ReminderType reminder)
    {
        if (reminder.ReminderPeriod?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("REMINDER PERIODS");
                reminder.ReminderPeriod.ForEach(period => 
                {
                    col.Item().Date("Start Date", period.StartDate?.Value);
                    col.Item().Date("End Date", period.EndDate?.Value);
                    period.DurationMeasure?.Let(measure => col.Item().Field("Duration", $"{measure.Value} {measure.UnitCode}"));
                });
            });
        }
        return container;
    }

    public static IContainer ReminderParties(this IContainer container, ReminderType reminder)
    {
        container.Column(col =>
        {
            col.Item().SectionHeading("PARTIES");
            
            // Payee Party
            if (reminder.PayeeParty != null)
            {
                col.Item().Text("Payee Party").Bold();
                col.Item().Party(reminder.PayeeParty);
            }
            
            // Accounting Customer Party
            if (reminder.AccountingCustomerParty != null)
            {
                col.Item().Text("Accounting Customer Party").Bold();
                col.Item().Party(reminder.AccountingCustomerParty.Party);
            }
            
            // Accounting Supplier Party
            if (reminder.AccountingSupplierParty != null)
            {
                col.Item().Text("Accounting Supplier Party").Bold();
                col.Item().Party(reminder.AccountingSupplierParty.Party);
            }
            
            // Tax Representative Party
            if (reminder.TaxRepresentativeParty != null)
            {
                col.Item().Text("Tax Representative Party").Bold();
                col.Item().Party(reminder.TaxRepresentativeParty);
            }
        });
        return container;
    }

    public static IContainer ReminderDelivery(this IContainer container, ReminderType reminder)
    {
        // Reminder doesn't have Delivery property
        return container;
    }

    public static IContainer ReminderDeliveryTerms(this IContainer container, ReminderType reminder)
    {
        // Reminder doesn't have DeliveryTerms property
        return container;
    }

    public static IContainer ReminderPaymentMeans(this IContainer container, ReminderType reminder)
    {
        if (reminder.PaymentMeans?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("PAYMENT MEANS");
                reminder.PaymentMeans.ForEach(payment => 
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

    public static IContainer ReminderPaymentTerms(this IContainer container, ReminderType reminder)
    {
        if (reminder.PaymentTerms?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("PAYMENT TERMS");
                reminder.PaymentTerms.ForEach(term => 
                {
                    col.Item().Field("Note", term.Note?.Select(note => note.Value).Join(", "));
                    col.Item().Field("Penalty Surcharge Percent", term.PenaltySurchargePercent?.Value.ToString());
                    col.Item().Field("Penalty Amount", term.PenaltyAmount?.Value.ToString());
                });
            });
        }
        return container;
    }

    public static IContainer ReminderPrepaidPayments(this IContainer container, ReminderType reminder)
    {
        if (reminder.PrepaidPayment?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("PREPAID PAYMENTS");
                reminder.PrepaidPayment.ForEach(payment => 
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

    public static IContainer ReminderAllowanceCharges(this IContainer container, ReminderType reminder)
    {
        if (reminder.AllowanceCharge?.Count > 0)
        {
            container.Column(col =>
            {
                col.Item().SectionHeading("ALLOWANCE CHARGES");
                reminder.AllowanceCharge.ForEach(charge => 
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
