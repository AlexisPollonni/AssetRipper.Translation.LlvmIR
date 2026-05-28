using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(36)]
public partial struct InlineArray36_SByte : IEquatable<InlineArray36_SByte>, IEqualityOperators<InlineArray36_SByte, InlineArray36_SByte, bool>, IEnumerable, IInlineArray<InlineArray36_SByte, sbyte>, IInlineArray<InlineArray36_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 36;

	public static bool operator ==(InlineArray36_SByte x, InlineArray36_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray36_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray36_SByte x, InlineArray36_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray36_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray36_SByte)
		{
			return Equals((InlineArray36_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray36_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
