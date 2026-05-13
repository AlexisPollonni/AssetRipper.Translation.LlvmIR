using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(6)]
public partial struct InlineArray6_NumberPair : IEquatable<InlineArray6_NumberPair>, IEqualityOperators<InlineArray6_NumberPair, InlineArray6_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray6_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 6;

	public static bool operator ==(InlineArray6_NumberPair x, InlineArray6_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray6_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray6_NumberPair x, InlineArray6_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray6_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray6_NumberPair)
		{
			return Equals((InlineArray6_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray6_NumberPair, NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
