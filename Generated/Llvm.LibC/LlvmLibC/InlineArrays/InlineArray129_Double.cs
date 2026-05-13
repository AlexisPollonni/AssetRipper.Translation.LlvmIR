using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(129)]
public partial struct InlineArray129_Double : IEquatable<InlineArray129_Double>, IEqualityOperators<InlineArray129_Double, InlineArray129_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray129_Double, double>
{
	private double __element0;

	public static int Length => 129;

	public static bool operator ==(InlineArray129_Double x, InlineArray129_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray129_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray129_Double x, InlineArray129_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray129_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray129_Double)
		{
			return Equals((InlineArray129_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray129_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
