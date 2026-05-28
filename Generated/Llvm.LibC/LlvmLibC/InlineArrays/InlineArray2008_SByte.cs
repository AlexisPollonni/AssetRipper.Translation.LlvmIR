using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(2008)]
public partial struct InlineArray2008_SByte : IEquatable<InlineArray2008_SByte>, IEqualityOperators<InlineArray2008_SByte, InlineArray2008_SByte, bool>, IEnumerable, IInlineArray<InlineArray2008_SByte, sbyte>, IInlineArray<InlineArray2008_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 2008;

	public static bool operator ==(InlineArray2008_SByte x, InlineArray2008_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray2008_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray2008_SByte x, InlineArray2008_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2008_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray2008_SByte)
		{
			return Equals((InlineArray2008_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2008_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
