using NFluent;
using Xunit;

namespace Logikwis.Test
{
    public class ArrayItemEqualityComparerTests
    {
        [Fact]
        public void EmptyArraysAreEqual()
        {
            var comparer = new ArrayItemEqualityComparer<string>();

            Check.That(comparer.Equals(new string[0], new string[0])).IsTrue();
        }

        public void ArraysAreEqual()
        {
            var comparer = new ArrayItemEqualityComparer<string>();

            Check.That(comparer.Equals(new []{ "a" }, new[] { "a" })).IsTrue();
            Check.That(comparer.Equals(new[] { "a", "b" }, new[] { "a", "b" })).IsTrue();
        }

        public void ArrayWithDifferentItemIsNotEqual()
        {
            var comparer = new ArrayItemEqualityComparer<string>();

            Check.That(comparer.Equals(new[] { "a" }, new[] { "b" })).IsFalse();
        }

        public void ArrayWithDifferentLengthsAreNotEqual()
        {
            var comparer = new ArrayItemEqualityComparer<string>();

            Check.That(comparer.Equals(new[] { "a", "b" }, new[] { "a" })).IsFalse();
            Check.That(comparer.Equals(new[] { "a" }, new[] { "a", "b" })).IsFalse();
        }
    }
}