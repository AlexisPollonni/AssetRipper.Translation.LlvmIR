using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(6)]
public partial struct InlineArray6_Int32 : IEquatable<InlineArray6_Int32>, IEqualityOperators<InlineArray6_Int32, InlineArray6_Int32, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray6_Int32, int>, IInlineArray<InlineArray6_Int32, uint>
{
	private int __element0;

	public static int Length => 6;

	public static bool operator ==(InlineArray6_Int32 x, InlineArray6_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray6_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray6_Int32 x, InlineArray6_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray6_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray6_Int32)
		{
			return Equals((InlineArray6_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray6_Int32, int>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
