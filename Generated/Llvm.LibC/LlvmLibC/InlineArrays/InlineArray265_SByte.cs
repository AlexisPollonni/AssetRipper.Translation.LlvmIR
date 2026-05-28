using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(265)]
public partial struct InlineArray265_SByte : IEquatable<InlineArray265_SByte>, IEqualityOperators<InlineArray265_SByte, InlineArray265_SByte, bool>, IEnumerable, IInlineArray<InlineArray265_SByte, sbyte>, IInlineArray<InlineArray265_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 265;

	public static bool operator ==(InlineArray265_SByte x, InlineArray265_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray265_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray265_SByte x, InlineArray265_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray265_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray265_SByte)
		{
			return Equals((InlineArray265_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray265_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
