using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.InlineArrays;

[InlineArray(17)]
public partial struct InlineArray17_InlineArray9_Double : IEquatable<InlineArray17_InlineArray9_Double>, IEqualityOperators<InlineArray17_InlineArray9_Double, InlineArray17_InlineArray9_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray17_InlineArray9_Double, InlineArray9_Double>, IInlineArray<InlineArray17_InlineArray9_Double, double>
{
	private InlineArray9_Double __element0;

	public static int Length => 17;

	static int IInlineArray<double>.Length => 153;

	public static bool operator ==(InlineArray17_InlineArray9_Double x, InlineArray17_InlineArray9_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray17_InlineArray9_Double, InlineArray9_Double>(x, y);
	}

	public static bool operator !=(InlineArray17_InlineArray9_Double x, InlineArray17_InlineArray9_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray17_InlineArray9_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray17_InlineArray9_Double)
		{
			return Equals((InlineArray17_InlineArray9_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray17_InlineArray9_Double, InlineArray9_Double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray9_Double>)this).GetEnumerator();
	}
}
