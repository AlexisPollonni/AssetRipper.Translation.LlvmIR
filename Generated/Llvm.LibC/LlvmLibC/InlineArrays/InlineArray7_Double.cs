using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(7)]
public partial struct InlineArray7_Double : IEquatable<InlineArray7_Double>, IEqualityOperators<InlineArray7_Double, InlineArray7_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray7_Double, double>
{
	private double __element0;

	public static int Length => 7;

	public static bool operator ==(InlineArray7_Double x, InlineArray7_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray7_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray7_Double x, InlineArray7_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray7_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray7_Double)
		{
			return Equals((InlineArray7_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray7_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
