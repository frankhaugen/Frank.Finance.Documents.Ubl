using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Frank.Finance.Documents.Ubl.Renderer.Components.Fields;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class FieldExtensions
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
}
