using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray4_Single : IEquatable<InlineArray4_Single>, IEqualityOperators<InlineArray4_Single, InlineArray4_Single, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray4_Single, float>
{
	private float __element0;

	public static int Length => 4;

	public static bool operator ==(InlineArray4_Single x, InlineArray4_Single y)
	{
		return InlineArrayHelper.Equals<InlineArray4_Single, float>(x, y);
	}

	public static bool operator !=(InlineArray4_Single x, InlineArray4_Single y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4_Single other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray4_Single)
		{
			return Equals((InlineArray4_Single)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4_Single, float>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<float>)this).GetEnumerator();
	}
}
