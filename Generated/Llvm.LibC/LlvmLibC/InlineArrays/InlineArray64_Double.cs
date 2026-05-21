using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(64)]
public partial struct InlineArray64_Double : IEquatable<InlineArray64_Double>, IEqualityOperators<InlineArray64_Double, InlineArray64_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray64_Double, double>
{
	private double __element0;

	public static int Length => 64;

	public static bool operator ==(InlineArray64_Double x, InlineArray64_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray64_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray64_Double x, InlineArray64_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray64_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray64_Double)
		{
			return Equals((InlineArray64_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray64_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
