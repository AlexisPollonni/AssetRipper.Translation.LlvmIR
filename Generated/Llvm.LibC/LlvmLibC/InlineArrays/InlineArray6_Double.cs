using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(6)]
public partial struct InlineArray6_Double : IEquatable<InlineArray6_Double>, IEqualityOperators<InlineArray6_Double, InlineArray6_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray6_Double, double>
{
	private double __element0;

	public static int Length => 6;

	public static bool operator ==(InlineArray6_Double x, InlineArray6_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray6_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray6_Double x, InlineArray6_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray6_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray6_Double)
		{
			return Equals((InlineArray6_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray6_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
