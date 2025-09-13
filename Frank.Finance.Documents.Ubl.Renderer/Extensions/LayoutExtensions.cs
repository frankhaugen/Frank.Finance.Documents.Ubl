using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class LayoutExtensions
{
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
}
