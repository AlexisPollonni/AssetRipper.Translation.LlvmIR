using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(38)]
public partial struct InlineArray38_SByte : IEquatable<InlineArray38_SByte>, IEqualityOperators<InlineArray38_SByte, InlineArray38_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray38_SByte, sbyte>, IInlineArray<InlineArray38_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 38;

	public static bool operator ==(InlineArray38_SByte x, InlineArray38_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray38_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray38_SByte x, InlineArray38_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray38_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray38_SByte)
		{
			return Equals((InlineArray38_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray38_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
