using System.Collections.Generic;
using System.Linq;

namespace Logikwis
{
    public static class Solution
    {
        public static Solution<TCombination> Create<TCombination>(IReadOnlyCollection<TCombination> combinations) =>
            new Solution<TCombination>(combinations);
    }

    public class Solution<TCombination>
    {
        public IReadOnlyCollection<TCombination> Combinations { get; }

        public Solution(IReadOnlyCollection<TCombination> combinations)
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
