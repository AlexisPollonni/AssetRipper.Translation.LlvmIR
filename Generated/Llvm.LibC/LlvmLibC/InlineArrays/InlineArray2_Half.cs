using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_Half : IEquatable<InlineArray2_Half>, IEqualityOperators<InlineArray2_Half, InlineArray2_Half, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_Half, Half>
{
	private Half __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_Half x, InlineArray2_Half y)
	{
		return InlineArrayHelper.Equals<InlineArray2_Half, Half>(x, y);
	}

	public static bool operator !=(InlineArray2_Half x, InlineArray2_Half y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_Half other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_Half)
		{
			return Equals((InlineArray2_Half)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_Half, Half>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Half>)this).GetEnumerator();
	}
}
