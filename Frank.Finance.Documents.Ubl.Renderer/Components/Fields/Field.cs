using QuestPDF.Infrastructure;

namespace Frank.Finance.Documents.Ubl.Renderer.Components.Fields;

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
