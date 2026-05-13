using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_NumberPair : IEquatable<InlineArray2_NumberPair>, IEqualityOperators<InlineArray2_NumberPair, InlineArray2_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_NumberPair x, InlineArray2_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray2_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray2_NumberPair x, InlineArray2_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_NumberPair)
		{
			return Equals((InlineArray2_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_NumberPair, NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
