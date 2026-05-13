using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(30)]
public partial struct InlineArray30_SByte : IEquatable<InlineArray30_SByte>, IEqualityOperators<InlineArray30_SByte, InlineArray30_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray30_SByte, sbyte>, IInlineArray<InlineArray30_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 30;

	public static bool operator ==(InlineArray30_SByte x, InlineArray30_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray30_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray30_SByte x, InlineArray30_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray30_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray30_SByte)
		{
			return Equals((InlineArray30_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray30_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
