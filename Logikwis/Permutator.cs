using System.Collections.Generic;
using System.Linq;

namespace Logikwis
{
    public class Permutator
    {
        public static IEnumerable<IReadOnlyList<T>> Permutate<T>(IReadOnlyCollection<T> input)
        {
            return Permutate(input.ToList(), 0);
        }

        private static IEnumerable<IReadOnlyList<T>> Permutate<T>(List<T> array, int start)
        {
            if (start == array.Count - 1)
                yield return array;
            if (start == array.Count - 2)
            {
                yield return array;
                yield return Swap(array, start, start+1);
            }
            else {
                for (var i = start; i < array.Count; i++)
                {
                    foreach (var result in Permutate(Swap(array, start, i), start+1))
                        yield return result;
                }
            }
        }

        /// <summary>
        /// Swap to elements of the input array and return the new array
        /// If i and j are equal, the original array is returned
        /// </summary>
        private static List<T> Swap<T>(List<T> array, int i, int j)
        {
            if (i == j) return array;

            var result = array.ToList();
            result[i] = array[j];
            result[j] = array[i];
            return result;
        }
    }
}