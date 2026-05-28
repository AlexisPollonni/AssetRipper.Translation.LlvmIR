using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray4_InlineArray16_SByte : IEquatable<InlineArray4_InlineArray16_SByte>, IEqualityOperators<InlineArray4_InlineArray16_SByte, InlineArray4_InlineArray16_SByte, bool>, IEnumerable, IInlineArray<InlineArray4_InlineArray16_SByte, InlineArray16_SByte>, IInlineArray<InlineArray4_InlineArray16_SByte, sbyte>, IInlineArray<InlineArray4_InlineArray16_SByte, byte>
{
	private InlineArray16_SByte __element0;

	public static int Length => 4;

	static int IInlineArray<sbyte>.Length => 64;

	static int IInlineArray<byte>.Length => 64;

	public static bool operator ==(InlineArray4_InlineArray16_SByte x, InlineArray4_InlineArray16_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray4_InlineArray16_SByte, InlineArray16_SByte>(x, y);
	}

	public static bool operator !=(InlineArray4_InlineArray16_SByte x, InlineArray4_InlineArray16_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4_InlineArray16_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray4_InlineArray16_SByte)
		{
			return Equals((InlineArray4_InlineArray16_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4_InlineArray16_SByte, InlineArray16_SByte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray16_SByte>)this).GetEnumerator();
	}
}
