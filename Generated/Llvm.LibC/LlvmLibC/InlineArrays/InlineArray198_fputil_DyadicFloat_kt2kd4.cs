using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(198)]
public partial struct InlineArray198_fputil_DyadicFloat_kt2kd4 : IEquatable<InlineArray198_fputil_DyadicFloat_kt2kd4>, IEqualityOperators<InlineArray198_fputil_DyadicFloat_kt2kd4, InlineArray198_fputil_DyadicFloat_kt2kd4, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray198_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
{
	private fputil_DyadicFloat_kt2kd4 __element0;

	public static int Length => 198;

	public static bool operator ==(InlineArray198_fputil_DyadicFloat_kt2kd4 x, InlineArray198_fputil_DyadicFloat_kt2kd4 y)
	{
		return InlineArrayHelper.Equals<InlineArray198_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>(x, y);
	}

	public static bool operator !=(InlineArray198_fputil_DyadicFloat_kt2kd4 x, InlineArray198_fputil_DyadicFloat_kt2kd4 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray198_fputil_DyadicFloat_kt2kd4 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray198_fputil_DyadicFloat_kt2kd4)
		{
			return Equals((InlineArray198_fputil_DyadicFloat_kt2kd4)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray198_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_DyadicFloat_kt2kd4>)this).GetEnumerator();
	}
}
