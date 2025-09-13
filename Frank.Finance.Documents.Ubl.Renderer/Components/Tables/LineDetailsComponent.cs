using Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;
using Frank.Finance.Documents.Ubl.Renderer.Extensions;

namespace Frank.Finance.Documents.Ubl.Renderer.Components.Tables;

public class LineDetailsComponent(InvoiceLineType? line, string? currencyCode) : IComponent
{
    public void Compose(IContainer container)
    {
        if (line == null) return;

        container.Padding(5).Border(1).BorderColor(Colors.Grey.Lighten2).Background(Colors.Grey.Lighten4).Column(col =>
        {
            col.Item().Text("See additional line properties").Bold().FontColor(Colors.Grey.Darken1);
            col.Item().Row(row =>
            {
                row.RelativeItem().Column(left =>
                {
                    left.Item().Text("Item Details").Bold().FontColor(Colors.Blue.Darken2);
                    line.Item?.SellersItemIdentification?.Id?.Value?.Let(v => left.Item().Element(c => c.Field("SellersItemIdentification", v)));
                    line.Item?.StandardItemIdentification?.Id?.Value?.Let(v => left.Item().Element(c => c.Field("StandardItemIdentification", v)));
                    line.Item?.Name?.Value?.Let(v => left.Item().Element(c => c.Field("Item Name", v)));
                });
                row.RelativeItem().Column(middle =>
                {
                    middle.Item().Text("Period & References").Bold().FontColor(Colors.Blue.Darken2);
                    line.InvoicePeriod?.ForEach(period =>
                    {
                        middle.Item().Element(c => c.Date("Start Date", period.StartDate?.Value));
                        middle.Item().Element(c => c.Date("End Date", period.EndDate?.Value));
                    });
                    line.DocumentReference?.ForEach(doc =>
                    {
                        middle.Item().Element(c => c.Mono("Document ID", doc.Id?.Value));
                        middle.Item().Element(c => c.Mono("Document Type", doc.DocumentTypeCode?.Value));
                    });
                });
                row.RelativeItem().Column(right =>
                {
                    right.Item().Text("Tax & Charges").Bold().FontColor(Colors.Blue.Darken2);
                    line.Item?.ClassifiedTaxCategory?.ForEach(tax =>
                    {
                        right.Item().Element(c => c.Mono("Tax ID", tax.Id?.Value));
                        right.Item().Element(c => c.Percent("Tax Rate", tax.Percent?.Value));
                        right.Item().Element(c => c.Mono("Tax Scheme", tax.TaxScheme?.Id?.Value));
                    });
                    line.AllowanceCharge?.ForEach(allowance =>
                    {
                        right.Item().Element(c => c.Field("Charge Indicator", allowance.ChargeIndicator.Value.ToString()));
                        right.Item().Element(c => c.Money("Amount", allowance.Amount?.Value, currencyCode));
                        right.Item().Element(c => c.Money("Base Amount", allowance.BaseAmount?.Value, currencyCode));
                    });
                });
            });
        });
    }
}
