using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(25)]
public partial struct InlineArray25_SByte : IEquatable<InlineArray25_SByte>, IEqualityOperators<InlineArray25_SByte, InlineArray25_SByte, bool>, IEnumerable, IInlineArray<InlineArray25_SByte, sbyte>, IInlineArray<InlineArray25_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 25;

	public static bool operator ==(InlineArray25_SByte x, InlineArray25_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray25_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray25_SByte x, InlineArray25_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray25_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray25_SByte)
		{
			return Equals((InlineArray25_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray25_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
