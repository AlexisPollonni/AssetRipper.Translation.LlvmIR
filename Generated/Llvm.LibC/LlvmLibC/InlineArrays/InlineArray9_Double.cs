using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(9)]
public partial struct InlineArray9_Double : IEquatable<InlineArray9_Double>, IEqualityOperators<InlineArray9_Double, InlineArray9_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray9_Double, double>
{
	private double __element0;

	public static int Length => 9;

	public static bool operator ==(InlineArray9_Double x, InlineArray9_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray9_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray9_Double x, InlineArray9_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray9_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray9_Double)
		{
			return Equals((InlineArray9_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray9_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
