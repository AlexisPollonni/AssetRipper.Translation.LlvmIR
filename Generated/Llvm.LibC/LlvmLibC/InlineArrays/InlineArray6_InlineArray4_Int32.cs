using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(6)]
public partial struct InlineArray6_InlineArray4_Int32 : IEquatable<InlineArray6_InlineArray4_Int32>, IEqualityOperators<InlineArray6_InlineArray4_Int32, InlineArray6_InlineArray4_Int32, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray6_InlineArray4_Int32, InlineArray4_Int32>, IInlineArray<InlineArray6_InlineArray4_Int32, int>, IInlineArray<InlineArray6_InlineArray4_Int32, uint>
{
	private InlineArray4_Int32 __element0;

	public static int Length => 6;

	static int IInlineArray<int>.Length => 24;

	static int IInlineArray<uint>.Length => 24;

	public static bool operator ==(InlineArray6_InlineArray4_Int32 x, InlineArray6_InlineArray4_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray6_InlineArray4_Int32, InlineArray4_Int32>(x, y);
	}

	public static bool operator !=(InlineArray6_InlineArray4_Int32 x, InlineArray6_InlineArray4_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray6_InlineArray4_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray6_InlineArray4_Int32)
		{
			return Equals((InlineArray6_InlineArray4_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray6_InlineArray4_Int32, InlineArray4_Int32>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray4_Int32>)this).GetEnumerator();
	}
}
