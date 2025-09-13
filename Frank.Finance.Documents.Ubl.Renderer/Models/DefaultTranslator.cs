namespace Frank.Finance.Documents.Ubl.Renderer.Models;

public class DefaultTranslator : ITranslator
{
    public Task<string> TranslateAsync(string key, Language language)
    {
        // Default implementation returns the key as is
        return Task.FromResult(key);
    }
}
