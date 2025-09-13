using System.Globalization;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Frank.Finance.Documents.Ubl.Renderer;

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