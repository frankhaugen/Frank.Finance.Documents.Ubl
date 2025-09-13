using System.Globalization;
using Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents;
using Frank.Finance.Documents.Ubl.Invoice;
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
        container.ThreeCol(
            col => col.SectionHeading("SUPPLIER").Party(context.Invoice?.AccountingSupplierParty?.Party),
            col => col.SectionHeading("CUSTOMER").Party(context.Invoice?.AccountingCustomerParty?.Party),
            col => col.SectionHeading("INVOICE DETAILS").InvoiceDetails(context.Invoice!)
        );
    }


    private void ComposeNotesSection(IContainer container)
    {
        container.SectionHeading("NOTES").Notes(context.Invoice!);
    }

    private void ComposeTotalsSection(IContainer container)
    {
        container.SectionHeading("TOTALS").Totals(context.Invoice!);
    }

    private void ComposeLineItemsTable(IContainer container)
    {
        container.SectionHeading("LINE ITEMS").InvoiceTable(context.Invoice!, context);
    }


    private void ComposeSummarySection(IContainer container)
    {
        container.SectionHeading("SUMMARY").Summary(context.Invoice!);
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
public abstract class Field(string label, string? value) : IComponent
{
    public string Label { get; } = label ?? string.Empty;
    public string Value { get; } = value ?? string.Empty;
    public bool IsEmpty => string.IsNullOrEmpty(Value);

    public void Compose(IContainer container)
    {
        if (IsEmpty) return;
        ComposeInternal(container);
    }

    protected abstract void ComposeInternal(IContainer container);
}

public class TextField(string label, string? value) : Field(label, value)
{
    protected override void ComposeInternal(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem().Text(Label).FontColor(Colors.Grey.Darken1);
            row.RelativeItem(2).Text(Value);
        });
    }
}

public class MoneyField(string label, decimal? amount, string? currencyCode = null) : Field(label, amount.HasValue ? FormatCurrency(amount.Value, currencyCode) : null)
{
    private static string FormatCurrency(decimal amount, string? currencyCode = null)
    {
        var culture = CultureInfo.CurrentCulture;
        var formatted = amount.ToString("C", culture);

        if (!string.IsNullOrEmpty(currencyCode) && !formatted.Contains(currencyCode)) formatted = $"{currencyCode} {formatted}";

        return formatted;
    }

    protected override void ComposeInternal(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem().Text(Label).FontColor(Colors.Grey.Darken1);
            row.RelativeItem(2).Text(Value);
        });
    }
}

public class DateField : Field
{
    public DateField(string label, DateTime? date) : base(label, date.HasValue ? FormatDate(date.Value) : null)
    {
    }

    public DateField(string label, string? formattedValue) : base(label, formattedValue)
    {
    }

    private static string FormatDate(DateTime date)
    {
        return date.ToString("d", CultureInfo.CurrentCulture);
    }

    protected override void ComposeInternal(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem().Text(Label).FontColor(Colors.Grey.Darken1);
            row.RelativeItem(2).Text(Value);
        });
    }
}

public class PercentageField(string label, decimal? percentage) : Field(label, percentage.HasValue ? FormatPercentage(percentage.Value) : null)
{
    private static string FormatPercentage(decimal percentage)
    {
        return $"{percentage:P2}";
    }

    protected override void ComposeInternal(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem().Text(Label).FontColor(Colors.Grey.Darken1);
            row.RelativeItem(2).Text(Value);
        });
    }
}

public class MonospaceField(string label, string? value) : Field(label, value)
{
    protected override void ComposeInternal(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem().Text(Label).FontColor(Colors.Grey.Darken1);
            row.RelativeItem(2).Text(Value);
        });
    }
}

