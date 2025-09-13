using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Frank.Finance.Documents.Ubl.Renderer;

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