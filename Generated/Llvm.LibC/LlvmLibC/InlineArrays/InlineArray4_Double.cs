using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray4_Double : IEquatable<InlineArray4_Double>, IEqualityOperators<InlineArray4_Double, InlineArray4_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray4_Double, double>
{
	private double __element0;

	public static int Length => 4;

	public static bool operator ==(InlineArray4_Double x, InlineArray4_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray4_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray4_Double x, InlineArray4_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray4_Double)
		{
			return Equals((InlineArray4_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
