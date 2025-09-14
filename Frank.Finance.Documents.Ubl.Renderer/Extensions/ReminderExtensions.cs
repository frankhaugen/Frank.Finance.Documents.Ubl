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
}
