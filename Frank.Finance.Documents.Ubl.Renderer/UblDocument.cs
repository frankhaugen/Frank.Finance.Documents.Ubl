using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents;
using System.Globalization;

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
            .Row(row =>
            {
                row.RelativeItem().Element(ComposeHeaderContent);
            });
    }

    private void ComposeHeaderContent(IContainer container)
    {
        container
            .Column(column =>
            {
                column.Item().Text("INVOICE").Bold().FontColor(Colors.Blue.Darken2);
                
                if (context.Invoice?.InvoiceTypeCode?.Value != null)
                {
                    column.Item().Text($" - {context.Invoice.InvoiceTypeCode.Value}")
                        .FontColor(Colors.Grey.Darken1);
                }
            });
    }

    private void ComposeContent(IContainer container)
    {
        container
            .Column(column =>
            {
                column.Item().Element(ComposeThreeColumnHeader); // Content 1: Three columns (Supplier, Customer/Delivery, Invoice/Payment details)
                column.Item().Element(ComposeNotesSection); // Content 2: Notes and description
                column.Item().Element(ComposeTotalsSection); // Content 3: Totals from header and taxes/VAT
                column.Item().Element(ComposeLineItemsTable); // Content 4: Table of lines
                column.Item().Element(ComposeSummarySection); // Content 5: Summaries and control sums
            });
    }

    private void ComposeThreeColumnHeader(IContainer container)
    {
        container
            .Row(row =>
            {
                // Supplier Column
                row.RelativeItem(1).Element(container =>
                {
                    container.Column(column =>
                    {
                        column.Item().SectionHeading("SUPPLIER");
                        column.Item().Element(container => ComposePartyInfo(container, context.Invoice?.AccountingSupplierParty?.Party));
                    });
                });

                // Customer/Delivery Column
                row.RelativeItem(1).Element(container =>
                {
                    container.Column(column =>
                    {
                        column.Item().SectionHeading("CUSTOMER");
                        column.Item().Element(container => ComposePartyInfo(container, context.Invoice?.AccountingCustomerParty?.Party));
                    });
                });

                // Invoice/Payment Details Column
                row.RelativeItem(1).Element(container =>
                {
                    container.Column(column =>
                    {
                        column.Item().SectionHeading("INVOICE DETAILS");
                        column.Item().Element(ComposeInvoiceDetails);
                    });
                });
            });
    }

    private void ComposePartyInfo(IContainer container, PartyType? party)
    {
        if (party == null) return;

        container
            .Column(column =>
            {
                // Party Name
                if (party.PartyName?.Count > 0 && party.PartyName[0]?.Name?.Value != null)
                {
                    column.Item().Text(party.PartyName[0].Name.Value).Bold();
                }

                // Party ID
                if (party.PartyIdentification?.Count > 0)
                {
                    foreach (var id in party.PartyIdentification)
                    {
                        column.Item().Component(new MonospaceField("Party ID", id.Id?.Value));
                    }
                }

                // Address
                if (party.PostalAddress != null)
                {
                    column.Item().Element(container => ComposeAddress(container, party.PostalAddress));
                }

                // Contact
                if (party.Contact != null)
                {
                    column.Item().Component(new TextField("Contact Name", party.Contact.Name?.Value));
                    column.Item().Component(new MonospaceField("Telephone", party.Contact.Telephone?.Value));
                    column.Item().Component(new MonospaceField("Email", party.Contact.ElectronicMail?.Value));
                }
            });
    }

    private void ComposeAddress(IContainer container, AddressType? address)
    {
        if (address == null) return;

        container
            .Column(column =>
            {
                if (address.StreetName?.Value != null)
                    column.Item().Text(address.StreetName.Value);

                if (address.AdditionalStreetName?.Value != null)
                    column.Item().Text(address.AdditionalStreetName.Value);

                if (address.BuildingNumber?.Value != null)
                    column.Item().Text(address.BuildingNumber.Value);

                if (address.CityName?.Value != null)
                    column.Item().Text(address.CityName.Value);

                if (address.PostalZone?.Value != null)
                    column.Item().Text(address.PostalZone.Value);

                if (address.Country?.IdentificationCode?.Value != null)
                    column.Item().Text(address.Country.IdentificationCode.Value);
            });
    }

    private void ComposeInvoiceDetails(IContainer container)
    {
        if (context.Invoice == null) return;

        container
            .Column(column =>
            {
                column.Item().Component(new MonospaceField("Invoice Number", context.Invoice.Id?.Value));
                column.Item().Component(new DateField("Issue Date", context.Invoice.IssueDate?.Value));
                column.Item().Component(new DateField("Due Date", context.Invoice.DueDate?.Value));

                if (context.Invoice.PaymentTerms?.Count > 0)
                {
                    foreach (var term in context.Invoice.PaymentTerms)
                    {
                        if (term.Note?.Count > 0)
                        {
                            foreach (var note in term.Note)
                            {
                                column.Item().Component(new TextField("Payment Terms", note.Value));
                            }
                        }
                    }
                }

                column.Item().Component(new MonospaceField("Currency", context.Invoice.DocumentCurrencyCode?.Value));
            });
    }

    private void ComposeNotesSection(IContainer container)
    {
        if (context.Invoice?.Note?.Count == 0) return;

        container
            .SectionHeading("NOTES")
            .SectionContent(column =>
            {
                if (context.Invoice?.Note != null)
                {
                    foreach (var note in context.Invoice.Note)
                    {
                        column.Item().Text(note.Value);
                    }
                }
            });
    }

    private void ComposeTotalsSection(IContainer container)
    {
        if (context.Invoice == null) return;

        container
            .SectionHeading("TOTALS")
            .SectionContent(column =>
            {
                column.Item().Component(new MoneyField("Line Extension Amount", context.Invoice.LegalMonetaryTotal?.LineExtensionAmount?.Value, context.Invoice.DocumentCurrencyCode?.Value));
                column.Item().Component(new MoneyField("Tax Exclusive Amount", context.Invoice.LegalMonetaryTotal?.TaxExclusiveAmount?.Value, context.Invoice.DocumentCurrencyCode?.Value));
                column.Item().Component(new MoneyField("Tax Inclusive Amount", context.Invoice.LegalMonetaryTotal?.TaxInclusiveAmount?.Value, context.Invoice.DocumentCurrencyCode?.Value));
                column.Item().Component(new MoneyField("Payable Amount", context.Invoice.LegalMonetaryTotal?.PayableAmount?.Value, context.Invoice.DocumentCurrencyCode?.Value));

                if (context.Invoice.TaxTotal?.Count > 0)
                {
                    foreach (var taxTotal in context.Invoice.TaxTotal)
                    {
                        column.Item().Component(new MoneyField("Tax Amount", taxTotal.TaxAmount?.Value, context.Invoice.DocumentCurrencyCode?.Value));
                    }
                }
            });
    }

    private void ComposeLineItemsTable(IContainer container)
    {
        if (context.Invoice?.InvoiceLine == null || context.Invoice.InvoiceLine.Count == 0)
        {
            container.Text("No line items available").FontColor(Colors.Grey.Medium);
            return;
        }

        container
            .SectionHeading("LINE ITEMS")
            .SectionContent(column =>
            {

                column.Item().Table(table =>
                {
                    // Define columns to match the image layout
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(0.5f);  // # (Number)
                        columns.RelativeColumn(1.5f);  // Artikkelnummer (Article Number)
                        columns.RelativeColumn(4.0f);  // Beskrivelse (Description) - Main content column
                        columns.RelativeColumn(1.0f);  // Enhetspris (Unit Price)
                        columns.RelativeColumn(1.0f);  // Antall Enhet (Quantity Unit)
                        columns.RelativeColumn(1.0f);  // Mva (VAT Amount)
                        columns.RelativeColumn(1.0f);  // Netto (Net Total)
                        columns.RelativeColumn(0.8f);  // Mva % (VAT Percentage)
                    });

                    // Header row
                    table.Header(headerRow =>
                    {
                        headerRow.Cell().Element(HeaderCellStyle).AlignLeft().Text("#");
                        headerRow.Cell().Element(HeaderCellStyle).AlignLeft().Text("Artikkelnummer");
                        headerRow.Cell().Element(HeaderCellStyle).AlignLeft().Text("Beskrivelse");
                        headerRow.Cell().Element(HeaderCellStyle).AlignRight().Text("Enhetspris");
                        headerRow.Cell().Element(HeaderCellStyle).AlignRight().Text("Antall Enhet");
                        headerRow.Cell().Element(HeaderCellStyle).AlignRight().Text("Mva");
                        headerRow.Cell().Element(HeaderCellStyle).AlignRight().Text("Netto");
                        headerRow.Cell().Element(HeaderCellStyle).AlignRight().Text("Mva %");
                    });

                    // Data rows
                    foreach (var (line, index) in context.Invoice.InvoiceLine.Select((line, index) => (line, index)))
                    {
                        AddLine(table, line, index + 1);
                    }
                });
            });
    }

    private void AddLine(TableDescriptor table, InvoiceLineType line, int lineNumber)
    {
        var description = line.Item?.Description?.Count > 0 ? line.Item.Description[0]?.Value : "";
        var articleNumber = line.Item?.SellersItemIdentification?.Id?.Value ?? "";
        var unitCode = line.InvoicedQuantity?.UnitCode ?? "";
        var quantity = line.InvoicedQuantity?.Value ?? 0;
        var vatPercent = line.Item?.ClassifiedTaxCategory?.FirstOrDefault()?.Percent?.Value ?? 0;
        var unitPrice = line.Price?.PriceAmount?.Value ?? 0;
        var lineTotal = line.LineExtensionAmount?.Value ?? 0;
        var vatAmount = lineTotal * (vatPercent / 100);

        // Main line item row
        table.Cell().Element(ItemCellStyle).AlignLeft().Text(lineNumber.ToString());
        table.Cell().Element(ItemCellStyle).AlignLeft().Text(articleNumber);
        table.Cell().Element(ItemCellStyle).AlignLeft().Text(description).Bold();
        table.Cell().Element(ItemCellStyle).AlignRight().Text(FormatCurrency(unitPrice, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text($"{quantity:F2} {unitCode}");
        table.Cell().Element(ItemCellStyle).AlignRight().Text(FormatCurrency(vatAmount, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text(FormatCurrency(lineTotal, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text($"{vatPercent:F2}%");

        // Add expandable details row
        table.Cell().ColumnSpan(8).Component(new LineDetailsComponent(line, context.Invoice?.DocumentCurrencyCode?.Value));
        
        // Add separator line
        table.Cell().ColumnSpan(8).Element(ItemCellStyle).PaddingBottom(5).LineHorizontal(0.5f);
    }

    private static IContainer ItemCellStyle(IContainer container)
        => container
            .PaddingVertical(3)
            .PaddingHorizontal(4);

    private static IContainer HeaderCellStyle(IContainer container)
        => container
            .DefaultTextStyle(x => x.SemiBold())
            .PaddingVertical(5)
            .BorderBottom(1)
            .BorderColor(Colors.Black);

    private void ComposeSummarySection(IContainer container)
    {
        if (context.Invoice == null) return;

        container
            .SectionHeading("SUMMARY")
            .SectionContent(column =>
            {
                column.Item().Component(new MonospaceField("Invoice Number", context.Invoice.Id?.Value));
                column.Item().Component(new DateField("Issue Date", context.Invoice.IssueDate?.Value));
                column.Item().Component(new TextField("Line Item Count", context.Invoice.InvoiceLine?.Count.ToString() ?? "0"));
                
                if (context.Invoice.AdditionalDocumentReference?.Count > 0)
                {
                    foreach (var docRef in context.Invoice.AdditionalDocumentReference)
                    {
                        column.Item().Component(new MonospaceField("Document Reference", docRef.Id?.Value));
                    }
                }
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

        if (!string.IsNullOrEmpty(currencyCode) && !formatted.Contains(currencyCode))
        {
            formatted = $"{currencyCode} {formatted}";
        }

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
            row.RelativeItem(1).Text(Label).FontColor(Colors.Grey.Darken1);
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

        if (!string.IsNullOrEmpty(currencyCode) && !formatted.Contains(currencyCode))
        {
            formatted = $"{currencyCode} {formatted}";
        }

        return formatted;
    }

    protected override void ComposeInternal(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem(1).Text(Label).FontColor(Colors.Grey.Darken1);
            row.RelativeItem(2).Text(Value);
        });
    }
}

public class DateField : Field
{
    public DateField(string label, DateTime? date) : base(label, date.HasValue ? FormatDate(date.Value) : null) { }

    public DateField(string label, string? formattedValue) : base(label, formattedValue) { }

    private static string FormatDate(DateTime date)
    {
        return date.ToString("d", CultureInfo.CurrentCulture);
    }

    protected override void ComposeInternal(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem(1).Text(Label).FontColor(Colors.Grey.Darken1);
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
            row.RelativeItem(1).Text(Label).FontColor(Colors.Grey.Darken1);
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
            row.RelativeItem(1).Text(Label).FontColor(Colors.Grey.Darken1);
            row.RelativeItem(2).Text(Value);
        });
    }
}

// Micro-DSL extension methods
public static class UblDocumentExtensions
{
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

    public static IContainer Section(this IContainer container, string title)
    {
        container
            .PaddingBottom(15)
            .Text(title)
            .Bold()
            .FontColor(Colors.Blue.Darken2);
        return container;
    }

    public static IContainer SectionHeading(this IContainer container, string title)
    {
        container
            .PaddingBottom(15)
            .Text(title)
            .Bold()
            .Underline()
            .FontColor(Colors.Blue.Darken2);
        return container;
    }

    public static IContainer SectionContent(this IContainer container, Action<ColumnDescriptor> content)
    {
        container
            .PaddingBottom(10)
            .Column(content);
        return container;
    }

    public static IContainer TwoCol(this IContainer container, Action<IContainer> left, Action<IContainer> right)
    {
        container.Row(row =>
        {
            row.RelativeItem(1).Element(left);
            row.RelativeItem(1).Element(right);
        });
        return container;
    }

    public static IContainer HCell(this IContainer container)
    {
        return container
            .Border(1)
            .BorderColor(Colors.Grey.Lighten2)
            .Padding(8)
            .Background(Colors.Grey.Lighten4);
    }

    public static IContainer Cell(this IContainer container)
    {
        return container
            .Border(1)
            .BorderColor(Colors.Grey.Lighten2)
            .Padding(8);
    }
}

public class LineDetailsComponent(InvoiceLineType? line, string? currencyCode) : IComponent
{
    public void Compose(IContainer container)
    {
        if (line == null) return;
        
        container
            .Padding(5)
            .Border(1)
            .BorderColor(Colors.Grey.Lighten2)
            .Background(Colors.Grey.Lighten4)
            .Column(column =>
            {
                // Section header
                column.Item().Text("See additional line properties").Bold().FontColor(Colors.Grey.Darken1);
                
                column.Item().Row(row =>
                {
                    // Left section - Item Details
                    row.RelativeItem().Column(leftColumn =>
                    {
                        leftColumn.Item().Text("Item Details").Bold().FontColor(Colors.Blue.Darken2);
                        
                        // Sellers Item Identification
                        if (line.Item?.SellersItemIdentification?.Id?.Value != null)
                        {
                            leftColumn.Item().Component(new TextField("SellersItemIdentification", line.Item.SellersItemIdentification.Id.Value));
                        }
                        
                        // Standard Item Identification
                        if (line.Item?.StandardItemIdentification?.Id?.Value != null)
                        {
                            leftColumn.Item().Component(new TextField("StandardItemIdentification", line.Item.StandardItemIdentification.Id.Value));
                        }
                        
                        // Item Name
                        if (line.Item?.Name?.Value != null)
                        {
                            leftColumn.Item().Component(new TextField("Item Name", line.Item.Name.Value));
                        }
                    });
                    
                    // Middle section - Period & References
                    row.RelativeItem().Column(middleColumn =>
                    {
                        middleColumn.Item().Text("Period & References").Bold().FontColor(Colors.Blue.Darken2);
                        
                        // Invoice Period
                        if (line.InvoicePeriod?.Count > 0)
                        {
                            foreach (var period in line.InvoicePeriod)
                            {
                                middleColumn.Item().Component(new DateField("Start Date", period.StartDate?.Value));
                                middleColumn.Item().Component(new DateField("End Date", period.EndDate?.Value));
                            }
                        }
                        
                        // Document Reference
                        if (line.DocumentReference?.Count > 0)
                        {
                            foreach (var docRef in line.DocumentReference)
                            {
                                middleColumn.Item().Component(new MonospaceField("Document ID", docRef.Id?.Value));
                                middleColumn.Item().Component(new MonospaceField("Document Type", docRef.DocumentTypeCode?.Value));
                            }
                        }
                    });
                    
                    // Right section - Tax & Charges
                    row.RelativeItem().Column(rightColumn =>
                    {
                        rightColumn.Item().Text("Tax & Charges").Bold().FontColor(Colors.Blue.Darken2);
                        
                        // Classified Tax Category
                        if (line.Item?.ClassifiedTaxCategory?.Count > 0)
                        {
                            foreach (var tax in line.Item.ClassifiedTaxCategory)
                            {
                                rightColumn.Item().Component(new MonospaceField("Tax ID", tax.Id?.Value));
                                rightColumn.Item().Component(new PercentageField("Tax Rate", tax.Percent?.Value));
                                rightColumn.Item().Component(new MonospaceField("Tax Scheme", tax.TaxScheme?.Id?.Value));
                            }
                        }
                        
                        // Allowance Charge
                        if (line.AllowanceCharge?.Count > 0)
                        {
                            foreach (var allowance in line.AllowanceCharge)
                            {
                                rightColumn.Item().Component(new TextField("Charge Indicator", allowance.ChargeIndicator.ToString()));
                                rightColumn.Item().Component(new MoneyField("Amount", allowance.Amount?.Value, currencyCode));
                                rightColumn.Item().Component(new MoneyField("Base Amount", allowance.BaseAmount?.Value, currencyCode));
                            }
                        }
                    });
                });
            });
    }
}