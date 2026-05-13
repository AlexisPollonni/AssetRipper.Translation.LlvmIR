using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(1)]
public partial struct InlineArray1_Int16 : IEquatable<InlineArray1_Int16>, IEqualityOperators<InlineArray1_Int16, InlineArray1_Int16, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray1_Int16, short>, IInlineArray<InlineArray1_Int16, ushort>, IInlineArray<InlineArray1_Int16, char>
{
	private short __element0;

	public static int Length => 1;

	public static bool operator ==(InlineArray1_Int16 x, InlineArray1_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray1_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray1_Int16 x, InlineArray1_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray1_Int16)
		{
			return Equals((InlineArray1_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1_Int16, short>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
