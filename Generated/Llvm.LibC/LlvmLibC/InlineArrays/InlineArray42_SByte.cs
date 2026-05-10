using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(42)]
public partial struct InlineArray42_SByte : IEquatable<InlineArray42_SByte>, IEqualityOperators<InlineArray42_SByte, InlineArray42_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray42_SByte, sbyte>, IInlineArray<InlineArray42_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 42;

	public static bool operator ==(InlineArray42_SByte x, InlineArray42_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray42_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray42_SByte x, InlineArray42_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray42_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray42_SByte)
		{
			return Equals((InlineArray42_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray42_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
