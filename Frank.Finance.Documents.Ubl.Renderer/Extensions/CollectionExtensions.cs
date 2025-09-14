namespace Frank.Finance.Documents.Ubl.Renderer.Utilities;

public static class CollectionExtensions
{
    public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
    {
        foreach (var item in items) action(item);
    }

    public static void ForEach<T>(this IEnumerable<T> items, Action<T, int> action)
    {
        var index = 0;
        foreach (var item in items) action(item, index++);
    }

    public static void Let<T>(this T? value, Action<T> action)
    {
        if (value != null) action(value);
    }

    public static string Join(this IEnumerable<string?> items, string separator)
    {
        return string.Join(separator, items.Where(item => item != null));
    }
}
