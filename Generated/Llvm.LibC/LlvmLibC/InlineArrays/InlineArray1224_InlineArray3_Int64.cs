using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(1224)]
public partial struct InlineArray1224_InlineArray3_Int64 : IEquatable<InlineArray1224_InlineArray3_Int64>, IEqualityOperators<InlineArray1224_InlineArray3_Int64, InlineArray1224_InlineArray3_Int64, bool>, IEnumerable, IInlineArray<InlineArray1224_InlineArray3_Int64, InlineArray3_Int64>, IInlineArray<InlineArray1224_InlineArray3_Int64, long>, IInlineArray<InlineArray1224_InlineArray3_Int64, ulong>
{
	private InlineArray3_Int64 __element0;

	public static int Length => 1224;

	static int IInlineArray<long>.Length => 3672;

	static int IInlineArray<ulong>.Length => 3672;

	public static bool operator ==(InlineArray1224_InlineArray3_Int64 x, InlineArray1224_InlineArray3_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray1224_InlineArray3_Int64, InlineArray3_Int64>(x, y);
	}

	public static bool operator !=(InlineArray1224_InlineArray3_Int64 x, InlineArray1224_InlineArray3_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1224_InlineArray3_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray1224_InlineArray3_Int64)
		{
			return Equals((InlineArray1224_InlineArray3_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1224_InlineArray3_Int64, InlineArray3_Int64>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray3_Int64>)this).GetEnumerator();
	}
}
