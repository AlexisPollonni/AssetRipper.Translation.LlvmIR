using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(256)]
public partial struct InlineArray256_NumberPair : IEquatable<InlineArray256_NumberPair>, IEqualityOperators<InlineArray256_NumberPair, InlineArray256_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray256_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 256;

	public static bool operator ==(InlineArray256_NumberPair x, InlineArray256_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray256_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray256_NumberPair x, InlineArray256_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray256_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray256_NumberPair)
		{
			return Equals((InlineArray256_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray256_NumberPair, NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
