using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(1)]
public partial struct InlineArray1_Int64 : IEquatable<InlineArray1_Int64>, IEqualityOperators<InlineArray1_Int64, InlineArray1_Int64, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray1_Int64, long>, IInlineArray<InlineArray1_Int64, ulong>
{
	private long __element0;

	public static int Length => 1;

	public static bool operator ==(InlineArray1_Int64 x, InlineArray1_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray1_Int64, long>(x, y);
	}

	public static bool operator !=(InlineArray1_Int64 x, InlineArray1_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray1_Int64)
		{
			return Equals((InlineArray1_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1_Int64, long>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<long>)this).GetEnumerator();
	}
}
