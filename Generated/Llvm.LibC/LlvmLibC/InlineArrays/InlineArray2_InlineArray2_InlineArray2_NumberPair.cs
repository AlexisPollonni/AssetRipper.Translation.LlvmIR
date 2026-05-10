using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_InlineArray2_InlineArray2_NumberPair : IEquatable<InlineArray2_InlineArray2_InlineArray2_NumberPair>, IEqualityOperators<InlineArray2_InlineArray2_InlineArray2_NumberPair, InlineArray2_InlineArray2_InlineArray2_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_InlineArray2_InlineArray2_NumberPair, InlineArray2_InlineArray2_NumberPair>, IInlineArray<InlineArray2_InlineArray2_InlineArray2_NumberPair, NumberPair>
{
	private InlineArray2_InlineArray2_NumberPair __element0;

	public static int Length => 2;

	static int IInlineArray<NumberPair>.Length => 8;

	public static bool operator ==(InlineArray2_InlineArray2_InlineArray2_NumberPair x, InlineArray2_InlineArray2_InlineArray2_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray2_InlineArray2_InlineArray2_NumberPair, InlineArray2_InlineArray2_NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray2_InlineArray2_InlineArray2_NumberPair x, InlineArray2_InlineArray2_InlineArray2_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_InlineArray2_InlineArray2_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_InlineArray2_InlineArray2_NumberPair)
		{
			return Equals((InlineArray2_InlineArray2_InlineArray2_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_InlineArray2_InlineArray2_NumberPair, InlineArray2_InlineArray2_NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray2_InlineArray2_NumberPair>)this).GetEnumerator();
	}
}
