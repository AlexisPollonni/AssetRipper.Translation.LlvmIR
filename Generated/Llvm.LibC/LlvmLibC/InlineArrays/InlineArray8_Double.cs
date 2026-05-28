using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray8_Double : IEquatable<InlineArray8_Double>, IEqualityOperators<InlineArray8_Double, InlineArray8_Double, bool>, IEnumerable, IInlineArray<InlineArray8_Double, double>
{
	private double __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray8_Double x, InlineArray8_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray8_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray8_Double x, InlineArray8_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray8_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray8_Double)
		{
			return Equals((InlineArray8_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray8_Double, double>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
