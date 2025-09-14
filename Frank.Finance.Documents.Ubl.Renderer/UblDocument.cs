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
            col.Item().Element(ComposeInvoicePeriodsSection);
            col.Item().Element(ComposePartiesSection);
            col.Item().Element(ComposeDeliverySection);
            col.Item().Element(ComposeDeliveryTermsSection);
            col.Item().Element(ComposePaymentMeansSection);
            col.Item().Element(ComposePaymentTermsSection);
            col.Item().Element(ComposePrepaidPaymentsSection);
            col.Item().Element(ComposeAllowanceChargesSection);
            col.Item().Element(ComposeNotesSection);
            col.Item().Element(ComposeTotalsSection);
            col.Item().Element(ComposeLineItemsTable);
            col.Item().Element(ComposeSignaturesSection);
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
            col.Item().Notes(context.Invoice!);
        });
    }

    private void ComposeTotalsSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().SectionHeading("TOTALS");
            col.Item().Totals(context.Invoice!);
        });
    }

    private void ComposeLineItemsTable(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().SectionHeading("LINE ITEMS");
            col.Item().InvoiceTable(context.Invoice!, context);
        });
    }

    private void ComposeInvoicePeriodsSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().InvoicePeriods(context.Invoice!);
        });
    }

    private void ComposePartiesSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().Parties(context.Invoice!);
        });
    }

    private void ComposeDeliverySection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().Delivery(context.Invoice!);
        });
    }

    private void ComposeDeliveryTermsSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().DeliveryTerms(context.Invoice!);
        });
    }

    private void ComposePaymentMeansSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().PaymentMeans(context.Invoice!);
        });
    }

    private void ComposePaymentTermsSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().PaymentTerms(context.Invoice!);
        });
    }

    private void ComposePrepaidPaymentsSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().PrepaidPayments(context.Invoice!);
        });
    }

    private void ComposeAllowanceChargesSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().AllowanceCharges(context.Invoice!);
        });
    }

    private void ComposeSignaturesSection(IContainer container)
    {
        container.Column(col =>
        {
            col.Item().Signatures(context.Invoice!);
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
}