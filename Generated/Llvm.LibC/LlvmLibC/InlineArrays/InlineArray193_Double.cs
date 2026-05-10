using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(193)]
public partial struct InlineArray193_Double : IEquatable<InlineArray193_Double>, IEqualityOperators<InlineArray193_Double, InlineArray193_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray193_Double, double>
{
	private double __element0;

	public static int Length => 193;

	public static bool operator ==(InlineArray193_Double x, InlineArray193_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray193_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray193_Double x, InlineArray193_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray193_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray193_Double)
		{
			return Equals((InlineArray193_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray193_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
