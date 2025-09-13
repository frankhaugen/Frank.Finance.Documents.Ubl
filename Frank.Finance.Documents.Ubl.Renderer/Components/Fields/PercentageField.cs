using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Frank.Finance.Documents.Ubl.Renderer.Components.Fields;

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
