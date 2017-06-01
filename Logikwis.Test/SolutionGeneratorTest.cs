using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using NFluent;
using Xunit;

namespace Logikwis.Test
{
    public class SolutionGeneratorTests
    {
        [Fact]
        public void CombiningWithZeroLengthReturnsNothing()
        {
            CheckCollection(A<int>(), A<int>());
            CheckCollection(A<int>(), A<int>(), A<int>());
        }

        [Fact]
        public void Combine_1_Element_Returns_1_Permutation()
        {
            CheckCollection(A(1), A(2),
                S(C(1, 2))
            );

            CheckCollection(A(1), A(2), A(3),
                S(C(1, 2, 3))
            );
        }

        [Fact]
        public void Combine_2x2_ElementsReturns_2_Permutations()
        {
            CheckCollection(A(1, 2), A(11, 12),
                S(C(1, 11), C(2, 12)),
                S(C(1, 12), C(2, 11))
            );
        }

        [Fact]
        public void Combine_2x3_ElementsReturns_6_Permutations()
        {
            CheckCollection(A(1, 2, 3), A(11, 12, 13),
                S(C(1, 11), C(2, 12), C(3, 13)),
                S(C(1, 11), C(2, 13), C(3, 12)),
                S(C(1, 12), C(2, 11), C(3, 13)),
                S(C(1, 12), C(2, 13), C(3, 11)),
                S(C(1, 13), C(2, 11), C(3, 12)),
                S(C(1, 13), C(2, 12), C(3, 11))
            );
        }

        [Fact]
        public void Combine_3x2_ElementsReturns_4_Permutations()
        {
            CheckCollection(A(1, 2), A(11, 12), A(21, 22),
                S(C(1, 11, 21), C(2, 12, 22)),
                S(C(1, 11, 22), C(2, 12, 21)),
                S(C(1, 12, 21), C(2, 11, 22)),
                S(C(1, 12, 22), C(2, 11, 21))
            );
        }

        [Fact]
        public void Combine_3x3_ElementsReturns_36_Permutations()
        {
            CheckCollection(A(1, 2, 3), A(11, 12, 13), A(21, 22, 23),
                S(C(1, 11, 21), C(2, 12, 22), C(3, 13, 23)),
                S(C(1, 11, 21), C(2, 12, 23), C(3, 13, 22)),
                S(C(1, 11, 22), C(2, 12, 21), C(3, 13, 23)),
                S(C(1, 11, 22), C(2, 12, 23), C(3, 13, 21)),
                S(C(1, 11, 23), C(2, 12, 21), C(3, 13, 22)),
                S(C(1, 11, 23), C(2, 12, 22), C(3, 13, 21)),

                S(C(1, 11, 21), C(2, 13, 22), C(3, 12, 23)),
                S(C(1, 11, 21), C(2, 13, 23), C(3, 12, 22)),
                S(C(1, 11, 22), C(2, 13, 21), C(3, 12, 23)),
                S(C(1, 11, 22), C(2, 13, 23), C(3, 12, 21)),
                S(C(1, 11, 23), C(2, 13, 21), C(3, 12, 22)),
                S(C(1, 11, 23), C(2, 13, 22), C(3, 12, 21)),

                S(C(1, 12, 21), C(2, 11, 22), C(3, 13, 23)),
                S(C(1, 12, 21), C(2, 11, 23), C(3, 13, 22)),
                S(C(1, 12, 22), C(2, 11, 21), C(3, 13, 23)),
                S(C(1, 12, 22), C(2, 11, 23), C(3, 13, 21)),
                S(C(1, 12, 23), C(2, 11, 21), C(3, 13, 22)),
                S(C(1, 12, 23), C(2, 11, 22), C(3, 13, 21)),

                S(C(1, 12, 21), C(2, 13, 22), C(3, 11, 23)),
                S(C(1, 12, 21), C(2, 13, 23), C(3, 11, 22)),
                S(C(1, 12, 22), C(2, 13, 21), C(3, 11, 23)),
                S(C(1, 12, 22), C(2, 13, 23), C(3, 11, 21)),
                S(C(1, 12, 23), C(2, 13, 21), C(3, 11, 22)),
                S(C(1, 12, 23), C(2, 13, 22), C(3, 11, 21)),

                S(C(1, 13, 21), C(2, 11, 22), C(3, 12, 23)),
                S(C(1, 13, 21), C(2, 11, 23), C(3, 12, 22)),
                S(C(1, 13, 22), C(2, 11, 21), C(3, 12, 23)),
                S(C(1, 13, 22), C(2, 11, 23), C(3, 12, 21)),
                S(C(1, 13, 23), C(2, 11, 21), C(3, 12, 22)),
                S(C(1, 13, 23), C(2, 11, 22), C(3, 12, 21)),

                S(C(1, 13, 21), C(2, 12, 22), C(3, 11, 23)),
                S(C(1, 13, 21), C(2, 12, 23), C(3, 11, 22)),
                S(C(1, 13, 22), C(2, 12, 21), C(3, 11, 23)),
                S(C(1, 13, 22), C(2, 12, 23), C(3, 11, 21)),
                S(C(1, 13, 23), C(2, 12, 21), C(3, 11, 22)),
                S(C(1, 13, 23), C(2, 12, 22), C(3, 11, 21))
            );
        }

