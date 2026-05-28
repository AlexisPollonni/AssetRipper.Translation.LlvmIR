using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(16)]
public partial struct InlineArray16_InlineArray7_Double : IEquatable<InlineArray16_InlineArray7_Double>, IEqualityOperators<InlineArray16_InlineArray7_Double, InlineArray16_InlineArray7_Double, bool>, IEnumerable, IInlineArray<InlineArray16_InlineArray7_Double, InlineArray7_Double>, IInlineArray<InlineArray16_InlineArray7_Double, double>
{
	private InlineArray7_Double __element0;

	public static int Length => 16;

	static int IInlineArray<double>.Length => 112;

	public static bool operator ==(InlineArray16_InlineArray7_Double x, InlineArray16_InlineArray7_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray16_InlineArray7_Double, InlineArray7_Double>(x, y);
	}

	public static bool operator !=(InlineArray16_InlineArray7_Double x, InlineArray16_InlineArray7_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray16_InlineArray7_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray16_InlineArray7_Double)
		{
			return Equals((InlineArray16_InlineArray7_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray16_InlineArray7_Double, InlineArray7_Double>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray7_Double>)this).GetEnumerator();
	}
}
