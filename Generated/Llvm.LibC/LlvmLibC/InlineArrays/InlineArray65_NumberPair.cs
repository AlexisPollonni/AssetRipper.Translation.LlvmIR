using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(65)]
public partial struct InlineArray65_NumberPair : IEquatable<InlineArray65_NumberPair>, IEqualityOperators<InlineArray65_NumberPair, InlineArray65_NumberPair, bool>, IEnumerable, IInlineArray<InlineArray65_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 65;

	public static bool operator ==(InlineArray65_NumberPair x, InlineArray65_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray65_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray65_NumberPair x, InlineArray65_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray65_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray65_NumberPair)
		{
			return Equals((InlineArray65_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray65_NumberPair, NumberPair>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
