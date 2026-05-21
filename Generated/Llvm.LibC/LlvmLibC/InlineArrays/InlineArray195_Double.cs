using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(195)]
public partial struct InlineArray195_Double : IEquatable<InlineArray195_Double>, IEqualityOperators<InlineArray195_Double, InlineArray195_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray195_Double, double>
{
	private double __element0;

	public static int Length => 195;

	public static bool operator ==(InlineArray195_Double x, InlineArray195_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray195_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray195_Double x, InlineArray195_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray195_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray195_Double)
		{
			return Equals((InlineArray195_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray195_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
