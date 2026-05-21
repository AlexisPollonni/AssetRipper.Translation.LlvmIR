using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(11)]
public partial struct InlineArray11_Single : IEquatable<InlineArray11_Single>, IEqualityOperators<InlineArray11_Single, InlineArray11_Single, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray11_Single, float>
{
	private float __element0;

	public static int Length => 11;

	public static bool operator ==(InlineArray11_Single x, InlineArray11_Single y)
	{
		return InlineArrayHelper.Equals<InlineArray11_Single, float>(x, y);
	}

	public static bool operator !=(InlineArray11_Single x, InlineArray11_Single y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray11_Single other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray11_Single)
		{
			return Equals((InlineArray11_Single)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray11_Single, float>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<float>)this).GetEnumerator();
	}
}
