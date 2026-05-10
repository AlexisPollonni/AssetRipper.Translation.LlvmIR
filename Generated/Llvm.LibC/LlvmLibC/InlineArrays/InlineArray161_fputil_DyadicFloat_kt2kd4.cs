using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(161)]
public partial struct InlineArray161_fputil_DyadicFloat_kt2kd4 : IEquatable<InlineArray161_fputil_DyadicFloat_kt2kd4>, IEqualityOperators<InlineArray161_fputil_DyadicFloat_kt2kd4, InlineArray161_fputil_DyadicFloat_kt2kd4, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray161_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
{
	private fputil_DyadicFloat_kt2kd4 __element0;

	public static int Length => 161;

	public static bool operator ==(InlineArray161_fputil_DyadicFloat_kt2kd4 x, InlineArray161_fputil_DyadicFloat_kt2kd4 y)
	{
		return InlineArrayHelper.Equals<InlineArray161_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>(x, y);
	}

	public static bool operator !=(InlineArray161_fputil_DyadicFloat_kt2kd4 x, InlineArray161_fputil_DyadicFloat_kt2kd4 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray161_fputil_DyadicFloat_kt2kd4 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray161_fputil_DyadicFloat_kt2kd4)
		{
			return Equals((InlineArray161_fputil_DyadicFloat_kt2kd4)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray161_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_DyadicFloat_kt2kd4>)this).GetEnumerator();
	}
}
