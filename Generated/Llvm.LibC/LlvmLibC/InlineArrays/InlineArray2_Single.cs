using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_Single : IEquatable<InlineArray2_Single>, IEqualityOperators<InlineArray2_Single, InlineArray2_Single, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_Single, float>
{
	private float __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_Single x, InlineArray2_Single y)
	{
		return InlineArrayHelper.Equals<InlineArray2_Single, float>(x, y);
	}

	public static bool operator !=(InlineArray2_Single x, InlineArray2_Single y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_Single other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray2_Single)
		{
			return Equals((InlineArray2_Single)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_Single, float>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<float>)this).GetEnumerator();
	}
}
