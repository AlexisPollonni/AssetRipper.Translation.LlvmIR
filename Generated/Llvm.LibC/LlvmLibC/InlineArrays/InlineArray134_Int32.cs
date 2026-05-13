using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(134)]
public partial struct InlineArray134_Int32 : IEquatable<InlineArray134_Int32>, IEqualityOperators<InlineArray134_Int32, InlineArray134_Int32, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray134_Int32, int>, IInlineArray<InlineArray134_Int32, uint>
{
	private int __element0;

	public static int Length => 134;

	public static bool operator ==(InlineArray134_Int32 x, InlineArray134_Int32 y)
	{
		return InlineArrayHelper.Equals<InlineArray134_Int32, int>(x, y);
	}

	public static bool operator !=(InlineArray134_Int32 x, InlineArray134_Int32 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray134_Int32 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray134_Int32)
		{
			return Equals((InlineArray134_Int32)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray134_Int32, int>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<int>)this).GetEnumerator();
	}
}
