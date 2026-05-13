using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(200)]
public partial struct InlineArray200_SByte : IEquatable<InlineArray200_SByte>, IEqualityOperators<InlineArray200_SByte, InlineArray200_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray200_SByte, sbyte>, IInlineArray<InlineArray200_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 200;

	public static bool operator ==(InlineArray200_SByte x, InlineArray200_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray200_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray200_SByte x, InlineArray200_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray200_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray200_SByte)
		{
			return Equals((InlineArray200_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray200_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
