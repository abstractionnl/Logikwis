  
 
  
  
  
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logikwis {
	
	public class Solution<T1>  {
		public IReadOnlyCollection<Combination<T1>> Combinations { get; }

		public Solution(IReadOnlyCollection<Combination<T1>> combinations) {
			Combinations = combinations;
		}

		public Solution(params Combination<T1>[] combinations) {
			Combinations = combinations;
		}

		public bool Equals(Solution<T1> obj) =>
			Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Solution<T1>) obj);
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
	
	public class Solution<T1,T2>  {
		public IReadOnlyCollection<Combination<T1,T2>> Combinations { get; }

		public Solution(IReadOnlyCollection<Combination<T1,T2>> combinations) {
			Combinations = combinations;
		}

		public Solution(params Combination<T1,T2>[] combinations) {
			Combinations = combinations;
		}

		public bool Equals(Solution<T1,T2> obj) =>
			Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Solution<T1,T2>) obj);
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
	
	public class Solution<T1,T2,T3>  {
		public IReadOnlyCollection<Combination<T1,T2,T3>> Combinations { get; }

		public Solution(IReadOnlyCollection<Combination<T1,T2,T3>> combinations) {
			Combinations = combinations;
		}

		public Solution(params Combination<T1,T2,T3>[] combinations) {
			Combinations = combinations;
		}

		public bool Equals(Solution<T1,T2,T3> obj) =>
			Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Solution<T1,T2,T3>) obj);
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
	
	public class Solution<T1,T2,T3,T4>  {
		public IReadOnlyCollection<Combination<T1,T2,T3,T4>> Combinations { get; }

		public Solution(IReadOnlyCollection<Combination<T1,T2,T3,T4>> combinations) {
			Combinations = combinations;
		}

		public Solution(params Combination<T1,T2,T3,T4>[] combinations) {
			Combinations = combinations;
		}

		public bool Equals(Solution<T1,T2,T3,T4> obj) =>
			Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Solution<T1,T2,T3,T4>) obj);
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
	
	public class Solution<T1,T2,T3,T4,T5>  {
		public IReadOnlyCollection<Combination<T1,T2,T3,T4,T5>> Combinations { get; }

		public Solution(IReadOnlyCollection<Combination<T1,T2,T3,T4,T5>> combinations) {
			Combinations = combinations;
		}

		public Solution(params Combination<T1,T2,T3,T4,T5>[] combinations) {
			Combinations = combinations;
		}

		public bool Equals(Solution<T1,T2,T3,T4,T5> obj) =>
			Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Solution<T1,T2,T3,T4,T5>) obj);
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
	
	public class Solution<T1,T2,T3,T4,T5,T6>  {
		public IReadOnlyCollection<Combination<T1,T2,T3,T4,T5,T6>> Combinations { get; }

		public Solution(IReadOnlyCollection<Combination<T1,T2,T3,T4,T5,T6>> combinations) {
			Combinations = combinations;
		}

		public Solution(params Combination<T1,T2,T3,T4,T5,T6>[] combinations) {
			Combinations = combinations;
		}

		public bool Equals(Solution<T1,T2,T3,T4,T5,T6> obj) =>
			Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Solution<T1,T2,T3,T4,T5,T6>) obj);
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
	
	public class Solution<T1,T2,T3,T4,T5,T6,T7>  {
		public IReadOnlyCollection<Combination<T1,T2,T3,T4,T5,T6,T7>> Combinations { get; }

		public Solution(IReadOnlyCollection<Combination<T1,T2,T3,T4,T5,T6,T7>> combinations) {
			Combinations = combinations;
		}

		public Solution(params Combination<T1,T2,T3,T4,T5,T6,T7>[] combinations) {
			Combinations = combinations;
		}

		public bool Equals(Solution<T1,T2,T3,T4,T5,T6,T7> obj) =>
			Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Solution<T1,T2,T3,T4,T5,T6,T7>) obj);
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
	
	public class Solution<T1,T2,T3,T4,T5,T6,T7,T8>  {
		public IReadOnlyCollection<Combination<T1,T2,T3,T4,T5,T6,T7,T8>> Combinations { get; }

		public Solution(IReadOnlyCollection<Combination<T1,T2,T3,T4,T5,T6,T7,T8>> combinations) {
			Combinations = combinations;
		}

		public Solution(params Combination<T1,T2,T3,T4,T5,T6,T7,T8>[] combinations) {
			Combinations = combinations;
		}

		public bool Equals(Solution<T1,T2,T3,T4,T5,T6,T7,T8> obj) =>
			Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Solution<T1,T2,T3,T4,T5,T6,T7,T8>) obj);
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
	
	public class Solution<T1,T2,T3,T4,T5,T6,T7,T8,T9>  {
		public IReadOnlyCollection<Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9>> Combinations { get; }

		public Solution(IReadOnlyCollection<Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9>> combinations) {
			Combinations = combinations;
		}

		public Solution(params Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9>[] combinations) {
			Combinations = combinations;
		}

		public bool Equals(Solution<T1,T2,T3,T4,T5,T6,T7,T8,T9> obj) =>
			Combinations.Count == obj.Combinations.Count && Combinations.All(c => obj.Combinations.Contains(c));

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Solution<T1,T2,T3,T4,T5,T6,T7,T8,T9>) obj);
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
