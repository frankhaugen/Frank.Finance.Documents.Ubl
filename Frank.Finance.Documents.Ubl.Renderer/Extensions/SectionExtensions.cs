using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class SectionExtensions
{
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
}
