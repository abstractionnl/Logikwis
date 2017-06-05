using System.Collections.Generic;

namespace Logikwis
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> otherItems, T item)
        {
            yield return item;
            foreach (var otherItem in otherItems)
                yield return otherItem;
        }

        public static IEnumerable<T> Append<T>(this IEnumerable<T> otherItems, T item)
        {
            foreach (var otherItem in otherItems)
                yield return otherItem;

            yield return item;
        }
    }
}