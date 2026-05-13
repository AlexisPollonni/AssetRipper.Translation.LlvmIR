using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(10)]
public partial struct InlineArray10_Double : IEquatable<InlineArray10_Double>, IEqualityOperators<InlineArray10_Double, InlineArray10_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray10_Double, double>
{
	private double __element0;

	public static int Length => 10;

	public static bool operator ==(InlineArray10_Double x, InlineArray10_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray10_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray10_Double x, InlineArray10_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray10_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray10_Double)
		{
			return Equals((InlineArray10_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray10_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
