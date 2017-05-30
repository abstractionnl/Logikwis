using System.Collections;
using System.Collections.Generic;

namespace Logikwis.Test
{
    public class ArrayItemEqualityComparer<T> : IEqualityComparer<IEnumerable<T>>
    {
        private readonly IEqualityComparer<T> _comparer;

        public ArrayItemEqualityComparer(IEqualityComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public ArrayItemEqualityComparer()
        {
            _comparer = EqualityComparer<T>.Default;
        }

        public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
        {
            using (var e1 = x.GetEnumerator())
            using (var e2 = y.GetEnumerator())
            {
                while (e1.MoveNext())
                {
                    if (e2.MoveNext())
                    {
                        if (!_comparer.Equals(e1.Current, e2.Current)) return false;
                    }
                    else
                    {
                        return false;
                    }
                }

                if (e2.MoveNext())
                {
                    return false;
                }
            }

            return true;
        }

        public int GetHashCode(IEnumerable<T> obj)
        {
            var x = 17;

            foreach (var a in obj)
            {
                x += _comparer.GetHashCode(a) + x * 37;
            }

            return x;
        }
    }
}