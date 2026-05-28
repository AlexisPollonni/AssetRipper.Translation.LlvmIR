using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_Double : IEquatable<InlineArray128_Double>, IEqualityOperators<InlineArray128_Double, InlineArray128_Double, bool>, IEnumerable, IInlineArray<InlineArray128_Double, double>
{
	private double __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_Double x, InlineArray128_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray128_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray128_Double x, InlineArray128_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray128_Double)
		{
			return Equals((InlineArray128_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_Double, double>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
