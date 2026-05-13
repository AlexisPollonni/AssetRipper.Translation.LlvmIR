using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(5)]
public partial struct InlineArray5_Double : IEquatable<InlineArray5_Double>, IEqualityOperators<InlineArray5_Double, InlineArray5_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray5_Double, double>
{
	private double __element0;

	public static int Length => 5;

	public static bool operator ==(InlineArray5_Double x, InlineArray5_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray5_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray5_Double x, InlineArray5_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray5_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray5_Double)
		{
			return Equals((InlineArray5_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray5_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
