using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_Single : IEquatable<InlineArray128_Single>, IEqualityOperators<InlineArray128_Single, InlineArray128_Single, bool>, IEnumerable, IInlineArray<InlineArray128_Single, float>
{
	private float __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_Single x, InlineArray128_Single y)
	{
		return InlineArrayHelper.Equals<InlineArray128_Single, float>(x, y);
	}

	public static bool operator !=(InlineArray128_Single x, InlineArray128_Single y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_Single other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray128_Single)
		{
			return Equals((InlineArray128_Single)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_Single, float>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<float>)this).GetEnumerator();
	}
}
