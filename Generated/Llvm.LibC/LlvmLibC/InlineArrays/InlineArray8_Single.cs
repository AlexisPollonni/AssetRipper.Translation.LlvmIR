using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray8_Single : IEquatable<InlineArray8_Single>, IEqualityOperators<InlineArray8_Single, InlineArray8_Single, bool>, IEnumerable, IInlineArray<InlineArray8_Single, float>
{
	private float __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray8_Single x, InlineArray8_Single y)
	{
		return InlineArrayHelper.Equals<InlineArray8_Single, float>(x, y);
	}

	public static bool operator !=(InlineArray8_Single x, InlineArray8_Single y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray8_Single other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray8_Single)
		{
			return Equals((InlineArray8_Single)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray8_Single, float>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<float>)this).GetEnumerator();
	}
}
