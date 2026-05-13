using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(9)]
public partial struct InlineArray9_NumberPair : IEquatable<InlineArray9_NumberPair>, IEqualityOperators<InlineArray9_NumberPair, InlineArray9_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray9_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 9;

	public static bool operator ==(InlineArray9_NumberPair x, InlineArray9_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray9_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray9_NumberPair x, InlineArray9_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray9_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray9_NumberPair)
		{
			return Equals((InlineArray9_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray9_NumberPair, NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
