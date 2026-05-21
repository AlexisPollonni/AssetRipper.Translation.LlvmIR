using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(28)]
public partial struct InlineArray28_Double : IEquatable<InlineArray28_Double>, IEqualityOperators<InlineArray28_Double, InlineArray28_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray28_Double, double>
{
	private double __element0;

	public static int Length => 28;

	public static bool operator ==(InlineArray28_Double x, InlineArray28_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray28_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray28_Double x, InlineArray28_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray28_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray28_Double)
		{
			return Equals((InlineArray28_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray28_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
