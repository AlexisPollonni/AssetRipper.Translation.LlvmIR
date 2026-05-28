using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray8_Fputil_DyadicFloat_kt2kd4 : IEquatable<InlineArray8_Fputil_DyadicFloat_kt2kd4>, IEqualityOperators<InlineArray8_Fputil_DyadicFloat_kt2kd4, InlineArray8_Fputil_DyadicFloat_kt2kd4, bool>, IEnumerable, IInlineArray<InlineArray8_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>
{
	private Fputil_DyadicFloat_kt2kd4 __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray8_Fputil_DyadicFloat_kt2kd4 x, InlineArray8_Fputil_DyadicFloat_kt2kd4 y)
	{
		return InlineArrayHelper.Equals<InlineArray8_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>(x, y);
	}

	public static bool operator !=(InlineArray8_Fputil_DyadicFloat_kt2kd4 x, InlineArray8_Fputil_DyadicFloat_kt2kd4 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray8_Fputil_DyadicFloat_kt2kd4 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray8_Fputil_DyadicFloat_kt2kd4)
		{
			return Equals((InlineArray8_Fputil_DyadicFloat_kt2kd4)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray8_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Fputil_DyadicFloat_kt2kd4>)this).GetEnumerator();
	}
}
