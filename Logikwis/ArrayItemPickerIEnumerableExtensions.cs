using System.Collections.Generic;
using System.Linq;

namespace Logikwis
{
    public static class ArrayItemPickerIEnumerableExtensions
    {
        public static IEnumerable<PickedArrayItem<T>> PickList<T>(this IEnumerable<T> items)
        {
            var sourceArray = items.ToList();

            return sourceArray.Select((item, i) => new PickedArrayItem<T>(sourceArray, i));
        }
    }
}