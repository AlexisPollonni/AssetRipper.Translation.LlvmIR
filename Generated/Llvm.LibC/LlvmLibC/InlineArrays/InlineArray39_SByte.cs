using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(39)]
public partial struct InlineArray39_SByte : IEquatable<InlineArray39_SByte>, IEqualityOperators<InlineArray39_SByte, InlineArray39_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray39_SByte, sbyte>, IInlineArray<InlineArray39_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 39;

	public static bool operator ==(InlineArray39_SByte x, InlineArray39_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray39_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray39_SByte x, InlineArray39_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray39_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray39_SByte)
		{
			return Equals((InlineArray39_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray39_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
