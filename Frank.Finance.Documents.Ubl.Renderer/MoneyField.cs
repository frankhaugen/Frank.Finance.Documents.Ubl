using System.Globalization;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Frank.Finance.Documents.Ubl.Renderer;

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