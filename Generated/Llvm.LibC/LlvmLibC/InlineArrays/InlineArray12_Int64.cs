using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(12)]
public partial struct InlineArray12_Int64 : IEquatable<InlineArray12_Int64>, IEqualityOperators<InlineArray12_Int64, InlineArray12_Int64, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray12_Int64, long>, IInlineArray<InlineArray12_Int64, ulong>
{
	private long __element0;

	public static int Length => 12;

	public static bool operator ==(InlineArray12_Int64 x, InlineArray12_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray12_Int64, long>(x, y);
	}

	public static bool operator !=(InlineArray12_Int64 x, InlineArray12_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray12_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray12_Int64)
		{
			return Equals((InlineArray12_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray12_Int64, long>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<long>)this).GetEnumerator();
	}
}
