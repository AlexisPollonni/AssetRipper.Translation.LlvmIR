using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(64)]
public partial struct InlineArray64_fputil_TripleDouble : IEquatable<InlineArray64_fputil_TripleDouble>, IEqualityOperators<InlineArray64_fputil_TripleDouble, InlineArray64_fputil_TripleDouble, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray64_fputil_TripleDouble, fputil_TripleDouble>
{
	private fputil_TripleDouble __element0;

	public static int Length => 64;

	public static bool operator ==(InlineArray64_fputil_TripleDouble x, InlineArray64_fputil_TripleDouble y)
	{
		return InlineArrayHelper.Equals<InlineArray64_fputil_TripleDouble, fputil_TripleDouble>(x, y);
	}

	public static bool operator !=(InlineArray64_fputil_TripleDouble x, InlineArray64_fputil_TripleDouble y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray64_fputil_TripleDouble other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray64_fputil_TripleDouble)
		{
			return Equals((InlineArray64_fputil_TripleDouble)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray64_fputil_TripleDouble, fputil_TripleDouble>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_TripleDouble>)this).GetEnumerator();
	}
}
