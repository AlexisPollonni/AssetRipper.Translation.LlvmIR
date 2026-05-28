using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(64)]
public partial struct InlineArray64_Fputil_TripleDouble : IEquatable<InlineArray64_Fputil_TripleDouble>, IEqualityOperators<InlineArray64_Fputil_TripleDouble, InlineArray64_Fputil_TripleDouble, bool>, IEnumerable, IInlineArray<InlineArray64_Fputil_TripleDouble, Fputil_TripleDouble>
{
	private Fputil_TripleDouble __element0;

	public static int Length => 64;

	public static bool operator ==(InlineArray64_Fputil_TripleDouble x, InlineArray64_Fputil_TripleDouble y)
	{
		return InlineArrayHelper.Equals<InlineArray64_Fputil_TripleDouble, Fputil_TripleDouble>(x, y);
	}

	public static bool operator !=(InlineArray64_Fputil_TripleDouble x, InlineArray64_Fputil_TripleDouble y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray64_Fputil_TripleDouble other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray64_Fputil_TripleDouble)
		{
			return Equals((InlineArray64_Fputil_TripleDouble)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray64_Fputil_TripleDouble, Fputil_TripleDouble>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Fputil_TripleDouble>)this).GetEnumerator();
	}
}
