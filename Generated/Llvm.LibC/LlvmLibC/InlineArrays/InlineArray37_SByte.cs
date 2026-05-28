using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(37)]
public partial struct InlineArray37_SByte : IEquatable<InlineArray37_SByte>, IEqualityOperators<InlineArray37_SByte, InlineArray37_SByte, bool>, IEnumerable, IInlineArray<InlineArray37_SByte, sbyte>, IInlineArray<InlineArray37_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 37;

	public static bool operator ==(InlineArray37_SByte x, InlineArray37_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray37_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray37_SByte x, InlineArray37_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray37_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray37_SByte)
		{
			return Equals((InlineArray37_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray37_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
