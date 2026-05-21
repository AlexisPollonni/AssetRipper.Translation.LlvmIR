using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(188)]
public partial struct InlineArray188_Double : IEquatable<InlineArray188_Double>, IEqualityOperators<InlineArray188_Double, InlineArray188_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray188_Double, double>
{
	private double __element0;

	public static int Length => 188;

	public static bool operator ==(InlineArray188_Double x, InlineArray188_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray188_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray188_Double x, InlineArray188_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray188_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray188_Double)
		{
			return Equals((InlineArray188_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray188_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
