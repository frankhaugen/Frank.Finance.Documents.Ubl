using System.Collections.Concurrent;

namespace Frank.Finance.Documents.Ubl.Renderer.Models;

public class DefaultTranslator : ITranslator
{
    private static readonly ConcurrentDictionary<string, Dictionary<Language, string>> _translations = new();

    static DefaultTranslator()
    {
        InitializeTranslations();
    }

    public Task<string> TranslateAsync(string key, Language language)
    {
        if (_translations.TryGetValue(key, out var languageTranslations) && 
            languageTranslations.TryGetValue(language, out var translation))
        {
            return Task.FromResult(translation);
        }

        // Fallback to key if no translation found
        return Task.FromResult(key);
    }

    private static void InitializeTranslations()
    {
        // Document type names
        AddTranslation("DOCUMENT_TYPE_INVOICE", Language.EN, "INVOICE");
        AddTranslation("DOCUMENT_TYPE_INVOICE", Language.NB, "FAKTURA");
        AddTranslation("DOCUMENT_TYPE_CREDIT_NOTE", Language.EN, "CREDIT NOTE");
        AddTranslation("DOCUMENT_TYPE_CREDIT_NOTE", Language.NB, "KREDITNOTA");
        AddTranslation("DOCUMENT_TYPE_REMINDER", Language.EN, "REMINDER");
        AddTranslation("DOCUMENT_TYPE_REMINDER", Language.NB, "PÅMINNELSE");

        // Common section headers
        AddTranslation("HEADER_SUPPLIER", Language.EN, "SUPPLIER");
        AddTranslation("HEADER_SUPPLIER", Language.NB, "LEVERANDØR");
        AddTranslation("HEADER_CUSTOMER", Language.EN, "CUSTOMER");
        AddTranslation("HEADER_CUSTOMER", Language.NB, "KUNDE");
        AddTranslation("HEADER_DETAILS", Language.EN, "DETAILS");
        AddTranslation("HEADER_DETAILS", Language.NB, "DETALJER");
        AddTranslation("HEADER_NOTES", Language.EN, "NOTES");
        AddTranslation("HEADER_NOTES", Language.NB, "MERKNADER");
        AddTranslation("HEADER_TOTALS", Language.EN, "TOTALS");
        AddTranslation("HEADER_TOTALS", Language.NB, "TOTALS");
        AddTranslation("HEADER_LINE_ITEMS", Language.EN, "LINE ITEMS");
        AddTranslation("HEADER_LINE_ITEMS", Language.NB, "LINJEELEMENTER");
        AddTranslation("HEADER_SUMMARY", Language.EN, "SUMMARY");
        AddTranslation("HEADER_SUMMARY", Language.NB, "SAMMENDRAG");

        // Page footer
        AddTranslation("PAGE_FOOTER", Language.EN, "Page {0} of {1}");
        AddTranslation("PAGE_FOOTER", Language.NB, "Side {0} av {1}");
    }

    private static void AddTranslation(string key, Language language, string translation)
    {
        _translations.AddOrUpdate(key, 
            new Dictionary<Language, string> { { language, translation } },
            (k, existing) => 
            {
                existing[language] = translation;
                return existing;
            });
    }
}
