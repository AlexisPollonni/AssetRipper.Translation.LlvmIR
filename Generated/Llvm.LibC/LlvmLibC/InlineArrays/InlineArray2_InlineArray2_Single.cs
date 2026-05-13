using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_InlineArray2_Single : IEquatable<InlineArray2_InlineArray2_Single>, IEqualityOperators<InlineArray2_InlineArray2_Single, InlineArray2_InlineArray2_Single, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_InlineArray2_Single, InlineArray2_Single>, IInlineArray<InlineArray2_InlineArray2_Single, float>
{
	private InlineArray2_Single __element0;

	public static int Length => 2;

	static int IInlineArray<float>.Length => 4;

	public static bool operator ==(InlineArray2_InlineArray2_Single x, InlineArray2_InlineArray2_Single y)
	{
		return InlineArrayHelper.Equals<InlineArray2_InlineArray2_Single, InlineArray2_Single>(x, y);
	}

	public static bool operator !=(InlineArray2_InlineArray2_Single x, InlineArray2_InlineArray2_Single y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_InlineArray2_Single other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_InlineArray2_Single)
		{
			return Equals((InlineArray2_InlineArray2_Single)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_InlineArray2_Single, InlineArray2_Single>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray2_Single>)this).GetEnumerator();
	}
}
