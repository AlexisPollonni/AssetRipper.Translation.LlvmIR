using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_Double : IEquatable<InlineArray3_Double>, IEqualityOperators<InlineArray3_Double, InlineArray3_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray3_Double, double>
{
	private double __element0;

	public static int Length => 3;

	public static bool operator ==(InlineArray3_Double x, InlineArray3_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray3_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray3_Double x, InlineArray3_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray3_Double)
		{
			return Equals((InlineArray3_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
