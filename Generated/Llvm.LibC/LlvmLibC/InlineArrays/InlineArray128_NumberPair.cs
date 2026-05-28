using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_NumberPair : IEquatable<InlineArray128_NumberPair>, IEqualityOperators<InlineArray128_NumberPair, InlineArray128_NumberPair, bool>, IEnumerable, IInlineArray<InlineArray128_NumberPair, NumberPair>
{
	private NumberPair __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_NumberPair x, InlineArray128_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray128_NumberPair, NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray128_NumberPair x, InlineArray128_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray128_NumberPair)
		{
			return Equals((InlineArray128_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_NumberPair, NumberPair>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<NumberPair>)this).GetEnumerator();
	}
}
