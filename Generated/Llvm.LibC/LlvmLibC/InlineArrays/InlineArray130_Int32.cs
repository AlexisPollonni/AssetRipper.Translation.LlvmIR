using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(130)]
public partial struct InlineArray130_Int32 : IEquatable<InlineArray130_Int32>, IEqualityOperators<InlineArray130_Int32, InlineArray130_Int32, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray130_Int32, int>, IInlineArray<InlineArray130_Int32, uint>
{
	private int __element0;

	public static int Length => 130;

	public static bool operator ==(InlineArray130_Int32 x, InlineArray130_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray130_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray130_Int32 x, InlineArray130_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray130_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray130_Int32)
		{
			return Equals((InlineArray130_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray130_Int32, int>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
