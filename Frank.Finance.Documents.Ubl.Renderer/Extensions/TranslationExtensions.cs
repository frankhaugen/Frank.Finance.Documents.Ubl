using Frank.Finance.Documents.Ubl.Renderer.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Frank.Finance.Documents.Ubl.Renderer.Extensions;

public static class TranslationExtensions
{
    public static async Task<string> TranslateAsync(this ITranslator translator, string key, Language language)
    {
        return await translator.TranslateAsync(key, language);
    }

    public static IContainer TranslatedSectionHeading(this IContainer container, ITranslator translator, Language language, string key)
    {
        var translatedText = translator.TranslateAsync(key, language).Result;
        container.Text(translatedText).Bold().Underline().FontColor(QuestPDF.Helpers.Colors.Blue.Darken2);
        return container;
    }

    public static IContainer TranslatedField(this IContainer container, ITranslator translator, Language language, string key, string? value)
    {
        var translatedLabel = translator.TranslateAsync(key, language).Result;
        container.Text($"{translatedLabel}: {value ?? "N/A"}");
        return container;
    }
}
