using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(24)]
public partial struct InlineArray24_Int32 : IEquatable<InlineArray24_Int32>, IEqualityOperators<InlineArray24_Int32, InlineArray24_Int32, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray24_Int32, int>, IInlineArray<InlineArray24_Int32, uint>
{
	private int __element0;

	public static int Length => 24;

	public static bool operator ==(InlineArray24_Int32 x, InlineArray24_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray24_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray24_Int32 x, InlineArray24_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray24_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray24_Int32)
		{
			return Equals((InlineArray24_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray24_Int32, int>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
