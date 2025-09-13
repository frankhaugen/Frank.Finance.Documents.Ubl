using System.Globalization;
using Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents;
using Frank.Finance.Documents.Ubl.Invoice;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Frank.Finance.Documents.Ubl.Renderer;

public static class UblDocumentExtensions
{
    // Field DSL
    public static IContainer Field(this IContainer container, string label, string? value)
    {
        container.Component(new TextField(label, value));
        return container;
    }

    public static IContainer Money(this IContainer container, string label, decimal? amount, string? currencyCode = null)
    {
        container.Component(new MoneyField(label, amount, currencyCode));
        return container;
    }

    public static IContainer Date(this IContainer container, string label, DateTime? date)
    {
        container.Component(new DateField(label, date));
        return container;
    }

    public static IContainer Mono(this IContainer container, string label, string? value)
    {
        container.Component(new MonospaceField(label, value));
        return container;
    }

    public static IContainer Percent(this IContainer container, string label, decimal? value)
    {
        container.Component(new PercentageField(label, value));
        return container;
    }

    // Section DSL
    public static IContainer SectionHeading(this IContainer container, string title)
    {
        container.Text(title).Bold().Underline().FontColor(Colors.Blue.Darken2);
        return container;
    }

    public static IContainer SectionContent(this IContainer container, Action<ColumnDescriptor> content)
    {
        container.PaddingBottom(10).Column(content);
        return container;
    }

    public static IContainer Section(this IContainer container, string title, Action<ColumnDescriptor> content)
    {
        container.SectionHeading(title).SectionContent(content);
        return container;
    }

    // Layout DSL
    public static IContainer ThreeCol(this IContainer container, Action<IContainer> col1, Action<IContainer> col2, Action<IContainer> col3)
    {
        container.Row(row =>
        {
            row.RelativeItem().Element(col1);
            row.RelativeItem().Element(col2);
            row.RelativeItem().Element(col3);
        });
        return container;
    }

    public static IContainer TwoCol(this IContainer container, Action<IContainer> left, Action<IContainer> right)
    {
        container.Row(row =>
        {
            row.RelativeItem().Element(left);
            row.RelativeItem().Element(right);
        });
        return container;
    }

    // Party DSL
    public static IContainer Party(this IContainer container, PartyType? party)
    {
        if (party != null)
        {
            container.Column(col =>
            {
                if (party.PartyName?.Count > 0) 
                    col.Item().Text(party.PartyName[0].Name.Value).Bold();
                
                party.PartyIdentification?.ForEach(id => 
                    col.Item().Mono("Party ID", id.Id?.Value));
                
                if (party.PostalAddress != null) 
                    col.Item().Address(party.PostalAddress);
                
                if (party.Contact != null)
                {
                    col.Item().Field("Contact Name", party.Contact.Name?.Value);
                    col.Item().Mono("Telephone", party.Contact.Telephone?.Value);
                    col.Item().Mono("Email", party.Contact.ElectronicMail?.Value);
                }
            });
        }
        return container;
    }

    public static IContainer Address(this IContainer container, AddressType? address)
    {
        if (address != null)
        {
            container.Column(col =>
            {
                address.StreetName?.Value?.Let(v => col.Item().Text(v));
                address.AdditionalStreetName?.Value?.Let(v => col.Item().Text(v));
                address.BuildingNumber?.Value?.Let(v => col.Item().Text(v));
                address.CityName?.Value?.Let(v => col.Item().Text(v));
                address.PostalZone?.Value?.Let(v => col.Item().Text(v));
                address.Country?.IdentificationCode?.Value?.Let(v => col.Item().Text(v));
            });
        }
        return container;
    }

    // Invoice DSL
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

    // Table DSL
    public static IContainer InvoiceTable(this IContainer container, InvoiceType invoice, RenderContext context)
    {
        if (invoice.InvoiceLine?.Count > 0)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(0.5f);
                    columns.RelativeColumn(1.5f);
                    columns.RelativeColumn(4.0f);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn(0.8f);
                });
                table.Header(header =>
                {
                    header.Cell().Element(HeaderCellStyle).AlignLeft().Text("#");
                    header.Cell().Element(HeaderCellStyle).AlignLeft().Text("Artikkelnummer");
                    header.Cell().Element(HeaderCellStyle).AlignLeft().Text("Beskrivelse");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("Enhetspris");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("Antall Enhet");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("Mva");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("Netto");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("Mva %");
                });
                invoice.InvoiceLine.ForEach((line, index) => table.AddLine(line, index + 1, context));
            });
        }
        else 
        {
            container.Text("No line items available").FontColor(Colors.Grey.Medium);
        }
        return container;
    }

    // Table extensions
    public static void AddLine(this TableDescriptor table, InvoiceLineType line, int lineNumber, RenderContext context)
    {
        var description = line.Item?.Description?.Count > 0 ? line.Item.Description[0]?.Value : "";
        var articleNumber = line.Item?.SellersItemIdentification?.Id?.Value ?? "";
        var unitCode = line.InvoicedQuantity?.UnitCode ?? "";
        var quantity = line.InvoicedQuantity?.Value ?? 0;
        var vatPercent = line.Item?.ClassifiedTaxCategory?.FirstOrDefault()?.Percent?.Value ?? 0;
        var unitPrice = line.Price?.PriceAmount?.Value ?? 0;
        var lineTotal = line.LineExtensionAmount?.Value ?? 0;
        var vatAmount = lineTotal * (vatPercent / 100);

        table.Cell().Element(ItemCellStyle).AlignLeft().Text(lineNumber.ToString());
        table.Cell().Element(ItemCellStyle).AlignLeft().Text(articleNumber);
        table.Cell().Element(ItemCellStyle).AlignLeft().Text(description).Bold();
        table.Cell().Element(ItemCellStyle).AlignRight().Text(FormatCurrency(unitPrice, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text($"{quantity:F2} {unitCode}");
        table.Cell().Element(ItemCellStyle).AlignRight().Text(FormatCurrency(vatAmount, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text(FormatCurrency(lineTotal, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text($"{vatPercent:F2}%");
        table.Cell().ColumnSpan(8).Component(new LineDetailsComponent(line, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().ColumnSpan(8).Element(ItemCellStyle).PaddingBottom(5).LineHorizontal(0.5f);
    }

    // Style methods
    public static IContainer ItemCellStyle(this IContainer container)
    {
        return container.PaddingVertical(3).PaddingHorizontal(4);
    }

    public static IContainer HeaderCellStyle(this IContainer container)
    {
        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
    }

    // Helper extensions
    public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
    {
        foreach (var item in items) action(item);
    }

    public static void ForEach<T>(this IEnumerable<T> items, Action<T, int> action)
    {
        var index = 0;
        foreach (var item in items) action(item, index++);
    }

    public static void Let<T>(this T? value, Action<T> action)
    {
        if (value != null) action(value);
    }

    private static string FormatCurrency(decimal amount, string? currencyCode = null)
    {
        var culture = CultureInfo.CurrentCulture;
        var formatted = amount.ToString("C", culture);
        if (!string.IsNullOrEmpty(currencyCode) && !formatted.Contains(currencyCode))
            formatted = $"{currencyCode} {formatted}";
        return formatted;
    }
}