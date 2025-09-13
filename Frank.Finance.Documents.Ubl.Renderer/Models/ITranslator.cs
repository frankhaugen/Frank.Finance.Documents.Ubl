namespace Frank.Finance.Documents.Ubl.Renderer.Models;

public interface ITranslator
{
    Task<string> TranslateAsync(string key, Language language);
}
