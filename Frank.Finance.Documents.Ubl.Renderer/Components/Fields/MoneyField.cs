using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Utilities;

namespace Frank.Finance.Documents.Ubl.Renderer.Components.Fields;

public class MoneyField(string label, decimal? amount, string? currencyCode = null) : Field(label, amount.HasValue ? CurrencyFormatter.FormatCurrency(amount.Value, currencyCode) : null)
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
