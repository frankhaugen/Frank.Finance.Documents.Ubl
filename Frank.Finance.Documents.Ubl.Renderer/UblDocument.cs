using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Models;
using Frank.Finance.Documents.Ubl.Renderer.Extensions;

namespace Frank.Finance.Documents.Ubl.Renderer;

public class UblDocument(RenderContext context) : IDocument
{
    /// <inheritdoc />
    public void Compose(IDocumentContainer container)
    {
        container
            .Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(1, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(10));

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Element(ComposeFooter);
            });
    }

    private void ComposeHeader(IContainer container)
    {
        container
            .Row(row => { row.RelativeItem().Element(ComposeHeaderContent); });
    }

    private void ComposeHeaderContent(IContainer container)
    {
        container
            .Column(column =>
            {
                // Determine document type and get translated title
                string documentTitle = GetDocumentTitle();
                column.Item().Text(documentTitle).Bold().FontColor(Colors.Blue.Darken2);

                // Add document type code if available
                string? typeCode = GetDocumentTypeCode();
                if (typeCode != null)
                    column.Item().Text($" - {typeCode}")
                        .FontColor(Colors.Grey.Darken1);
            });
    }

    private string GetDocumentTitle()
    {
        if (context.Invoice != null)
            return context.Translator.TranslateAsync("DOCUMENT_TYPE_INVOICE", context.Language).Result;
        if (context.CreditNote != null)
            return context.Translator.TranslateAsync("DOCUMENT_TYPE_CREDIT_NOTE", context.Language).Result;
        if (context.Reminder != null)
            return context.Translator.TranslateAsync("DOCUMENT_TYPE_REMINDER", context.Language).Result;
        
        return "DOCUMENT";
    }

    private string? GetDocumentTypeCode()
    {
        return context.Invoice?.InvoiceTypeCode?.Value ?? 
               context.CreditNote?.CreditNoteTypeCode?.Value ?? 
               context.Reminder?.ReminderTypeCode?.Value;
    }

    private void ComposeContent(IContainer container)
    {
        if (context.Invoice == null && context.CreditNote == null && context.Reminder == null) return;
        
        container.Column(col =>
        {
            col.Item().Element(ComposeThreeColumnHeader);
            col.Item().Element(ComposeNotesSection);
            col.Item().Element(ComposeTotalsSection);
            col.Item().Element(ComposeLineItemsTable);
            col.Item().Element(ComposeSummarySection);
        });
    }

    private void ComposeThreeColumnHeader(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem().Column(col => 
            {
                col.Item().TranslatedSectionHeading(context.Translator, context.Language, "HEADER_SUPPLIER");
                col.Item().Party(GetSupplierParty());
                col.Item().Element(ComposeSignaturesSection);
            });
            row.RelativeItem().Column(col => 
            {
                col.Item().TranslatedSectionHeading(context.Translator, context.Language, "HEADER_CUSTOMER");
                col.Item().Party(GetCustomerParty());
                col.Item().Element(ComposeDeliverySection);
                col.Item().Element(ComposePartiesSection);
                col.Item().Element(ComposeDeliveryTermsSection);
                col.Item().Element(ComposeAllowanceChargesSection);
            });
            row.RelativeItem().Column(col => 
            {
                col.Item().TranslatedSectionHeading(context.Translator, context.Language, "HEADER_DETAILS");
                col.Item().Element(ComposeDocumentDetails);
                col.Item().Element(ComposeInvoicePeriodsSection);
                col.Item().Element(ComposePaymentMeansSection);
                col.Item().Element(ComposePaymentTermsSection);
                col.Item().Element(ComposePrepaidPaymentsSection);
            });
        });
    }

    private Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PartyType? GetSupplierParty()
    {
        return context.Invoice?.AccountingSupplierParty?.Party ?? 
               context.CreditNote?.AccountingSupplierParty?.Party ?? 
               context.Reminder?.AccountingSupplierParty?.Party;
    }

    private Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents.PartyType? GetCustomerParty()
    {
        return context.Invoice?.AccountingCustomerParty?.Party ?? 
               context.CreditNote?.AccountingCustomerParty?.Party ?? 
               context.Reminder?.AccountingCustomerParty?.Party;
    }

    private void ComposeDocumentDetails(IContainer container)
    {
        if (context.Invoice != null)
            container.InvoiceDetails(context.Invoice);
        else if (context.CreditNote != null)
            container.CreditNoteDetails(context.CreditNote);
        else if (context.Reminder != null)
            container.ReminderDetails(context.Reminder);
    }

    private void ComposeNotesSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().TranslatedSectionHeading(context.Translator, context.Language, "HEADER_NOTES");
            col.Item().Element(ComposeDocumentNotes);
        });
    }

    private void ComposeDocumentNotes(IContainer container)
    {
        if (context.Invoice != null)
            container.Notes(context.Invoice);
        else if (context.CreditNote != null)
            container.CreditNoteNotes(context.CreditNote);
        else if (context.Reminder != null)
            container.ReminderNotes(context.Reminder);
    }

    private void ComposeTotalsSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().TranslatedSectionHeading(context.Translator, context.Language, "HEADER_TOTALS");
            col.Item().Element(ComposeDocumentTotals);
        });
    }

    private void ComposeDocumentTotals(IContainer container)
    {
        if (context.Invoice != null)
            container.Totals(context.Invoice);
        else if (context.CreditNote != null)
            container.CreditNoteTotals(context.CreditNote);
        else if (context.Reminder != null)
            container.ReminderTotals(context.Reminder);
    }

    private void ComposeLineItemsTable(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().TranslatedSectionHeading(context.Translator, context.Language, "HEADER_LINE_ITEMS");
            col.Item().Element(ComposeDocumentLineItems);
        });
    }

    private void ComposeDocumentLineItems(IContainer container)
    {
        if (context.Invoice != null)
            container.InvoiceTable(context.Invoice, context);
        else if (context.CreditNote != null)
            container.CreditNoteTable(context.CreditNote, context);
        else if (context.Reminder != null)
            container.ReminderTable(context.Reminder, context);
    }

    private void ComposeInvoicePeriodsSection(IContainer container)
    {
        if (context.Invoice != null)
        {
            container.Column(col =>
            {
                col.Item().InvoicePeriods(context.Invoice);
            });
        }
        else if (context.CreditNote != null)
        {
            container.Column(col =>
            {
                col.Item().CreditNotePeriods(context.CreditNote);
            });
        }
        else if (context.Reminder != null)
        {
            container.Column(col =>
            {
                col.Item().ReminderPeriods(context.Reminder);
            });
        }
    }

    private void ComposePartiesSection(IContainer container)
    {
        if (context.Invoice != null)
        {
            container.Column(col =>
            {
                col.Item().Parties(context.Invoice);
            });
        }
        else if (context.CreditNote != null)
        {
            container.Column(col =>
            {
                col.Item().CreditNoteParties(context.CreditNote);
            });
        }
        else if (context.Reminder != null)
        {
            container.Column(col =>
            {
                col.Item().ReminderParties(context.Reminder);
            });
        }
    }

    private void ComposeDeliverySection(IContainer container)
    {
        if (context.Invoice != null)
        {
            container.Column(col =>
            {
                col.Item().Delivery(context.Invoice);
            });
        }
        else if (context.CreditNote != null)
        {
            container.Column(col =>
            {
                col.Item().CreditNoteDelivery(context.CreditNote);
            });
        }
        else if (context.Reminder != null)
        {
            container.Column(col =>
            {
                col.Item().ReminderDelivery(context.Reminder);
            });
        }
    }

    private void ComposeDeliveryTermsSection(IContainer container)
    {
        if (context.Invoice != null)
        {
            container.Column(col =>
            {
                col.Item().DeliveryTerms(context.Invoice);
            });
        }
        else if (context.CreditNote != null)
        {
            container.Column(col =>
            {
                col.Item().CreditNoteDeliveryTerms(context.CreditNote);
            });
        }
        else if (context.Reminder != null)
        {
            container.Column(col =>
            {
                col.Item().ReminderDeliveryTerms(context.Reminder);
            });
        }
    }

    private void ComposePaymentMeansSection(IContainer container)
    {
        if (context.Invoice != null)
        {
            container.Column(col =>
            {
                col.Item().PaymentMeans(context.Invoice);
            });
        }
        else if (context.CreditNote != null)
        {
            container.Column(col =>
            {
                col.Item().CreditNotePaymentMeans(context.CreditNote);
            });
        }
        else if (context.Reminder != null)
        {
            container.Column(col =>
            {
                col.Item().ReminderPaymentMeans(context.Reminder);
            });
        }
    }

    private void ComposePaymentTermsSection(IContainer container)
    {
        if (context.Invoice != null)
        {
            container.Column(col =>
            {
                col.Item().PaymentTerms(context.Invoice);
            });
        }
        else if (context.CreditNote != null)
        {
            container.Column(col =>
            {
                col.Item().CreditNotePaymentTerms(context.CreditNote);
            });
        }
        else if (context.Reminder != null)
        {
            container.Column(col =>
            {
                col.Item().ReminderPaymentTerms(context.Reminder);
            });
        }
    }

    private void ComposePrepaidPaymentsSection(IContainer container)
    {
        if (context.Invoice != null)
        {
            container.Column(col =>
            {
                col.Item().PrepaidPayments(context.Invoice);
            });
        }
        else if (context.CreditNote != null)
        {
            container.Column(col =>
            {
                col.Item().CreditNotePrepaidPayments(context.CreditNote);
            });
        }
        else if (context.Reminder != null)
        {
            container.Column(col =>
            {
                col.Item().ReminderPrepaidPayments(context.Reminder);
            });
        }
    }

    private void ComposeAllowanceChargesSection(IContainer container)
    {
        if (context.Invoice != null)
        {
            container.Column(col =>
            {
                col.Item().AllowanceCharges(context.Invoice);
            });
        }
        else if (context.CreditNote != null)
        {
            container.Column(col =>
            {
                col.Item().CreditNoteAllowanceCharges(context.CreditNote);
            });
        }
        else if (context.Reminder != null)
        {
            container.Column(col =>
            {
                col.Item().ReminderAllowanceCharges(context.Reminder);
            });
        }
    }

    private void ComposeSignaturesSection(IContainer container)
    {
        if (context.Invoice != null)
        {
            container.Column(col =>
            {
                col.Item().Signatures(context.Invoice);
            });
        }
        else if (context.CreditNote != null)
        {
            container.Column(col =>
            {
                col.Item().CreditNoteSignatures(context.CreditNote);
            });
        }
        else if (context.Reminder != null)
        {
            container.Column(col =>
            {
                col.Item().ReminderSignatures(context.Reminder);
            });
        }
    }

    private void ComposeSummarySection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().TranslatedSectionHeading(context.Translator, context.Language, "HEADER_SUMMARY");
            col.Item().Element(ComposeDocumentSummary);
        });
    }

    private void ComposeDocumentSummary(IContainer container)
    {
        if (context.Invoice != null)
            container.Summary(context.Invoice);
        else if (context.CreditNote != null)
            container.CreditNoteSummary(context.CreditNote);
        else if (context.Reminder != null)
            container.ReminderSummary(context.Reminder);
    }

    private void ComposeFooter(IContainer container)
    {
        container
            .AlignCenter()
            .Text(x =>
            {
                var pageText = context.Translator.TranslateAsync("PAGE_FOOTER", context.Language).Result;
                x.Span(pageText.Replace("{0}", "").Replace("{1}", ""));
                x.CurrentPageNumber();
                x.Span(" of ");
                x.TotalPages();
            });
    }
}