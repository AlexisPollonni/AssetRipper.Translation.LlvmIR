using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(4096)]
public partial struct InlineArray4096_SByte : IEquatable<InlineArray4096_SByte>, IEqualityOperators<InlineArray4096_SByte, InlineArray4096_SByte, bool>, IEnumerable, IInlineArray<InlineArray4096_SByte, sbyte>, IInlineArray<InlineArray4096_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 4096;

	public static bool operator ==(InlineArray4096_SByte x, InlineArray4096_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray4096_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray4096_SByte x, InlineArray4096_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4096_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray4096_SByte)
		{
			return Equals((InlineArray4096_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4096_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
