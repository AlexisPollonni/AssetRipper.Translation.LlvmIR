using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(3133)]
public partial struct InlineArray3133_InlineArray3_Int64 : IEquatable<InlineArray3133_InlineArray3_Int64>, IEqualityOperators<InlineArray3133_InlineArray3_Int64, InlineArray3133_InlineArray3_Int64, bool>, IEnumerable, IInlineArray<InlineArray3133_InlineArray3_Int64, InlineArray3_Int64>, IInlineArray<InlineArray3133_InlineArray3_Int64, long>, IInlineArray<InlineArray3133_InlineArray3_Int64, ulong>
{
	private InlineArray3_Int64 __element0;

	public static int Length => 3133;

	static int IInlineArray<long>.Length => 9399;

	static int IInlineArray<ulong>.Length => 9399;

	public static bool operator ==(InlineArray3133_InlineArray3_Int64 x, InlineArray3133_InlineArray3_Int64 y)
	{
		return InlineArrayHelper.Equals<InlineArray3133_InlineArray3_Int64, InlineArray3_Int64>(x, y);
	}

	public static bool operator !=(InlineArray3133_InlineArray3_Int64 x, InlineArray3133_InlineArray3_Int64 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3133_InlineArray3_Int64 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray3133_InlineArray3_Int64)
		{
			return Equals((InlineArray3133_InlineArray3_Int64)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3133_InlineArray3_Int64, InlineArray3_Int64>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray3_Int64>)this).GetEnumerator();
	}
}
