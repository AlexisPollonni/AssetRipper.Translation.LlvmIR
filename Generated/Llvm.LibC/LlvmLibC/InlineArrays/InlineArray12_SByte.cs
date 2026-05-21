using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(12)]
public partial struct InlineArray12_SByte : IEquatable<InlineArray12_SByte>, IEqualityOperators<InlineArray12_SByte, InlineArray12_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray12_SByte, sbyte>, IInlineArray<InlineArray12_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 12;

	public static bool operator ==(InlineArray12_SByte x, InlineArray12_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray12_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray12_SByte x, InlineArray12_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray12_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray12_SByte)
		{
			return Equals((InlineArray12_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray12_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
