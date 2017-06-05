using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Logikwis
{
    public class SolutionGenerator
    {
        public class SolutionGeneratorException : Exception
        {
            public SolutionGeneratorException(string message) : base(message)
            {
            }
        }

        public static IEnumerable<Solution<Combination<T1, T2>>> Generate<T1, T2>(IReadOnlyCollection<T1> a, IReadOnlyCollection<T2> b)
        {
            if (a.Count != b.Count)
                throw new SolutionGeneratorException("Cannot combine arrays of different lengths");

            if (a.Count == 0)
                return Enumerable.Empty<Solution<Combination<T1, T2>>>();

            return GenerateInternal(Enumerable.Empty<Combination<T1, T2>>(), a, b, a.Count)
                .Select(Solution.Create);
        }

        public static IEnumerable<IReadOnlyCollection<Combination<T1, T2>>> GenerateInternal<T1, T2>(
            IEnumerable<Combination<T1, T2>> current,
            IEnumerable<T1> a,
            IEnumerable<T2> b,
            int remaining)
        {
            IEnumerable<Combination<T1, T2>> AddToSolution(T1 a1, T2 b1) => 
                current.Append(Combination.Create(a1, b1));

            if (remaining == 1)
                return Enumerable.Repeat(AddToSolution(a.First(), b.First()).ToList(), 1);

            var itemOfA = a.PickList().First();

            return
                from itemOfB in b.PickList()
                let partialSolution = AddToSolution(itemOfA.Current, itemOfB.Current)
                from solution in GenerateInternal(
                    partialSolution,
                    itemOfA.Others,
                    itemOfB.Others,
                    remaining - 1)
                select solution;
        }

        public static IEnumerable<Solution<Combination<T1, T2, T3>>> Generate<T1, T2, T3>(IReadOnlyCollection<T1> a, 
            IReadOnlyCollection<T2> b, IReadOnlyCollection<T3> c)
        {
            if (a.Count != b.Count || a.Count != c.Count)
                throw new SolutionGeneratorException("Cannot combine arrays of different lengths");

            if (a.Count == 0)
                return Enumerable.Empty<Solution<Combination<T1, T2, T3>>>();

            return GenerateInternal(Enumerable.Empty<Combination<T1, T2, T3>>(), a, b, c, a.Count).Select(x => Solution.Create(x.ToList()));
        }

        public static IEnumerable<IReadOnlyCollection<Combination<T1, T2, T3>>> GenerateInternal<T1, T2, T3>(
            IEnumerable<Combination<T1, T2, T3>> current,
            IEnumerable<T1> a,
            IEnumerable<T2> b,
            IEnumerable<T3> c,
            int remaining)
        {
            IEnumerable<Combination<T1, T2, T3>> AddToSolution(T1 a1, T2 b1, T3 c3) =>
                current.Append(Combination.Create(a1, b1, c3));

            if (remaining == 1)
                return Enumerable.Repeat(current.Append(Combination.Create(a.First(), b.First(), c.First())).ToList(), 1);

            var itemOfA = a.PickList().First();

            return
                from itemOfB in b.PickList()
                from itemOfC in c.PickList()
                let partialSolution = AddToSolution(itemOfA.Current, itemOfB.Current, itemOfC.Current)
                from solution in GenerateInternal(
                    partialSolution,
                    itemOfA.Others,
                    itemOfB.Others,
                    itemOfC.Others,
                    remaining - 1)
                select solution;
        }

        public static IEnumerable<Solution<Combination<T1, T2, T3, T4>>> Generate<T1, T2, T3, T4>(IReadOnlyCollection<T1> a,
            IReadOnlyCollection<T2> b, IReadOnlyCollection<T3> c, IReadOnlyCollection<T4> d)
        {
            if (a.Count != b.Count || a.Count != c.Count || a.Count != d.Count)
                throw new SolutionGeneratorException("Cannot combine arrays of different lengths");

            return
                from pB in Permutator.Permutate(b)
                from pC in Permutator.Permutate(c)
                from pD in Permutator.Permutate(d)
                select Solution.Create(Combination<T1, T2, T3, T4>.Zip(a, pB, pC, pD).ToList());
        }

        public static IEnumerable<Solution<Combination<T1, T2, T3, T4, T5>>> Generate<T1, T2, T3, T4, T5>(IReadOnlyCollection<T1> a,
            IReadOnlyCollection<T2> b, IReadOnlyCollection<T3> c, IReadOnlyCollection<T4> d, IReadOnlyCollection<T5> e)
        {
            if (a.Count != b.Count || a.Count != c.Count || a.Count != d.Count)
                throw new SolutionGeneratorException("Cannot combine arrays of different lengths");

            return
                from pB in Permutator.Permutate(b)
                from pC in Permutator.Permutate(c)
                from pD in Permutator.Permutate(d)
                from pE in Permutator.Permutate(e)
                select Solution.Create(Combination<T1, T2, T3, T4, T5>.Zip(a, pB, pC, pD, pE).ToList());
        }
    }
}