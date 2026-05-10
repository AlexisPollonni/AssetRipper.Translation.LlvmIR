using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(129)]
public partial struct InlineArray129_NumberPair : IEquatable<InlineArray129_NumberPair>, IEqualityOperators<InlineArray129_NumberPair, InlineArray129_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray129_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 129;

	public static bool operator ==(InlineArray129_NumberPair x, InlineArray129_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray129_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray129_NumberPair x, InlineArray129_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray129_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray129_NumberPair)
		{
			return Equals((InlineArray129_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray129_NumberPair, NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
