using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NFluent;
using NFluent.Extensibility;
using NFluent.Extensions;

namespace Logikwis.Test
{
    public static class EnumerableCheckExtensions
    {
        public static IExtendableCheckLink<IEnumerable<T>, IEnumerable<T>> Contains<T>(this ICheck<IEnumerable<T>> check, IEnumerable<T> otherEnumerable, IEqualityComparer<T> comparer)
        {
            var checker = ExtensibilityHelper.ExtractChecker(check);

            checker.ExecuteCheck(
                () =>
                {
                    if (otherEnumerable == null)
                    {
                        return;
                    }

                    if (checker.Value == null)
                    {
                        var message = checker.BuildMessage("The {0} is null and thus, does not contain the given expected value(s).").ExpectedValues(otherEnumerable).ToString();
                        throw new FluentCheckException(message);
                    }

                    var notFoundValues = ExtractNotFoundValues(checker.Value, otherEnumerable, comparer);

                    if (notFoundValues.Count > 0)
                    {
                        var message = checker.BuildMessage(string.Format("The {{0}} does not contain the expected value(s):" + Environment.NewLine + "\t[{0}]", notFoundValues.ToEnumeratedString().DoubleCurlyBraces())).ExpectedValues(otherEnumerable).ToString();
                        throw new FluentCheckException(message);
                    }
                },
                checker.BuildMessage("The {0} contains all the given values whereas it must not.").ExpectedValues(otherEnumerable).ToString());

            return ExtensibilityHelper.BuildExtendableCheckLink(check, otherEnumerable);
        }

        private static IList ExtractNotFoundValues<T>(IEnumerable<T> enumerable, IEnumerable<T> expectedValues, IEqualityComparer<T> comparer)
        {
            // Prepares the list to return

            var values = expectedValues as T[] ?? expectedValues.ToArray();
            var notFoundValues = values.ToList();

            foreach (var element in enumerable)
            {
                foreach (var expectedValue in values)
                {
                    if (!comparer.Equals(element, expectedValue)) continue;
                    notFoundValues.RemoveAll(one => Equals(one, expectedValue));
                    break;
                }
            }

            return notFoundValues;
        }
    }
}