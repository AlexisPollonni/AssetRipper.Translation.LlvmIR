using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(69)]
public partial struct InlineArray69_Int16 : IEquatable<InlineArray69_Int16>, IEqualityOperators<InlineArray69_Int16, InlineArray69_Int16, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray69_Int16, short>, IInlineArray<InlineArray69_Int16, ushort>, IInlineArray<InlineArray69_Int16, char>
{
	private short __element0;

	public static int Length => 69;

	public static bool operator ==(InlineArray69_Int16 x, InlineArray69_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray69_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray69_Int16 x, InlineArray69_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray69_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray69_Int16)
		{
			return Equals((InlineArray69_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray69_Int16, short>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
