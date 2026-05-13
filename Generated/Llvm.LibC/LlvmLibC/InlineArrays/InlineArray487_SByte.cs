using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(487)]
public partial struct InlineArray487_SByte : IEquatable<InlineArray487_SByte>, IEqualityOperators<InlineArray487_SByte, InlineArray487_SByte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray487_SByte, sbyte>, IInlineArray<InlineArray487_SByte, byte>
{
	private sbyte __element0;

	public static int Length => 487;

	public static bool operator ==(InlineArray487_SByte x, InlineArray487_SByte y)
	{
		return InlineArrayHelper.Equals<InlineArray487_SByte, sbyte>(x, y);
	}

	public static bool operator !=(InlineArray487_SByte x, InlineArray487_SByte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray487_SByte other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray487_SByte)
		{
			return Equals((InlineArray487_SByte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray487_SByte, sbyte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<sbyte>)this).GetEnumerator();
	}
}
