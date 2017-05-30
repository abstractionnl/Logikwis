using System.Collections.Generic;
using System.Linq;
using Logikwis.Test;
using NFluent;
using Xunit;

namespace Logikwis.Test
{
    public class PermutatorTest
    {
        [Fact]
        public void EmptyListReturnsNoResults()
        {
            var result = Permutator.Permutate(new string[0]);

            Check.That(result).IsEmpty();
        }

        [Fact]
        public void ListWithOneElementReturnsOneResult()
        {
            var result = Permutator.Permutate(new[] { "one" }).ToList();

            ValidateResult(result, new[]
            {
                new[] { "one" }
            });
        }

        [Fact]
        public void ListWithTwoElementsReturnsTwoResults()
        {
            var result = Permutator.Permutate(new[] { "one", "two" }).ToList();

            ValidateResult(result, new[]
            {
                new[] {"one", "two"},
                new[] {"two", "one"}
            });
        }

        [Fact]
        public void ListWithThreeElementsReturnsSixResults()
        {
            var result = Permutator.Permutate(new[] { "one", "two", "three" }).ToList();

            ValidateResult(result, new[]
            {
                new[] {"one", "two", "three"},
                new[] {"one", "three", "two"},
                new[] {"two", "one", "three"},
                new[] {"two", "three", "one"},
                new[] {"three", "one", "two"},
                new[] {"three", "two", "one"}
            });
        }

        [Theory, InlineData(0, 0), InlineData(1, 1), InlineData(2, 2), InlineData(3, 6), InlineData(4, 24), InlineData(5, 120), /* InlineData(10, 3628800) */]
        public void TestHasEnoughPermutations(int items, int expectedTotal)
        {
            var result = Permutator.Permutate(Enumerable.Range(0, items).ToList()).ToList();

            Check.That(result.Distinct(new ArrayItemEqualityComparer<int>())).HasSize(expectedTotal);
        }

        private static void ValidateResult<T>(ICollection<IReadOnlyList<T>> result, ICollection<T[]> expected)
        {
            Check.That(result).HasSize(expected.Count);
            Check.That(result).Contains(expected, new ArrayItemEqualityComparer<T>());
        }
    }
}