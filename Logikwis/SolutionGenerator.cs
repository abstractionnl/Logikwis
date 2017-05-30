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

        public static IEnumerable<Solution<T1>> Generate<T1>(IReadOnlyCollection<T1> a)
        {
            if (a.Count == 0)
                yield break;

            yield return new Solution<T1>(Combination<T1>.Zip(a).ToList());
        }

        public static IEnumerable<Solution<T1, T2>> Generate<T1, T2>(IReadOnlyCollection<T1> a, IReadOnlyCollection<T2> b)
        {
            if (a.Count != b.Count)
                throw new SolutionGeneratorException("Cannot combine arrays of different lengths");

            return 
                from pB in Permutator.Permutate(b)
                select new Solution<T1, T2>(Combination<T1, T2>.Zip(a, pB).ToList());
        }

        public static IEnumerable<Solution<T1, T2, T3>> Generate<T1, T2, T3>(IReadOnlyCollection<T1> a, 
            IReadOnlyCollection<T2> b, IReadOnlyCollection<T3> c)
        {
            if (a.Count != b.Count || a.Count != c.Count)
                throw new SolutionGeneratorException("Cannot combine arrays of different lengths");

            return
                from pB in Permutator.Permutate(b)
                from pC in Permutator.Permutate(c)
                select new Solution<T1, T2, T3>(Combination<T1, T2, T3>.Zip(a, pB, pC).ToList());
        }

        public static IEnumerable<Solution<T1, T2, T3, T4>> Generate<T1, T2, T3, T4>(IReadOnlyCollection<T1> a,
            IReadOnlyCollection<T2> b, IReadOnlyCollection<T3> c, IReadOnlyCollection<T4> d)
        {
            if (a.Count != b.Count || a.Count != c.Count || a.Count != d.Count)
                throw new SolutionGeneratorException("Cannot combine arrays of different lengths");

            return
                from pB in Permutator.Permutate(b)
                from pC in Permutator.Permutate(c)
                from pD in Permutator.Permutate(d)
                select new Solution<T1, T2, T3, T4>(Combination<T1, T2, T3, T4>.Zip(a, pB, pC, pD).ToList());
        }

        public static IEnumerable<Solution<T1, T2, T3, T4, T5>> Generate<T1, T2, T3, T4, T5>(IReadOnlyCollection<T1> a,
            IReadOnlyCollection<T2> b, IReadOnlyCollection<T3> c, IReadOnlyCollection<T4> d, IReadOnlyCollection<T5> e)
        {
            if (a.Count != b.Count || a.Count != c.Count || a.Count != d.Count)
                throw new SolutionGeneratorException("Cannot combine arrays of different lengths");

            return
                from pB in Permutator.Permutate(b)
                from pC in Permutator.Permutate(c)
                from pD in Permutator.Permutate(d)
                from pE in Permutator.Permutate(e)
                select new Solution<T1, T2, T3, T4, T5>(Combination<T1, T2, T3, T4, T5>.Zip(a, pB, pC, pD, pE).ToList());
        }
    }
}