using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(21)]
public partial struct InlineArray21_SByte : IEquatable<InlineArray21_SByte>, IEqualityOperators<InlineArray21_SByte, InlineArray21_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray21_SByte, sbyte>, IInlineArray<InlineArray21_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 21;

	public static bool operator ==(InlineArray21_SByte x, InlineArray21_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray21_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray21_SByte x, InlineArray21_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray21_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray21_SByte)
		{
			return Equals((InlineArray21_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray21_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
