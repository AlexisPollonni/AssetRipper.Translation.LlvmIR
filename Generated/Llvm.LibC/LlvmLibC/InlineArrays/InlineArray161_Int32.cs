using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(161)]
public partial struct InlineArray161_Int32 : IEquatable<InlineArray161_Int32>, IEqualityOperators<InlineArray161_Int32, InlineArray161_Int32, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray161_Int32, int>, IInlineArray<InlineArray161_Int32, uint>
{
	private int __element0;

	public static int Length => 161;

	public static bool operator ==(InlineArray161_Int32 x, InlineArray161_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray161_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray161_Int32 x, InlineArray161_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray161_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray161_Int32)
		{
			return Equals((InlineArray161_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray161_Int32, int>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
