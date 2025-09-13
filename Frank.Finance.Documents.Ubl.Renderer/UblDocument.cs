using System.Globalization;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

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
                column.Item().Text("INVOICE").Bold().FontColor(Colors.Blue.Darken2);

                if (context.Invoice?.InvoiceTypeCode?.Value != null)
                    column.Item().Text($" - {context.Invoice.InvoiceTypeCode.Value}")
                        .FontColor(Colors.Grey.Darken1);
            });
    }

    private void ComposeContent(IContainer container)
    {
        if (context.Invoice == null) return;
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
                col.Item().SectionHeading("SUPPLIER");
                col.Item().Party(context.Invoice?.AccountingSupplierParty?.Party);
            });
            row.RelativeItem().Column(col => 
            {
                col.Item().SectionHeading("CUSTOMER");
                col.Item().Party(context.Invoice?.AccountingCustomerParty?.Party);
            });
            row.RelativeItem().Column(col => 
            {
                col.Item().SectionHeading("INVOICE DETAILS");
                col.Item().InvoiceDetails(context.Invoice!);
            });
        });
    }


    private void ComposeNotesSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().SectionHeading("NOTES");
            col.Item().Notes(context.Invoice!).PaddingBottom(7);
        });
    }

    private void ComposeTotalsSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().SectionHeading("TOTALS");
            col.Item().Totals(context.Invoice!).PaddingBottom(7);
        });
    }

    private void ComposeLineItemsTable(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().SectionHeading("LINE ITEMS");
            col.Item().InvoiceTable(context.Invoice!, context).PaddingBottom(7);
        });
    }

    private void ComposeSummarySection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().SectionHeading("SUMMARY");
            col.Item().Summary(context.Invoice!);
        });
    }

    private void ComposeFooter(IContainer container)
    {
        container
            .AlignCenter()
            .Text(x =>
            {
                x.Span("Page ");
                x.CurrentPageNumber();
                x.Span(" of ");
                x.TotalPages();
            });
    }

    private string FormatCurrency(decimal amount, string? currencyCode = null)
    {
        var culture = CultureInfo.CurrentCulture;
        var formatted = amount.ToString("C", culture);

        if (!string.IsNullOrEmpty(currencyCode) && !formatted.Contains(currencyCode)) formatted = $"{currencyCode} {formatted}";

        return formatted;
    }
}

// Field component system for consistent label-value display

// Comprehensive DSL extension methods