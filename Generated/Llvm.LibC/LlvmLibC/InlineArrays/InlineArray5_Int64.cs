using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(5)]
public partial struct InlineArray5_Int64 : IEquatable<InlineArray5_Int64>, IEqualityOperators<InlineArray5_Int64, InlineArray5_Int64, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray5_Int64, long>, IInlineArray<InlineArray5_Int64, ulong>
{
	private long __element0;

	public static int Length => 5;

	public static bool operator ==(InlineArray5_Int64 x, InlineArray5_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray5_Int64, long>(x, y);
	}

	public static bool operator !=(InlineArray5_Int64 x, InlineArray5_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray5_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray5_Int64)
		{
			return Equals((InlineArray5_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray5_Int64, long>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<long>)this).GetEnumerator();
	}
}
