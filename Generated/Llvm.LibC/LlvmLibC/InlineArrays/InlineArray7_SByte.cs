using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(7)]
public partial struct InlineArray7_SByte : IEquatable<InlineArray7_SByte>, IEqualityOperators<InlineArray7_SByte, InlineArray7_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray7_SByte, sbyte>, IInlineArray<InlineArray7_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 7;

	public static bool operator ==(InlineArray7_SByte x, InlineArray7_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray7_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray7_SByte x, InlineArray7_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray7_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray7_SByte)
		{
			return Equals((InlineArray7_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray7_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
