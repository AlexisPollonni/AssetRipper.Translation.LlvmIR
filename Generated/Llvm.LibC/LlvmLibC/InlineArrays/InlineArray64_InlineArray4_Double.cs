using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(64)]
public partial struct InlineArray64_InlineArray4_Double : IEquatable<InlineArray64_InlineArray4_Double>, IEqualityOperators<InlineArray64_InlineArray4_Double, InlineArray64_InlineArray4_Double, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray64_InlineArray4_Double, InlineArray4_Double>, IInlineArray<InlineArray64_InlineArray4_Double, double>
{
	private InlineArray4_Double __element0;

	public static int Length => 64;

	static int IInlineArray<double>.Length => 256;

	public static bool operator ==(InlineArray64_InlineArray4_Double x, InlineArray64_InlineArray4_Double y)
	{
		return InlineArrayHelper.Equals<InlineArray64_InlineArray4_Double, InlineArray4_Double>(x, y);
	}

	public static bool operator !=(InlineArray64_InlineArray4_Double x, InlineArray64_InlineArray4_Double y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray64_InlineArray4_Double other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray64_InlineArray4_Double)
		{
			return Equals((InlineArray64_InlineArray4_Double)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray64_InlineArray4_Double, InlineArray4_Double>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray4_Double>)this).GetEnumerator();
	}
}
