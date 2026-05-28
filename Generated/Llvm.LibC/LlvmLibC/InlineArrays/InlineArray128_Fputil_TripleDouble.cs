using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_Fputil_TripleDouble : IEquatable<InlineArray128_Fputil_TripleDouble>, IEqualityOperators<InlineArray128_Fputil_TripleDouble, InlineArray128_Fputil_TripleDouble, bool>, IEnumerable, IInlineArray<InlineArray128_Fputil_TripleDouble, Fputil_TripleDouble>
{
	private Fputil_TripleDouble __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_Fputil_TripleDouble x, InlineArray128_Fputil_TripleDouble y)
	{
		return InlineArrayHelper.Equals<InlineArray128_Fputil_TripleDouble, Fputil_TripleDouble>(x, y);
	}

	public static bool operator !=(InlineArray128_Fputil_TripleDouble x, InlineArray128_Fputil_TripleDouble y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_Fputil_TripleDouble other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray128_Fputil_TripleDouble)
		{
			return Equals((InlineArray128_Fputil_TripleDouble)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_Fputil_TripleDouble, Fputil_TripleDouble>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Fputil_TripleDouble>)this).GetEnumerator();
	}
}
