using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(41)]
public partial struct InlineArray41_SByte : IEquatable<InlineArray41_SByte>, IEqualityOperators<InlineArray41_SByte, InlineArray41_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray41_SByte, sbyte>, IInlineArray<InlineArray41_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 41;

	public static bool operator ==(InlineArray41_SByte x, InlineArray41_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray41_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray41_SByte x, InlineArray41_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray41_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray41_SByte)
		{
			return Equals((InlineArray41_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray41_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
