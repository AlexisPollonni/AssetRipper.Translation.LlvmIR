using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(40)]
public partial struct InlineArray40_SByte : IEquatable<InlineArray40_SByte>, IEqualityOperators<InlineArray40_SByte, InlineArray40_SByte, bool>, IEnumerable, IInlineArray<InlineArray40_SByte, sbyte>, IInlineArray<InlineArray40_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 40;

	public static bool operator ==(InlineArray40_SByte x, InlineArray40_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray40_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray40_SByte x, InlineArray40_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray40_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray40_SByte)
		{
			return Equals((InlineArray40_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray40_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
