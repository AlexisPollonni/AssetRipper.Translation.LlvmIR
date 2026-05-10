using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(32)]
public partial struct InlineArray32_Int64 : IEquatable<InlineArray32_Int64>, IEqualityOperators<InlineArray32_Int64, InlineArray32_Int64, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray32_Int64, long>, IInlineArray<InlineArray32_Int64, ulong>
{
	private long __element0;

	public static int Length => 32;

	public static bool operator ==(InlineArray32_Int64 x, InlineArray32_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray32_Int64, long>(x, y);
	}

	public static bool operator !=(InlineArray32_Int64 x, InlineArray32_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray32_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray32_Int64)
		{
			return Equals((InlineArray32_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray32_Int64, long>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<long>)this).GetEnumerator();
	}
}
