using Frank.Finance.Documents.Ubl.Invoice;
using Frank.Finance.Documents.Ubl.CreditNote;
using Frank.Finance.Documents.Ubl.Reminder;
using Frank.Finance.Documents.Ubl.CommonAggregateComponentsCommonAggregateComponents;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Models;
using Frank.Finance.Documents.Ubl.Renderer.Components.Tables;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class TableExtensions
{
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
        table.Cell().Element(ItemCellStyle).AlignRight().Text(Utilities.CurrencyFormatter.FormatCurrency(unitPrice, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text($"{quantity:F2} {unitCode}");
        table.Cell().Element(ItemCellStyle).AlignRight().Text(Utilities.CurrencyFormatter.FormatCurrency(vatAmount, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text(Utilities.CurrencyFormatter.FormatCurrency(lineTotal, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text($"{vatPercent:F2}%");
        table.Cell().ColumnSpan(8).Component(new LineDetailsComponent(line, context.Invoice?.DocumentCurrencyCode?.Value));
        table.Cell().ColumnSpan(8).Element(ItemCellStyle).PaddingBottom(5).LineHorizontal(0.5f);
    }

    public static IContainer ItemCellStyle(this IContainer container)
    {
        return container.PaddingVertical(3).PaddingHorizontal(2);
    }

    public static IContainer HeaderCellStyle(this IContainer container)
    {
        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
    }

    public static IContainer CreditNoteTable(this IContainer container, CreditNoteType creditNote, RenderContext context)
    {
        if (creditNote.CreditNoteLine?.Count > 0)
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
                creditNote.CreditNoteLine.ForEach((line, index) => table.AddCreditNoteLine(line, index + 1, context));
            });
        }
        else 
        {
            container.Text("No line items available").FontColor(Colors.Grey.Medium);
        }
        return container;
    }

    public static void AddCreditNoteLine(this TableDescriptor table, CreditNoteLineType line, int lineNumber, RenderContext context)
    {
        var description = line.Item?.Description?.Count > 0 ? line.Item.Description[0]?.Value : "";
        var articleNumber = line.Item?.SellersItemIdentification?.Id?.Value ?? "";
        var unitCode = line.CreditedQuantity?.UnitCode ?? "";
        var quantity = line.CreditedQuantity?.Value ?? 0;
        var vatPercent = line.Item?.ClassifiedTaxCategory?.FirstOrDefault()?.Percent?.Value ?? 0;
        var unitPrice = line.Price?.PriceAmount?.Value ?? 0;
        var lineTotal = line.LineExtensionAmount?.Value ?? 0;
        var vatAmount = lineTotal * (vatPercent / 100);

        table.Cell().Element(ItemCellStyle).AlignLeft().Text(lineNumber.ToString());
        table.Cell().Element(ItemCellStyle).AlignLeft().Text(articleNumber);
        table.Cell().Element(ItemCellStyle).AlignLeft().Text(description).Bold();
        table.Cell().Element(ItemCellStyle).AlignRight().Text(Utilities.CurrencyFormatter.FormatCurrency(unitPrice, context.CreditNote?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text($"{quantity:F2} {unitCode}");
        table.Cell().Element(ItemCellStyle).AlignRight().Text(Utilities.CurrencyFormatter.FormatCurrency(vatAmount, context.CreditNote?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text(Utilities.CurrencyFormatter.FormatCurrency(lineTotal, context.CreditNote?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text($"{vatPercent:F2}%");
        table.Cell().ColumnSpan(8).Element(ItemCellStyle).PaddingBottom(5).LineHorizontal(0.5f);
    }

    public static IContainer ReminderTable(this IContainer container, ReminderType reminder, RenderContext context)
    {
        if (reminder.ReminderLine?.Count > 0)
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
                    header.Cell().Element(HeaderCellStyle).AlignLeft().Text("ID");
                    header.Cell().Element(HeaderCellStyle).AlignLeft().Text("Beskrivelse");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("Debet");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("Kredit");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("Beløp");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("Straff %");
                    header.Cell().Element(HeaderCellStyle).AlignRight().Text("");
                });
                reminder.ReminderLine.ForEach((line, index) => table.AddReminderLine(line, index + 1, context));
            });
        }
        else 
        {
            container.Text("No line items available").FontColor(Colors.Grey.Medium);
        }
        return container;
    }

    public static void AddReminderLine(this TableDescriptor table, ReminderLineType line, int lineNumber, RenderContext context)
    {
        var description = line.Note?.Count > 0 ? line.Note[0]?.Value : "";
        var lineId = line.Id?.Value ?? "";
        var debitAmount = line.DebitLineAmount?.Value ?? 0;
        var creditAmount = line.CreditLineAmount?.Value ?? 0;
        var totalAmount = line.Amount?.Value ?? 0;
        var penaltyPercent = line.PenaltySurchargePercent?.Value ?? 0;

        table.Cell().Element(ItemCellStyle).AlignLeft().Text(lineNumber.ToString());
        table.Cell().Element(ItemCellStyle).AlignLeft().Text(lineId);
        table.Cell().Element(ItemCellStyle).AlignLeft().Text(description).Bold();
        table.Cell().Element(ItemCellStyle).AlignRight().Text(Utilities.CurrencyFormatter.FormatCurrency(debitAmount, context.Reminder?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text(Utilities.CurrencyFormatter.FormatCurrency(creditAmount, context.Reminder?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text(Utilities.CurrencyFormatter.FormatCurrency(totalAmount, context.Reminder?.DocumentCurrencyCode?.Value));
        table.Cell().Element(ItemCellStyle).AlignRight().Text($"{penaltyPercent:F2}%");
        table.Cell().ColumnSpan(8).Element(ItemCellStyle).PaddingBottom(5).LineHorizontal(0.5f);
    }
}
