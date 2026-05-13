using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(193)]
public partial struct InlineArray193_NumberPair : IEquatable<InlineArray193_NumberPair>, IEqualityOperators<InlineArray193_NumberPair, InlineArray193_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray193_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 193;

	public static bool operator ==(InlineArray193_NumberPair x, InlineArray193_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray193_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray193_NumberPair x, InlineArray193_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray193_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray193_NumberPair)
		{
			return Equals((InlineArray193_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray193_NumberPair, NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
