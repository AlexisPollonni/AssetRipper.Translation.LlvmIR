using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(9)]
public partial struct InlineArray9_SByte : IEquatable<InlineArray9_SByte>, IEqualityOperators<InlineArray9_SByte, InlineArray9_SByte, bool>, IEnumerable, IInlineArray<InlineArray9_SByte, sbyte>, IInlineArray<InlineArray9_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 9;

	public static bool operator ==(InlineArray9_SByte x, InlineArray9_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray9_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray9_SByte x, InlineArray9_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray9_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray9_SByte)
		{
			return Equals((InlineArray9_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray9_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
