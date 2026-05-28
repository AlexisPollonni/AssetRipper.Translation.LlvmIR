using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_Int64 : IEquatable<InlineArray3_Int64>, IEqualityOperators<InlineArray3_Int64, InlineArray3_Int64, bool>, IEnumerable, IInlineArray<InlineArray3_Int64, long>, IInlineArray<InlineArray3_Int64, ulong>
{
	private long __element0;

	public static int Length => 3;

	public static bool operator ==(InlineArray3_Int64 x, InlineArray3_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray3_Int64, long>(x, y);
	}

	public static bool operator !=(InlineArray3_Int64 x, InlineArray3_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray3_Int64)
		{
			return Equals((InlineArray3_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_Int64, long>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<long>)this).GetEnumerator();
	}
}
