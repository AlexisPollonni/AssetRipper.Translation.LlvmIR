using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(23)]
public partial struct InlineArray23_Double : IEquatable<InlineArray23_Double>, IEqualityOperators<InlineArray23_Double, InlineArray23_Double, bool>, IEnumerable, IInlineArray<InlineArray23_Double, double>
{
	private double __element0;

	public static int Length => 23;

	public static bool operator ==(InlineArray23_Double x, InlineArray23_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray23_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray23_Double x, InlineArray23_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray23_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray23_Double)
		{
			return Equals((InlineArray23_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray23_Double, double>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
