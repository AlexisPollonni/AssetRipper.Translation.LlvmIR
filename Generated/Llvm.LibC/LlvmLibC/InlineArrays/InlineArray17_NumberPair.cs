using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(17)]
public partial struct InlineArray17_NumberPair : IEquatable<InlineArray17_NumberPair>, IEqualityOperators<InlineArray17_NumberPair, InlineArray17_NumberPair, bool>, IEnumerable, IInlineArray<InlineArray17_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 17;

	public static bool operator ==(InlineArray17_NumberPair x, InlineArray17_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray17_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray17_NumberPair x, InlineArray17_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray17_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray17_NumberPair)
		{
			return Equals((InlineArray17_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray17_NumberPair, NumberPair>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
