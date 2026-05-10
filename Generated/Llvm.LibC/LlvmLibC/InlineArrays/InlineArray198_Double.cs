using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(198)]
public partial struct InlineArray198_Double : IEquatable<InlineArray198_Double>, IEqualityOperators<InlineArray198_Double, InlineArray198_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray198_Double, double>
{
	private double __element0;

	public static int Length => 198;

	public static bool operator ==(InlineArray198_Double x, InlineArray198_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray198_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray198_Double x, InlineArray198_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray198_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray198_Double)
		{
			return Equals((InlineArray198_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray198_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
