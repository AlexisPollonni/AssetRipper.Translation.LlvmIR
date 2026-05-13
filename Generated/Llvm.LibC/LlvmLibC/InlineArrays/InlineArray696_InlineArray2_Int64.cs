using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(696)]
public partial struct InlineArray696_InlineArray2_Int64 : IEquatable<InlineArray696_InlineArray2_Int64>, IEqualityOperators<InlineArray696_InlineArray2_Int64, InlineArray696_InlineArray2_Int64, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray696_InlineArray2_Int64, InlineArray2_Int64>, IInlineArray<InlineArray696_InlineArray2_Int64, long>, IInlineArray<InlineArray696_InlineArray2_Int64, ulong>
{
	private InlineArray2_Int64 __element0;

	public static int Length => 696;

	static int IInlineArray<long>.Length => 1392;

	static int IInlineArray<ulong>.Length => 1392;

	public static bool operator ==(InlineArray696_InlineArray2_Int64 x, InlineArray696_InlineArray2_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray696_InlineArray2_Int64, InlineArray2_Int64>(x, y);
	}

	public static bool operator !=(InlineArray696_InlineArray2_Int64 x, InlineArray696_InlineArray2_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray696_InlineArray2_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray696_InlineArray2_Int64)
		{
			return Equals((InlineArray696_InlineArray2_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray696_InlineArray2_Int64, InlineArray2_Int64>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray2_Int64>)this).GetEnumerator();
	}
}
