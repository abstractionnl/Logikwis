  
 
  
  
  
using System;
using System.Collections.Generic;

namespace Logikwis {
	
	public class Combination<T1>  {
		public T1 Value1 { get; }

		public Combination(T1 value1) {
			Value1 = value1;
		}

		public bool Equals(Combination<T1> obj) =>
			EqualityComparer<T1>.Default.Equals(Value1, obj.Value1);

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Combination<T1>) obj);
		}

		public override int GetHashCode() {
			var hashCode = 0;
			hashCode = hashCode * 397 ^ EqualityComparer<T1>.Default.GetHashCode(Value1);
			return hashCode;
		}

		public Combination<T1,T2> Add<T2>(T2 value2) =>
			new Combination<T1,T2>(Value1, value2);

		public static IEnumerable<Combination<T1>> Zip(IEnumerable<T1> values1) {
			using (var enumerator1 = values1.GetEnumerator())
			{
				while (enumerator1.MoveNext()) {
					yield return new Combination<T1>(enumerator1.Current);
				}
			}
		}

		public override string ToString() => string.Format("<{0}>", Value1);

	}
	
	public class Combination<T1,T2>  {
		public T1 Value1 { get; }
		public T2 Value2 { get; }

		public Combination(T1 value1, T2 value2) {
			Value1 = value1;
			Value2 = value2;
		}

		public bool Equals(Combination<T1,T2> obj) =>
			EqualityComparer<T1>.Default.Equals(Value1, obj.Value1) &&
			EqualityComparer<T2>.Default.Equals(Value2, obj.Value2);

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Combination<T1,T2>) obj);
		}

		public override int GetHashCode() {
			var hashCode = 0;
			hashCode = hashCode * 397 ^ EqualityComparer<T1>.Default.GetHashCode(Value1);
			hashCode = hashCode * 397 ^ EqualityComparer<T2>.Default.GetHashCode(Value2);
			return hashCode;
		}

		public Combination<T1,T2,T3> Add<T3>(T3 value3) =>
			new Combination<T1,T2,T3>(Value1, Value2, value3);

		public static IEnumerable<Combination<T1,T2>> Zip(IEnumerable<T1> values1, IEnumerable<T2> values2) {
			using (var enumerator1 = values1.GetEnumerator())
			using (var enumerator2 = values2.GetEnumerator())
			{
				while (enumerator1.MoveNext() && enumerator2.MoveNext()) {
					yield return new Combination<T1,T2>(enumerator1.Current, enumerator2.Current);
				}
			}
		}

		public override string ToString() => string.Format("<{0}, {1}>", Value1, Value2);

	}
	
	public class Combination<T1,T2,T3>  {
		public T1 Value1 { get; }
		public T2 Value2 { get; }
		public T3 Value3 { get; }

		public Combination(T1 value1, T2 value2, T3 value3) {
			Value1 = value1;
			Value2 = value2;
			Value3 = value3;
		}

		public bool Equals(Combination<T1,T2,T3> obj) =>
			EqualityComparer<T1>.Default.Equals(Value1, obj.Value1) &&
			EqualityComparer<T2>.Default.Equals(Value2, obj.Value2) &&
			EqualityComparer<T3>.Default.Equals(Value3, obj.Value3);

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Combination<T1,T2,T3>) obj);
		}

		public override int GetHashCode() {
			var hashCode = 0;
			hashCode = hashCode * 397 ^ EqualityComparer<T1>.Default.GetHashCode(Value1);
			hashCode = hashCode * 397 ^ EqualityComparer<T2>.Default.GetHashCode(Value2);
			hashCode = hashCode * 397 ^ EqualityComparer<T3>.Default.GetHashCode(Value3);
			return hashCode;
		}

		public Combination<T1,T2,T3,T4> Add<T4>(T4 value4) =>
			new Combination<T1,T2,T3,T4>(Value1, Value2, Value3, value4);

		public static IEnumerable<Combination<T1,T2,T3>> Zip(IEnumerable<T1> values1, IEnumerable<T2> values2, IEnumerable<T3> values3) {
			using (var enumerator1 = values1.GetEnumerator())
			using (var enumerator2 = values2.GetEnumerator())
			using (var enumerator3 = values3.GetEnumerator())
			{
				while (enumerator1.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext()) {
					yield return new Combination<T1,T2,T3>(enumerator1.Current, enumerator2.Current, enumerator3.Current);
				}
			}
		}

		public override string ToString() => string.Format("<{0}, {1}, {2}>", Value1, Value2, Value3);

	}
	
	public class Combination<T1,T2,T3,T4>  {
		public T1 Value1 { get; }
		public T2 Value2 { get; }
		public T3 Value3 { get; }
		public T4 Value4 { get; }

		public Combination(T1 value1, T2 value2, T3 value3, T4 value4) {
			Value1 = value1;
			Value2 = value2;
			Value3 = value3;
			Value4 = value4;
		}

		public bool Equals(Combination<T1,T2,T3,T4> obj) =>
			EqualityComparer<T1>.Default.Equals(Value1, obj.Value1) &&
			EqualityComparer<T2>.Default.Equals(Value2, obj.Value2) &&
			EqualityComparer<T3>.Default.Equals(Value3, obj.Value3) &&
			EqualityComparer<T4>.Default.Equals(Value4, obj.Value4);

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Combination<T1,T2,T3,T4>) obj);
		}

		public override int GetHashCode() {
			var hashCode = 0;
			hashCode = hashCode * 397 ^ EqualityComparer<T1>.Default.GetHashCode(Value1);
			hashCode = hashCode * 397 ^ EqualityComparer<T2>.Default.GetHashCode(Value2);
			hashCode = hashCode * 397 ^ EqualityComparer<T3>.Default.GetHashCode(Value3);
			hashCode = hashCode * 397 ^ EqualityComparer<T4>.Default.GetHashCode(Value4);
			return hashCode;
		}

		public Combination<T1,T2,T3,T4,T5> Add<T5>(T5 value5) =>
			new Combination<T1,T2,T3,T4,T5>(Value1, Value2, Value3, Value4, value5);

		public static IEnumerable<Combination<T1,T2,T3,T4>> Zip(IEnumerable<T1> values1, IEnumerable<T2> values2, IEnumerable<T3> values3, IEnumerable<T4> values4) {
			using (var enumerator1 = values1.GetEnumerator())
			using (var enumerator2 = values2.GetEnumerator())
			using (var enumerator3 = values3.GetEnumerator())
			using (var enumerator4 = values4.GetEnumerator())
			{
				while (enumerator1.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext() && enumerator4.MoveNext()) {
					yield return new Combination<T1,T2,T3,T4>(enumerator1.Current, enumerator2.Current, enumerator3.Current, enumerator4.Current);
				}
			}
		}

		public override string ToString() => string.Format("<{0}, {1}, {2}, {3}>", Value1, Value2, Value3, Value4);

	}
	
	public class Combination<T1,T2,T3,T4,T5>  {
		public T1 Value1 { get; }
		public T2 Value2 { get; }
		public T3 Value3 { get; }
		public T4 Value4 { get; }
		public T5 Value5 { get; }

		public Combination(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) {
			Value1 = value1;
			Value2 = value2;
			Value3 = value3;
			Value4 = value4;
			Value5 = value5;
		}

		public bool Equals(Combination<T1,T2,T3,T4,T5> obj) =>
			EqualityComparer<T1>.Default.Equals(Value1, obj.Value1) &&
			EqualityComparer<T2>.Default.Equals(Value2, obj.Value2) &&
			EqualityComparer<T3>.Default.Equals(Value3, obj.Value3) &&
			EqualityComparer<T4>.Default.Equals(Value4, obj.Value4) &&
			EqualityComparer<T5>.Default.Equals(Value5, obj.Value5);

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Combination<T1,T2,T3,T4,T5>) obj);
		}

		public override int GetHashCode() {
			var hashCode = 0;
			hashCode = hashCode * 397 ^ EqualityComparer<T1>.Default.GetHashCode(Value1);
			hashCode = hashCode * 397 ^ EqualityComparer<T2>.Default.GetHashCode(Value2);
			hashCode = hashCode * 397 ^ EqualityComparer<T3>.Default.GetHashCode(Value3);
			hashCode = hashCode * 397 ^ EqualityComparer<T4>.Default.GetHashCode(Value4);
			hashCode = hashCode * 397 ^ EqualityComparer<T5>.Default.GetHashCode(Value5);
			return hashCode;
		}

		public Combination<T1,T2,T3,T4,T5,T6> Add<T6>(T6 value6) =>
			new Combination<T1,T2,T3,T4,T5,T6>(Value1, Value2, Value3, Value4, Value5, value6);

		public static IEnumerable<Combination<T1,T2,T3,T4,T5>> Zip(IEnumerable<T1> values1, IEnumerable<T2> values2, IEnumerable<T3> values3, IEnumerable<T4> values4, IEnumerable<T5> values5) {
			using (var enumerator1 = values1.GetEnumerator())
			using (var enumerator2 = values2.GetEnumerator())
			using (var enumerator3 = values3.GetEnumerator())
			using (var enumerator4 = values4.GetEnumerator())
			using (var enumerator5 = values5.GetEnumerator())
			{
				while (enumerator1.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext() && enumerator4.MoveNext() && enumerator5.MoveNext()) {
					yield return new Combination<T1,T2,T3,T4,T5>(enumerator1.Current, enumerator2.Current, enumerator3.Current, enumerator4.Current, enumerator5.Current);
				}
			}
		}

		public override string ToString() => string.Format("<{0}, {1}, {2}, {3}, {4}>", Value1, Value2, Value3, Value4, Value5);

	}
	
	public class Combination<T1,T2,T3,T4,T5,T6>  {
		public T1 Value1 { get; }
		public T2 Value2 { get; }
		public T3 Value3 { get; }
		public T4 Value4 { get; }
		public T5 Value5 { get; }
		public T6 Value6 { get; }

		public Combination(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) {
			Value1 = value1;
			Value2 = value2;
			Value3 = value3;
			Value4 = value4;
			Value5 = value5;
			Value6 = value6;
		}

		public bool Equals(Combination<T1,T2,T3,T4,T5,T6> obj) =>
			EqualityComparer<T1>.Default.Equals(Value1, obj.Value1) &&
			EqualityComparer<T2>.Default.Equals(Value2, obj.Value2) &&
			EqualityComparer<T3>.Default.Equals(Value3, obj.Value3) &&
			EqualityComparer<T4>.Default.Equals(Value4, obj.Value4) &&
			EqualityComparer<T5>.Default.Equals(Value5, obj.Value5) &&
			EqualityComparer<T6>.Default.Equals(Value6, obj.Value6);

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Combination<T1,T2,T3,T4,T5,T6>) obj);
		}

		public override int GetHashCode() {
			var hashCode = 0;
			hashCode = hashCode * 397 ^ EqualityComparer<T1>.Default.GetHashCode(Value1);
			hashCode = hashCode * 397 ^ EqualityComparer<T2>.Default.GetHashCode(Value2);
			hashCode = hashCode * 397 ^ EqualityComparer<T3>.Default.GetHashCode(Value3);
			hashCode = hashCode * 397 ^ EqualityComparer<T4>.Default.GetHashCode(Value4);
			hashCode = hashCode * 397 ^ EqualityComparer<T5>.Default.GetHashCode(Value5);
			hashCode = hashCode * 397 ^ EqualityComparer<T6>.Default.GetHashCode(Value6);
			return hashCode;
		}

		public Combination<T1,T2,T3,T4,T5,T6,T7> Add<T7>(T7 value7) =>
			new Combination<T1,T2,T3,T4,T5,T6,T7>(Value1, Value2, Value3, Value4, Value5, Value6, value7);

		public static IEnumerable<Combination<T1,T2,T3,T4,T5,T6>> Zip(IEnumerable<T1> values1, IEnumerable<T2> values2, IEnumerable<T3> values3, IEnumerable<T4> values4, IEnumerable<T5> values5, IEnumerable<T6> values6) {
			using (var enumerator1 = values1.GetEnumerator())
			using (var enumerator2 = values2.GetEnumerator())
			using (var enumerator3 = values3.GetEnumerator())
			using (var enumerator4 = values4.GetEnumerator())
			using (var enumerator5 = values5.GetEnumerator())
			using (var enumerator6 = values6.GetEnumerator())
			{
				while (enumerator1.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext() && enumerator4.MoveNext() && enumerator5.MoveNext() && enumerator6.MoveNext()) {
					yield return new Combination<T1,T2,T3,T4,T5,T6>(enumerator1.Current, enumerator2.Current, enumerator3.Current, enumerator4.Current, enumerator5.Current, enumerator6.Current);
				}
			}
		}

		public override string ToString() => string.Format("<{0}, {1}, {2}, {3}, {4}, {5}>", Value1, Value2, Value3, Value4, Value5, Value6);

	}
	
	public class Combination<T1,T2,T3,T4,T5,T6,T7>  {
		public T1 Value1 { get; }
		public T2 Value2 { get; }
		public T3 Value3 { get; }
		public T4 Value4 { get; }
		public T5 Value5 { get; }
		public T6 Value6 { get; }
		public T7 Value7 { get; }

		public Combination(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) {
			Value1 = value1;
			Value2 = value2;
			Value3 = value3;
			Value4 = value4;
			Value5 = value5;
			Value6 = value6;
			Value7 = value7;
		}

		public bool Equals(Combination<T1,T2,T3,T4,T5,T6,T7> obj) =>
			EqualityComparer<T1>.Default.Equals(Value1, obj.Value1) &&
			EqualityComparer<T2>.Default.Equals(Value2, obj.Value2) &&
			EqualityComparer<T3>.Default.Equals(Value3, obj.Value3) &&
			EqualityComparer<T4>.Default.Equals(Value4, obj.Value4) &&
			EqualityComparer<T5>.Default.Equals(Value5, obj.Value5) &&
			EqualityComparer<T6>.Default.Equals(Value6, obj.Value6) &&
			EqualityComparer<T7>.Default.Equals(Value7, obj.Value7);

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Combination<T1,T2,T3,T4,T5,T6,T7>) obj);
		}

		public override int GetHashCode() {
			var hashCode = 0;
			hashCode = hashCode * 397 ^ EqualityComparer<T1>.Default.GetHashCode(Value1);
			hashCode = hashCode * 397 ^ EqualityComparer<T2>.Default.GetHashCode(Value2);
			hashCode = hashCode * 397 ^ EqualityComparer<T3>.Default.GetHashCode(Value3);
			hashCode = hashCode * 397 ^ EqualityComparer<T4>.Default.GetHashCode(Value4);
			hashCode = hashCode * 397 ^ EqualityComparer<T5>.Default.GetHashCode(Value5);
			hashCode = hashCode * 397 ^ EqualityComparer<T6>.Default.GetHashCode(Value6);
			hashCode = hashCode * 397 ^ EqualityComparer<T7>.Default.GetHashCode(Value7);
			return hashCode;
		}

		public Combination<T1,T2,T3,T4,T5,T6,T7,T8> Add<T8>(T8 value8) =>
			new Combination<T1,T2,T3,T4,T5,T6,T7,T8>(Value1, Value2, Value3, Value4, Value5, Value6, Value7, value8);

		public static IEnumerable<Combination<T1,T2,T3,T4,T5,T6,T7>> Zip(IEnumerable<T1> values1, IEnumerable<T2> values2, IEnumerable<T3> values3, IEnumerable<T4> values4, IEnumerable<T5> values5, IEnumerable<T6> values6, IEnumerable<T7> values7) {
			using (var enumerator1 = values1.GetEnumerator())
			using (var enumerator2 = values2.GetEnumerator())
			using (var enumerator3 = values3.GetEnumerator())
			using (var enumerator4 = values4.GetEnumerator())
			using (var enumerator5 = values5.GetEnumerator())
			using (var enumerator6 = values6.GetEnumerator())
			using (var enumerator7 = values7.GetEnumerator())
			{
				while (enumerator1.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext() && enumerator4.MoveNext() && enumerator5.MoveNext() && enumerator6.MoveNext() && enumerator7.MoveNext()) {
					yield return new Combination<T1,T2,T3,T4,T5,T6,T7>(enumerator1.Current, enumerator2.Current, enumerator3.Current, enumerator4.Current, enumerator5.Current, enumerator6.Current, enumerator7.Current);
				}
			}
		}

		public override string ToString() => string.Format("<{0}, {1}, {2}, {3}, {4}, {5}, {6}>", Value1, Value2, Value3, Value4, Value5, Value6, Value7);

	}
	
	public class Combination<T1,T2,T3,T4,T5,T6,T7,T8>  {
		public T1 Value1 { get; }
		public T2 Value2 { get; }
		public T3 Value3 { get; }
		public T4 Value4 { get; }
		public T5 Value5 { get; }
		public T6 Value6 { get; }
		public T7 Value7 { get; }
		public T8 Value8 { get; }

		public Combination(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) {
			Value1 = value1;
			Value2 = value2;
			Value3 = value3;
			Value4 = value4;
			Value5 = value5;
			Value6 = value6;
			Value7 = value7;
			Value8 = value8;
		}

		public bool Equals(Combination<T1,T2,T3,T4,T5,T6,T7,T8> obj) =>
			EqualityComparer<T1>.Default.Equals(Value1, obj.Value1) &&
			EqualityComparer<T2>.Default.Equals(Value2, obj.Value2) &&
			EqualityComparer<T3>.Default.Equals(Value3, obj.Value3) &&
			EqualityComparer<T4>.Default.Equals(Value4, obj.Value4) &&
			EqualityComparer<T5>.Default.Equals(Value5, obj.Value5) &&
			EqualityComparer<T6>.Default.Equals(Value6, obj.Value6) &&
			EqualityComparer<T7>.Default.Equals(Value7, obj.Value7) &&
			EqualityComparer<T8>.Default.Equals(Value8, obj.Value8);

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Combination<T1,T2,T3,T4,T5,T6,T7,T8>) obj);
		}

		public override int GetHashCode() {
			var hashCode = 0;
			hashCode = hashCode * 397 ^ EqualityComparer<T1>.Default.GetHashCode(Value1);
			hashCode = hashCode * 397 ^ EqualityComparer<T2>.Default.GetHashCode(Value2);
			hashCode = hashCode * 397 ^ EqualityComparer<T3>.Default.GetHashCode(Value3);
			hashCode = hashCode * 397 ^ EqualityComparer<T4>.Default.GetHashCode(Value4);
			hashCode = hashCode * 397 ^ EqualityComparer<T5>.Default.GetHashCode(Value5);
			hashCode = hashCode * 397 ^ EqualityComparer<T6>.Default.GetHashCode(Value6);
			hashCode = hashCode * 397 ^ EqualityComparer<T7>.Default.GetHashCode(Value7);
			hashCode = hashCode * 397 ^ EqualityComparer<T8>.Default.GetHashCode(Value8);
			return hashCode;
		}

		public Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9> Add<T9>(T9 value9) =>
			new Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9>(Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, value9);

		public static IEnumerable<Combination<T1,T2,T3,T4,T5,T6,T7,T8>> Zip(IEnumerable<T1> values1, IEnumerable<T2> values2, IEnumerable<T3> values3, IEnumerable<T4> values4, IEnumerable<T5> values5, IEnumerable<T6> values6, IEnumerable<T7> values7, IEnumerable<T8> values8) {
			using (var enumerator1 = values1.GetEnumerator())
			using (var enumerator2 = values2.GetEnumerator())
			using (var enumerator3 = values3.GetEnumerator())
			using (var enumerator4 = values4.GetEnumerator())
			using (var enumerator5 = values5.GetEnumerator())
			using (var enumerator6 = values6.GetEnumerator())
			using (var enumerator7 = values7.GetEnumerator())
			using (var enumerator8 = values8.GetEnumerator())
			{
				while (enumerator1.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext() && enumerator4.MoveNext() && enumerator5.MoveNext() && enumerator6.MoveNext() && enumerator7.MoveNext() && enumerator8.MoveNext()) {
					yield return new Combination<T1,T2,T3,T4,T5,T6,T7,T8>(enumerator1.Current, enumerator2.Current, enumerator3.Current, enumerator4.Current, enumerator5.Current, enumerator6.Current, enumerator7.Current, enumerator8.Current);
				}
			}
		}

		public override string ToString() => string.Format("<{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}>", Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8);

	}
	
	public class Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9>  {
		public T1 Value1 { get; }
		public T2 Value2 { get; }
		public T3 Value3 { get; }
		public T4 Value4 { get; }
		public T5 Value5 { get; }
		public T6 Value6 { get; }
		public T7 Value7 { get; }
		public T8 Value8 { get; }
		public T9 Value9 { get; }

		public Combination(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) {
			Value1 = value1;
			Value2 = value2;
			Value3 = value3;
			Value4 = value4;
			Value5 = value5;
			Value6 = value6;
			Value7 = value7;
			Value8 = value8;
			Value9 = value9;
		}

		public bool Equals(Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9> obj) =>
			EqualityComparer<T1>.Default.Equals(Value1, obj.Value1) &&
			EqualityComparer<T2>.Default.Equals(Value2, obj.Value2) &&
			EqualityComparer<T3>.Default.Equals(Value3, obj.Value3) &&
			EqualityComparer<T4>.Default.Equals(Value4, obj.Value4) &&
			EqualityComparer<T5>.Default.Equals(Value5, obj.Value5) &&
			EqualityComparer<T6>.Default.Equals(Value6, obj.Value6) &&
			EqualityComparer<T7>.Default.Equals(Value7, obj.Value7) &&
			EqualityComparer<T8>.Default.Equals(Value8, obj.Value8) &&
			EqualityComparer<T9>.Default.Equals(Value9, obj.Value9);

		public override bool Equals(object obj) {
			if (ReferenceEquals(obj, this)) return true;
			if (ReferenceEquals(obj, null)) return false;
			if (obj.GetType() != GetType()) return false;
			return Equals((Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9>) obj);
		}

		public override int GetHashCode() {
			var hashCode = 0;
			hashCode = hashCode * 397 ^ EqualityComparer<T1>.Default.GetHashCode(Value1);
			hashCode = hashCode * 397 ^ EqualityComparer<T2>.Default.GetHashCode(Value2);
			hashCode = hashCode * 397 ^ EqualityComparer<T3>.Default.GetHashCode(Value3);
			hashCode = hashCode * 397 ^ EqualityComparer<T4>.Default.GetHashCode(Value4);
			hashCode = hashCode * 397 ^ EqualityComparer<T5>.Default.GetHashCode(Value5);
			hashCode = hashCode * 397 ^ EqualityComparer<T6>.Default.GetHashCode(Value6);
			hashCode = hashCode * 397 ^ EqualityComparer<T7>.Default.GetHashCode(Value7);
			hashCode = hashCode * 397 ^ EqualityComparer<T8>.Default.GetHashCode(Value8);
			hashCode = hashCode * 397 ^ EqualityComparer<T9>.Default.GetHashCode(Value9);
			return hashCode;
		}


		public static IEnumerable<Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9>> Zip(IEnumerable<T1> values1, IEnumerable<T2> values2, IEnumerable<T3> values3, IEnumerable<T4> values4, IEnumerable<T5> values5, IEnumerable<T6> values6, IEnumerable<T7> values7, IEnumerable<T8> values8, IEnumerable<T9> values9) {
			using (var enumerator1 = values1.GetEnumerator())
			using (var enumerator2 = values2.GetEnumerator())
			using (var enumerator3 = values3.GetEnumerator())
			using (var enumerator4 = values4.GetEnumerator())
			using (var enumerator5 = values5.GetEnumerator())
			using (var enumerator6 = values6.GetEnumerator())
			using (var enumerator7 = values7.GetEnumerator())
			using (var enumerator8 = values8.GetEnumerator())
			using (var enumerator9 = values9.GetEnumerator())
			{
				while (enumerator1.MoveNext() && enumerator2.MoveNext() && enumerator3.MoveNext() && enumerator4.MoveNext() && enumerator5.MoveNext() && enumerator6.MoveNext() && enumerator7.MoveNext() && enumerator8.MoveNext() && enumerator9.MoveNext()) {
					yield return new Combination<T1,T2,T3,T4,T5,T6,T7,T8,T9>(enumerator1.Current, enumerator2.Current, enumerator3.Current, enumerator4.Current, enumerator5.Current, enumerator6.Current, enumerator7.Current, enumerator8.Current, enumerator9.Current);
				}
			}
		}

		public override string ToString() => string.Format("<{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}>", Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9);

	}
}
