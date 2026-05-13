using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(15)]
public partial struct InlineArray15_SByte : IEquatable<InlineArray15_SByte>, IEqualityOperators<InlineArray15_SByte, InlineArray15_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray15_SByte, sbyte>, IInlineArray<InlineArray15_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 15;

	public static bool operator ==(InlineArray15_SByte x, InlineArray15_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray15_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray15_SByte x, InlineArray15_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray15_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray15_SByte)
		{
			return Equals((InlineArray15_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray15_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
