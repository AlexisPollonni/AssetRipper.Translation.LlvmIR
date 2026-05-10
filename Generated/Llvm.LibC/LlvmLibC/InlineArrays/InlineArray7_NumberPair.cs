using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(7)]
public partial struct InlineArray7_NumberPair : IEquatable<InlineArray7_NumberPair>, IEqualityOperators<InlineArray7_NumberPair, InlineArray7_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray7_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 7;

	public static bool operator ==(InlineArray7_NumberPair x, InlineArray7_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray7_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray7_NumberPair x, InlineArray7_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray7_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray7_NumberPair)
		{
			return Equals((InlineArray7_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray7_NumberPair, NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
