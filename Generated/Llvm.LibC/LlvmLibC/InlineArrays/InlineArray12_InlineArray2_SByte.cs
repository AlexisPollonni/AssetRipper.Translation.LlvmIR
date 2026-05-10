using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(12)]
public partial struct InlineArray12_InlineArray2_SByte : IEquatable<InlineArray12_InlineArray2_SByte>, IEqualityOperators<InlineArray12_InlineArray2_SByte, InlineArray12_InlineArray2_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray12_InlineArray2_SByte, InlineArray2_SByte>, IInlineArray<InlineArray12_InlineArray2_SByte, sbyte>, IInlineArray<InlineArray12_InlineArray2_SByte, byte>
{
	private InlineArray2_SByte __element0;

	public static int Length => 12;

	static int IInlineArray<sbyte>.Length => 24;

	static int IInlineArray<byte>.Length => 24;

	public static bool operator ==(InlineArray12_InlineArray2_SByte x, InlineArray12_InlineArray2_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray12_InlineArray2_SByte, InlineArray2_SByte>(x, y);
	}

	public static bool operator !=(InlineArray12_InlineArray2_SByte x, InlineArray12_InlineArray2_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray12_InlineArray2_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray12_InlineArray2_SByte)
		{
			return Equals((InlineArray12_InlineArray2_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray12_InlineArray2_SByte, InlineArray2_SByte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray2_SByte>)this).GetEnumerator();
	}
}
