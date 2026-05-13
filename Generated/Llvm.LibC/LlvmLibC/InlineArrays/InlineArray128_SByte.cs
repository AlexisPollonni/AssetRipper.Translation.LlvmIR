using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_SByte : IEquatable<InlineArray128_SByte>, IEqualityOperators<InlineArray128_SByte, InlineArray128_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray128_SByte, sbyte>, IInlineArray<InlineArray128_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_SByte x, InlineArray128_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray128_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray128_SByte x, InlineArray128_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray128_SByte)
		{
			return Equals((InlineArray128_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
