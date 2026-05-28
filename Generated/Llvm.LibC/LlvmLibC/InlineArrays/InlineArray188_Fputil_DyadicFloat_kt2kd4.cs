using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(188)]
public partial struct InlineArray188_Fputil_DyadicFloat_kt2kd4 : IEquatable<InlineArray188_Fputil_DyadicFloat_kt2kd4>, IEqualityOperators<InlineArray188_Fputil_DyadicFloat_kt2kd4, InlineArray188_Fputil_DyadicFloat_kt2kd4, bool>, IEnumerable, IInlineArray<InlineArray188_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>
{
	private Fputil_DyadicFloat_kt2kd4 __element0;

	public static int Length => 188;

	public static bool operator ==(InlineArray188_Fputil_DyadicFloat_kt2kd4 x, InlineArray188_Fputil_DyadicFloat_kt2kd4 y)
	{
		return InlineArrayHelper.Equals<InlineArray188_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>(x, y);
	}

	public static bool operator !=(InlineArray188_Fputil_DyadicFloat_kt2kd4 x, InlineArray188_Fputil_DyadicFloat_kt2kd4 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray188_Fputil_DyadicFloat_kt2kd4 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray188_Fputil_DyadicFloat_kt2kd4)
		{
			return Equals((InlineArray188_Fputil_DyadicFloat_kt2kd4)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray188_Fputil_DyadicFloat_kt2kd4, Fputil_DyadicFloat_kt2kd4>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Fputil_DyadicFloat_kt2kd4>)this).GetEnumerator();
	}
}
