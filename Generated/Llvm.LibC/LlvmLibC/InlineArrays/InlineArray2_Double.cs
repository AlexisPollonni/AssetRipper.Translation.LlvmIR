using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_Double : IEquatable<InlineArray2_Double>, IEqualityOperators<InlineArray2_Double, InlineArray2_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_Double, double>
{
	private double __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_Double x, InlineArray2_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray2_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray2_Double x, InlineArray2_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_Double)
		{
			return Equals((InlineArray2_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
