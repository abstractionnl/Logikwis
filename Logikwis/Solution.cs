using System.Collections.Generic;
using System.Linq;

namespace Logikwis
{
    public class Solution<TCombination>
    {
        public IReadOnlyCollection<TCombination> Combinations { get; }

        public Solution(IReadOnlyCollection<TCombination> combinations)
        {
            Combinations = combinations;
        }

        public Solution(params TCombination[] combinations)
        {
            Combinations = combinations;
        }

        public bool Equals(Solution<TCombination> obj) =>
            Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this)) return true;
            if (ReferenceEquals(obj, null)) return false;
            if (obj.GetType() != GetType()) return false;
            return Equals((Solution<TCombination>)obj);
        }

        public override int GetHashCode()
        {
            return Combinations.GetHashCode();
        }

        public override string ToString()
        {
            return $"[{string.Join(",", Combinations)}]";
        }
    }
}
