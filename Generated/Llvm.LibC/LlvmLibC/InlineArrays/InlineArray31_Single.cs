using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(31)]
public partial struct InlineArray31_Single : IEquatable<InlineArray31_Single>, IEqualityOperators<InlineArray31_Single, InlineArray31_Single, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray31_Single, float>
{
	private float __element0;

	public static int Length => 31;

	public static bool operator ==(InlineArray31_Single x, InlineArray31_Single y)
	{
		return InlineArrayHelper.Equals<InlineArray31_Single, float>(x, y);
	}

	public static bool operator !=(InlineArray31_Single x, InlineArray31_Single y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray31_Single other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray31_Single)
		{
			return Equals((InlineArray31_Single)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray31_Single, float>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<float>)this).GetEnumerator();
	}
}
