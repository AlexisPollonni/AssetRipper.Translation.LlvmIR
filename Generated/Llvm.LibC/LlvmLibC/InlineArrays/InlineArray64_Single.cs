using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(64)]
public partial struct InlineArray64_Single : IEquatable<InlineArray64_Single>, IEqualityOperators<InlineArray64_Single, InlineArray64_Single, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray64_Single, float>
{
	private float __element0;

	public static int Length => 64;

	public static bool operator ==(InlineArray64_Single x, InlineArray64_Single y)
	{
		return InlineArrayHelper.Equals<InlineArray64_Single, float>(x, y);
	}

	public static bool operator !=(InlineArray64_Single x, InlineArray64_Single y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray64_Single other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray64_Single)
		{
			return Equals((InlineArray64_Single)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray64_Single, float>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<float>)this).GetEnumerator();
	}
}
