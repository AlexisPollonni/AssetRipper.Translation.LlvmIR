using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(139)]
public partial struct InlineArray139_fputil_DyadicFloat_kt2kd4 : IEquatable<InlineArray139_fputil_DyadicFloat_kt2kd4>, IEqualityOperators<InlineArray139_fputil_DyadicFloat_kt2kd4, InlineArray139_fputil_DyadicFloat_kt2kd4, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray139_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>
{
	private fputil_DyadicFloat_kt2kd4 __element0;

	public static int Length => 139;

	public static bool operator ==(InlineArray139_fputil_DyadicFloat_kt2kd4 x, InlineArray139_fputil_DyadicFloat_kt2kd4 y)
	{
		return InlineArrayHelper.Equals<InlineArray139_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>(x, y);
	}

	public static bool operator !=(InlineArray139_fputil_DyadicFloat_kt2kd4 x, InlineArray139_fputil_DyadicFloat_kt2kd4 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray139_fputil_DyadicFloat_kt2kd4 other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray139_fputil_DyadicFloat_kt2kd4)
		{
			return Equals((InlineArray139_fputil_DyadicFloat_kt2kd4)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray139_fputil_DyadicFloat_kt2kd4, fputil_DyadicFloat_kt2kd4>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_DyadicFloat_kt2kd4>)this).GetEnumerator();
	}
}
