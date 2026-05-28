using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(32)]
public partial struct InlineArray32_SByte : IEquatable<InlineArray32_SByte>, IEqualityOperators<InlineArray32_SByte, InlineArray32_SByte, bool>, IEnumerable, IInlineArray<InlineArray32_SByte, sbyte>, IInlineArray<InlineArray32_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 32;

	public static bool operator ==(InlineArray32_SByte x, InlineArray32_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray32_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray32_SByte x, InlineArray32_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray32_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray32_SByte)
		{
			return Equals((InlineArray32_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray32_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
