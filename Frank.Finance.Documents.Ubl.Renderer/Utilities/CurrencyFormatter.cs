using System.Globalization;

namespace Frank.Finance.Documents.Ubl.Renderer.Utilities;

public static class CurrencyFormatter
{
    public static string FormatCurrency(decimal amount, string? currencyCode = null)
    {
        var culture = CultureInfo.CurrentCulture;
        var formatted = amount.ToString("C", culture);

        if (!string.IsNullOrEmpty(currencyCode) && !formatted.Contains(currencyCode))
            formatted = $"{currencyCode} {formatted}";

        return formatted;
    }
}
