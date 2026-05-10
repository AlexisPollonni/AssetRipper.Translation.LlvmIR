using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray4_Int64 : IEquatable<InlineArray4_Int64>, IEqualityOperators<InlineArray4_Int64, InlineArray4_Int64, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray4_Int64, long>, IInlineArray<InlineArray4_Int64, ulong>
{
	private long __element0;

	public static int Length => 4;

	public static bool operator ==(InlineArray4_Int64 x, InlineArray4_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray4_Int64, long>(x, y);
	}

	public static bool operator !=(InlineArray4_Int64 x, InlineArray4_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray4_Int64)
		{
			return Equals((InlineArray4_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4_Int64, long>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<long>)this).GetEnumerator();
	}
}
