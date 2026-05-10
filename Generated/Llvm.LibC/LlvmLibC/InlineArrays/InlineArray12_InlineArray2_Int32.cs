using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(12)]
public partial struct InlineArray12_InlineArray2_Int32 : IEquatable<InlineArray12_InlineArray2_Int32>, IEqualityOperators<InlineArray12_InlineArray2_Int32, InlineArray12_InlineArray2_Int32, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray12_InlineArray2_Int32, InlineArray2_Int32>, IInlineArray<InlineArray12_InlineArray2_Int32, int>, IInlineArray<InlineArray12_InlineArray2_Int32, uint>
{
	private InlineArray2_Int32 __element0;

	public static int Length => 12;

	static int IInlineArray<int>.Length => 24;

	static int IInlineArray<uint>.Length => 24;

	public static bool operator ==(InlineArray12_InlineArray2_Int32 x, InlineArray12_InlineArray2_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray12_InlineArray2_Int32, InlineArray2_Int32>(x, y);
	}

	public static bool operator !=(InlineArray12_InlineArray2_Int32 x, InlineArray12_InlineArray2_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray12_InlineArray2_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray12_InlineArray2_Int32)
		{
			return Equals((InlineArray12_InlineArray2_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray12_InlineArray2_Int32, InlineArray2_Int32>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray2_Int32>)this).GetEnumerator();
	}
}
