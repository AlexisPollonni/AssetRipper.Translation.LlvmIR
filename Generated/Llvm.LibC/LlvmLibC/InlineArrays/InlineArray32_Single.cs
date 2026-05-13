using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(32)]
public partial struct InlineArray32_Single : IEquatable<InlineArray32_Single>, IEqualityOperators<InlineArray32_Single, InlineArray32_Single, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray32_Single, float>
{
	private float __element0;

	public static int Length => 32;

	public static bool operator ==(InlineArray32_Single x, InlineArray32_Single y)
	{
		return InlineArrayHelper.Equals<InlineArray32_Single, float>(x, y);
	}

	public static bool operator !=(InlineArray32_Single x, InlineArray32_Single y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray32_Single other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray32_Single)
		{
			return Equals((InlineArray32_Single)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray32_Single, float>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<float>)this).GetEnumerator();
	}
}
