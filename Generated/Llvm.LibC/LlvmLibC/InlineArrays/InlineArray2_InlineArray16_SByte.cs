using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_InlineArray16_SByte : IEquatable<InlineArray2_InlineArray16_SByte>, IEqualityOperators<InlineArray2_InlineArray16_SByte, InlineArray2_InlineArray16_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_InlineArray16_SByte, InlineArray16_SByte>, IInlineArray<InlineArray2_InlineArray16_SByte, sbyte>, IInlineArray<InlineArray2_InlineArray16_SByte, byte>
{
	private InlineArray16_SByte __element0;

	public static int Length => 2;

	static int IInlineArray<sbyte>.Length => 32;

	static int IInlineArray<byte>.Length => 32;

	public static bool operator ==(InlineArray2_InlineArray16_SByte x, InlineArray2_InlineArray16_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray2_InlineArray16_SByte, InlineArray16_SByte>(x, y);
	}

	public static bool operator !=(InlineArray2_InlineArray16_SByte x, InlineArray2_InlineArray16_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_InlineArray16_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_InlineArray16_SByte)
		{
			return Equals((InlineArray2_InlineArray16_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_InlineArray16_SByte, InlineArray16_SByte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray16_SByte>)this).GetEnumerator();
	}
}
