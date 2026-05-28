using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray8_Int64 : IEquatable<InlineArray8_Int64>, IEqualityOperators<InlineArray8_Int64, InlineArray8_Int64, bool>, IEnumerable, IInlineArray<InlineArray8_Int64, long>, IInlineArray<InlineArray8_Int64, ulong>
{
	private long __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray8_Int64 x, InlineArray8_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray8_Int64, long>(x, y);
	}

	public static bool operator !=(InlineArray8_Int64 x, InlineArray8_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray8_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray8_Int64)
		{
			return Equals((InlineArray8_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray8_Int64, long>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<long>)this).GetEnumerator();
	}
}
