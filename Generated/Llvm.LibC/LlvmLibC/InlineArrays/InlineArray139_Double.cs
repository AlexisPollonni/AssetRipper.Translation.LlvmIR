using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(139)]
public partial struct InlineArray139_Double : IEquatable<InlineArray139_Double>, IEqualityOperators<InlineArray139_Double, InlineArray139_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray139_Double, double>
{
	private double __element0;

	public static int Length => 139;

	public static bool operator ==(InlineArray139_Double x, InlineArray139_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray139_Double, double>(x, y);
	}

	public static bool operator !=(InlineArray139_Double x, InlineArray139_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray139_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray139_Double)
		{
			return Equals((InlineArray139_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray139_Double, double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<double>)this).GetEnumerator();
	}
}
