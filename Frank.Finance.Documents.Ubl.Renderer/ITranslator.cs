public interface ITranslator
{
    Task<string> TranslateAsync(string key, Language language);
}