        [Theory]
        [InlineData(0, 0), InlineData(1, 1),  InlineData(2, 2),
         InlineData(3, 6), InlineData(4, 24), InlineData(5, 120)]
        public void TestHasEnoughPermutationsWith2Elements(int items, int expectedTotal)
        {
            
            var a = Enumerable.Range(0, items).ToList();
            var b = Enumerable.Range(items, items).ToList();
            var combinations = SolutionGenerator.Generate(a, b);

            // Should have items! combinations
            Check.That(combinations).HasSize(expectedTotal);
        }

        [Theory]
        [InlineData(0, 0),  InlineData(1, 1),   InlineData(2, 4),
         InlineData(3, 36), InlineData(4, 576), InlineData(5, 14400)]
        public void TestHasEnoughPermutationsWith3Elements(int items, int expectedTotal)
        {
            var a = Enumerable.Range(0, items).ToList();
            var b = Enumerable.Range(items, items).ToList();
            var c = Enumerable.Range(items*2, items).ToList();
            var combinations = SolutionGenerator.Generate(a, b, c);

            // Should have items! * items! combinations
            Check.That(combinations).HasSize(expectedTotal);
        }

        [Theory]
        [InlineData(0, 0),   InlineData(1, 1),     InlineData(2, 8),
         InlineData(3, 216), InlineData(4, 13824), InlineData(5, 1728000)]
        public void TestHasEnoughPermutationsWith4Elements(int items, int expectedTotal)
        {
            var a = Enumerable.Range(0, items).ToList();
            var b = Enumerable.Range(items, items).ToList();
            var c = Enumerable.Range(items * 2, items).ToList();
            var d = Enumerable.Range(items * 3, items).ToList();
            var combinations = SolutionGenerator.Generate(a, b, c, d);

            // Should have items! * items! * items! combinations
            Check.That(combinations).HasSize(expectedTotal);
        }

        [Theory]
        [InlineData(0, 0),    InlineData(1, 1), InlineData(2, 16),
         InlineData(3, 1296), InlineData(4, 331776)]
        public void TestHasEnoughPermutationsWith5Elements(int items, int expectedTotal)
        {
            var a = Enumerable.Range(0, items).ToList();
            var b = Enumerable.Range(items, items).ToList();
            var c = Enumerable.Range(items * 2, items).ToList();
            var d = Enumerable.Range(items * 3, items).ToList();
            var e = Enumerable.Range(items * 4, items).ToList();
            var combinations = SolutionGenerator.Generate(a, b, c, d, e);

            // Should have items! * items! * items! combinations
            Check.That(combinations).HasSize(expectedTotal);
        }

        private static IReadOnlyCollection<T> A<T>(params T[] a) => a;

        private static Combination<int, int> C(int a, int b) => new Combination<int, int>(a, b);

        private static Combination<int, int, int> C(int a, int b, int c) => new Combination<int, int, int>(a, b, c);

        private static Solution<Combination<int, int>> S(params Combination<int, int>[] combinations) => new Solution<Combination<int, int>>(combinations);

        private static Solution<Combination<int, int, int>> S(params Combination<int, int, int>[] combinations) => new Solution<Combination<int, int, int>>(combinations);

        private void CheckCollection(IReadOnlyCollection<int> a, IReadOnlyCollection<int> b, params Solution<Combination<int, int>>[] result)
        {
            var combinations = SolutionGenerator.Generate(a, b).ToList();

            Check.That(combinations).Contains(result).And.HasSize(result.Length);
        }

        private void CheckCollection(IReadOnlyCollection<int> a, IReadOnlyCollection<int> b, IReadOnlyCollection<int> c, params Solution<Combination<int, int, int>>[] result)
        {
            var combinations = SolutionGenerator.Generate(a, b, c).ToList();

            Check.That(combinations).Contains(result).And.HasSize(result.Length);
        }
    }
}
