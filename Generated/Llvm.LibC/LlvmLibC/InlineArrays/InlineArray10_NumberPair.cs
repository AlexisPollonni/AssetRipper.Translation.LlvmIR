using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(10)]
public partial struct InlineArray10_NumberPair : IEquatable<InlineArray10_NumberPair>, IEqualityOperators<InlineArray10_NumberPair, InlineArray10_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray10_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 10;

	public static bool operator ==(InlineArray10_NumberPair x, InlineArray10_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray10_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray10_NumberPair x, InlineArray10_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray10_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray10_NumberPair)
		{
			return Equals((InlineArray10_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray10_NumberPair, NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
