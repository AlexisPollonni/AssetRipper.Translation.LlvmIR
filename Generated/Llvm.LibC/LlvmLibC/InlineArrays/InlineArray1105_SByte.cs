using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(1105)]
public partial struct InlineArray1105_SByte : IEquatable<InlineArray1105_SByte>, IEqualityOperators<InlineArray1105_SByte, InlineArray1105_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray1105_SByte, sbyte>, IInlineArray<InlineArray1105_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 1105;

	public static bool operator ==(InlineArray1105_SByte x, InlineArray1105_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray1105_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray1105_SByte x, InlineArray1105_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1105_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray1105_SByte)
		{
			return Equals((InlineArray1105_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1105_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
