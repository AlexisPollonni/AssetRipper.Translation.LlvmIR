using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(12)]
public partial struct InlineArray12_InlineArray2_Int16 : IEquatable<InlineArray12_InlineArray2_Int16>, IEqualityOperators<InlineArray12_InlineArray2_Int16, InlineArray12_InlineArray2_Int16, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray12_InlineArray2_Int16, InlineArray2_Int16>, IInlineArray<InlineArray12_InlineArray2_Int16, short>, IInlineArray<InlineArray12_InlineArray2_Int16, ushort>, IInlineArray<InlineArray12_InlineArray2_Int16, char>
{
	private InlineArray2_Int16 __element0;

	public static int Length => 12;

	static int IInlineArray<short>.Length => 24;

	static int IInlineArray<ushort>.Length => 24;

	static int IInlineArray<char>.Length => 24;

	public static bool operator ==(InlineArray12_InlineArray2_Int16 x, InlineArray12_InlineArray2_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray12_InlineArray2_Int16, InlineArray2_Int16>(x, y);
	}

	public static bool operator !=(InlineArray12_InlineArray2_Int16 x, InlineArray12_InlineArray2_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray12_InlineArray2_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray12_InlineArray2_Int16)
		{
			return Equals((InlineArray12_InlineArray2_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray12_InlineArray2_Int16, InlineArray2_Int16>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray2_Int16>)this).GetEnumerator();
	}
}
