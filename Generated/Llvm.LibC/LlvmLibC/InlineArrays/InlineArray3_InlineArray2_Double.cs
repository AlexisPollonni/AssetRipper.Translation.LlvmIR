using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_InlineArray2_Double : IEquatable<InlineArray3_InlineArray2_Double>, IEqualityOperators<InlineArray3_InlineArray2_Double, InlineArray3_InlineArray2_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray3_InlineArray2_Double, InlineArray2_Double>, IInlineArray<InlineArray3_InlineArray2_Double, double>
{
	private InlineArray2_Double __element0;

	public static int Length => 3;

	static int IInlineArray<double>.Length => 6;

	public static bool operator ==(InlineArray3_InlineArray2_Double x, InlineArray3_InlineArray2_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray3_InlineArray2_Double, InlineArray2_Double>(x, y);
	}

	public static bool operator !=(InlineArray3_InlineArray2_Double x, InlineArray3_InlineArray2_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_InlineArray2_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray3_InlineArray2_Double)
		{
			return Equals((InlineArray3_InlineArray2_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_InlineArray2_Double, InlineArray2_Double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray2_Double>)this).GetEnumerator();
	}
}
