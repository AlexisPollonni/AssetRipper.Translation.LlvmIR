using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(64)]
public partial struct InlineArray64_Int16 : IEquatable<InlineArray64_Int16>, IEqualityOperators<InlineArray64_Int16, InlineArray64_Int16, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray64_Int16, short>, IInlineArray<InlineArray64_Int16, ushort>, IInlineArray<InlineArray64_Int16, char>
{
	private short __element0;

	public static int Length => 64;

	public static bool operator ==(InlineArray64_Int16 x, InlineArray64_Int16 y)
	{
		return InlineArrayHelper.Equals<InlineArray64_Int16, short>(x, y);
	}

	public static bool operator !=(InlineArray64_Int16 x, InlineArray64_Int16 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray64_Int16 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray64_Int16)
		{
			return Equals((InlineArray64_Int16)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray64_Int16, short>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<short>)this).GetEnumerator();
	}
}
