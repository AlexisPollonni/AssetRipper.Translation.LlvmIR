using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(1)]
public partial struct InlineArray1_Int32 : IEquatable<InlineArray1_Int32>, IEqualityOperators<InlineArray1_Int32, InlineArray1_Int32, bool>, IEnumerable, IInlineArray<InlineArray1_Int32, int>, IInlineArray<InlineArray1_Int32, uint>
{
	private int __element0;

	public static int Length => 1;

	public static bool operator ==(InlineArray1_Int32 x, InlineArray1_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray1_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray1_Int32 x, InlineArray1_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray1_Int32)
		{
			return Equals((InlineArray1_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1_Int32, int>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
