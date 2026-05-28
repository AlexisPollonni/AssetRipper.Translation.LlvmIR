using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(1024)]
public partial struct InlineArray1024_SByte : IEquatable<InlineArray1024_SByte>, IEqualityOperators<InlineArray1024_SByte, InlineArray1024_SByte, bool>, IEnumerable, IInlineArray<InlineArray1024_SByte, sbyte>, IInlineArray<InlineArray1024_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 1024;

	public static bool operator ==(InlineArray1024_SByte x, InlineArray1024_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray1024_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray1024_SByte x, InlineArray1024_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1024_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray1024_SByte)
		{
			return Equals((InlineArray1024_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1024_SByte, sbyte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
