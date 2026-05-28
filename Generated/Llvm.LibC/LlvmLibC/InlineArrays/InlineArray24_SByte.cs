using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(24)]
public partial struct InlineArray24_SByte : IEquatable<InlineArray24_SByte>, IEqualityOperators<InlineArray24_SByte, InlineArray24_SByte, bool>, IEnumerable, IInlineArray<InlineArray24_SByte, sbyte>, IInlineArray<InlineArray24_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 24;

	public static bool operator ==(InlineArray24_SByte x, InlineArray24_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray24_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray24_SByte x, InlineArray24_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray24_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray24_SByte)
		{
			return Equals((InlineArray24_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray24_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
