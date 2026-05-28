using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(32)]
public partial struct InlineArray32_InlineArray8_Double : IEquatable<InlineArray32_InlineArray8_Double>, IEqualityOperators<InlineArray32_InlineArray8_Double, InlineArray32_InlineArray8_Double, bool>, IEnumerable, IInlineArray<InlineArray32_InlineArray8_Double, InlineArray8_Double>, IInlineArray<InlineArray32_InlineArray8_Double, double>
{
	private InlineArray8_Double __element0;

	public static int Length => 32;

	static int IInlineArray<double>.Length => 256;

	public static bool operator ==(InlineArray32_InlineArray8_Double x, InlineArray32_InlineArray8_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray32_InlineArray8_Double, InlineArray8_Double>(x, y);
	}

	public static bool operator !=(InlineArray32_InlineArray8_Double x, InlineArray32_InlineArray8_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray32_InlineArray8_Double other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray32_InlineArray8_Double)
		{
			return Equals((InlineArray32_InlineArray8_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray32_InlineArray8_Double, InlineArray8_Double>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray8_Double>)this).GetEnumerator();
	}
}
