using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(800)]
public partial struct InlineArray800_SByte : IEquatable<InlineArray800_SByte>, IEqualityOperators<InlineArray800_SByte, InlineArray800_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray800_SByte, sbyte>, IInlineArray<InlineArray800_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 800;

	public static bool operator ==(InlineArray800_SByte x, InlineArray800_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray800_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray800_SByte x, InlineArray800_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray800_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray800_SByte)
		{
			return Equals((InlineArray800_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray800_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
