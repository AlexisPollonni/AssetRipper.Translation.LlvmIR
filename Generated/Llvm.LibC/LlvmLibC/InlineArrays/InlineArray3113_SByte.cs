using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(3113)]
public partial struct InlineArray3113_SByte : IEquatable<InlineArray3113_SByte>, IEqualityOperators<InlineArray3113_SByte, InlineArray3113_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray3113_SByte, sbyte>, IInlineArray<InlineArray3113_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 3113;

	public static bool operator ==(InlineArray3113_SByte x, InlineArray3113_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray3113_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray3113_SByte x, InlineArray3113_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3113_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray3113_SByte)
		{
			return Equals((InlineArray3113_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3113_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