// Comprehensive DSL extension methods
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
        container.PaddingBottom(15).Text(title).Bold().Underline().FontColor(Colors.Blue.Darken2);
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
            container.Column(col =>
            {
                if (party.PartyName?.Count > 0) col.Item().Text(party.PartyName[0].Name.Value).Bold();
                party.PartyIdentification?.ForEach(id => col.Item().Element(c => c.Mono("Party ID", id.Id?.Value)));
                if (party.PostalAddress != null) col.Item().Element(addr => addr.Address(party.PostalAddress));
                if (party.Contact != null)
                {
                    col.Item().Element(c => c.Field("Contact Name", party.Contact.Name?.Value));
                    col.Item().Element(c => c.Mono("Telephone", party.Contact.Telephone?.Value));
                    col.Item().Element(c => c.Mono("Email", party.Contact.ElectronicMail?.Value));
                }
            });
        return container;
    }

    public static IContainer Address(this IContainer container, AddressType? address)
    {
        if (address != null)
            container.Column(col =>
            {
                address.StreetName?.Value?.Let(v => col.Item().Text(v));
                address.AdditionalStreetName?.Value?.Let(v => col.Item().Text(v));
                address.BuildingNumber?.Value?.Let(v => col.Item().Text(v));
                address.CityName?.Value?.Let(v => col.Item().Text(v));
                address.PostalZone?.Value?.Let(v => col.Item().Text(v));
                address.Country?.IdentificationCode?.Value?.Let(v => col.Item().Text(v));
            });
        return container;
    }

    // Invoice DSL
    public static IContainer InvoiceDetails(this IContainer container, InvoiceType invoice)
    {
        container.Column(col =>
        {
            col.Item().Element(c => c.Mono("Invoice Number", invoice.Id?.Value));
            col.Item().Element(c => c.Date("Issue Date", invoice.IssueDate?.Value));
            col.Item().Element(c => c.Date("Due Date", invoice.DueDate?.Value));
            invoice.PaymentTerms?.ForEach(term => term.Note?.ForEach(note => col.Item().Element(c => c.Field("Payment Terms", note.Value))));
            col.Item().Element(c => c.Mono("Currency", invoice.DocumentCurrencyCode?.Value));
        });
        return container;
    }

    public static IContainer Totals(this IContainer container, InvoiceType invoice)
    {
        container.Column(col =>
        {
            col.Item().Element(c => c.Money("Line Extension Amount", invoice.LegalMonetaryTotal?.LineExtensionAmount?.Value, invoice.DocumentCurrencyCode?.Value));
            col.Item().Element(c => c.Money("Tax Exclusive Amount", invoice.LegalMonetaryTotal?.TaxExclusiveAmount?.Value, invoice.DocumentCurrencyCode?.Value));
            col.Item().Element(c => c.Money("Tax Inclusive Amount", invoice.LegalMonetaryTotal?.TaxInclusiveAmount?.Value, invoice.DocumentCurrencyCode?.Value));
            col.Item().Element(c => c.Money("Payable Amount", invoice.LegalMonetaryTotal?.PayableAmount?.Value, invoice.DocumentCurrencyCode?.Value));
            invoice.TaxTotal?.ForEach(tax => col.Item().Element(c => c.Money("Tax Amount", tax.TaxAmount?.Value, invoice.DocumentCurrencyCode?.Value)));
        });
        return container;
    }

    public static IContainer Notes(this IContainer container, InvoiceType invoice)
    {
        if (invoice.Note?.Count > 0) container.Column(col => { invoice.Note.ForEach(note => col.Item().Text(note.Value)); });
        return container;
    }

    public static IContainer Summary(this IContainer container, InvoiceType invoice)
    {
        container.Column(col =>
        {
            col.Item().Element(c => c.Mono("Invoice Number", invoice.Id?.Value));
            col.Item().Element(c => c.Date("Issue Date", invoice.IssueDate?.Value));
            col.Item().Element(c => c.Field("Line Item Count", invoice.InvoiceLine?.Count.ToString() ?? "0"));
            invoice.AdditionalDocumentReference?.ForEach(doc => col.Item().Element(c => c.Mono("Document Reference", doc.Id?.Value)));
        });
        return container;
    }

    // Table DSL
    public static IContainer InvoiceTable(this IContainer container, InvoiceType invoice, RenderContext context)
    {
        if (invoice.InvoiceLine?.Count > 0)
            container.Column(col =>
            {
                col.Item().Table(table =>
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
            });
        else container.Text("No line items available").FontColor(Colors.Grey.Medium);
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
                    line.Item?.SellersItemIdentification?.Id?.Value?.Let(v => left.Item().Field("SellersItemIdentification", v));
                    line.Item?.StandardItemIdentification?.Id?.Value?.Let(v => left.Item().Field("StandardItemIdentification", v));
                    line.Item?.Name?.Value?.Let(v => left.Item().Field("Item Name", v));
                });
                row.RelativeItem().Column(middle =>
                {
                    middle.Item().Text("Period & References").Bold().FontColor(Colors.Blue.Darken2);
                    line.InvoicePeriod?.ForEach(period =>
                    {
                        middle.Item().Date("Start Date", period.StartDate?.Value);
                        middle.Item().Date("End Date", period.EndDate?.Value);
                    });
                    line.DocumentReference?.ForEach(doc =>
                    {
                        middle.Item().Mono("Document ID", doc.Id?.Value);
                        middle.Item().Mono("Document Type", doc.DocumentTypeCode?.Value);
                    });
                });
                row.RelativeItem().Column(right =>
                {
                    right.Item().Text("Tax & Charges").Bold().FontColor(Colors.Blue.Darken2);
                    line.Item?.ClassifiedTaxCategory?.ForEach(tax =>
                    {
                        right.Item().Mono("Tax ID", tax.Id?.Value);
                        right.Item().Percent("Tax Rate", tax.Percent?.Value);
                        right.Item().Mono("Tax Scheme", tax.TaxScheme?.Id?.Value);
                    });
                    line.AllowanceCharge?.ForEach(allowance =>
                    {
                        right.Item().Field("Charge Indicator", allowance.ChargeIndicator.ToString());
                        right.Item().Money("Amount", allowance.Amount?.Value, currencyCode);
                        right.Item().Money("Base Amount", allowance.BaseAmount?.Value, currencyCode);
                    });
                });
            });
        });
    }
}