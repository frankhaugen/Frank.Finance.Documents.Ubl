using Frank.Finance.Documents.Ubl.Invoice;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class InvoiceExtensions
{
    public static IContainer InvoiceDetails(this IContainer container, InvoiceType invoice)
    {
        container.Column(col =>
        {
            col.Item().Mono("Invoice Number", invoice.Id?.Value);
            col.Item().Date("Issue Date", invoice.IssueDate?.Value);
            col.Item().Date("Due Date", invoice.DueDate?.Value);
            invoice.PaymentTerms?.ForEach(term => term.Note?.ForEach(note => col.Item().Field("Payment Terms", note.Value)));
            col.Item().Mono("Currency", invoice.DocumentCurrencyCode?.Value);
        });
        return container;
    }

    public static IContainer Totals(this IContainer container, InvoiceType invoice)
    {
        container.Column(col =>
        {
            col.Item().Money("Line Extension Amount", invoice.LegalMonetaryTotal?.LineExtensionAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Tax Exclusive Amount", invoice.LegalMonetaryTotal?.TaxExclusiveAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Tax Inclusive Amount", invoice.LegalMonetaryTotal?.TaxInclusiveAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            col.Item().Money("Payable Amount", invoice.LegalMonetaryTotal?.PayableAmount?.Value, invoice.DocumentCurrencyCode?.Value);
            invoice.TaxTotal?.ForEach(tax => col.Item().Money("Tax Amount", tax.TaxAmount?.Value, invoice.DocumentCurrencyCode?.Value));
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
            invoice.AdditionalDocumentReference?.ForEach(doc => col.Item().Mono("Document Reference", doc.Id?.Value));
        });
        return container;
    }
}
