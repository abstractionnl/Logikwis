using System.Collections.Generic;
using System.Linq;

namespace Logikwis
{
    public class PickedArrayItem<T>
    {
        private readonly IReadOnlyList<T> _source;
        private readonly int _current;

        internal PickedArrayItem(IReadOnlyList<T> source, int current)
        {
            _source = source;
            _current = current;
        }

        public T Current => _source[_current];

        public IEnumerable<T> Others => _source.Take(_current).Union(_source.Skip(_current+1));
    }
}