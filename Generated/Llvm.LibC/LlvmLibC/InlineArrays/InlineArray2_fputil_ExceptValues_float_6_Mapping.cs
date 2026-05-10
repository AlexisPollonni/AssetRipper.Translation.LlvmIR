using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_fputil_ExceptValues_float_6_Mapping : IEquatable<InlineArray2_fputil_ExceptValues_float_6_Mapping>, IEqualityOperators<InlineArray2_fputil_ExceptValues_float_6_Mapping, InlineArray2_fputil_ExceptValues_float_6_Mapping, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
{
	private fputil_ExceptValues_float_6_Mapping __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_fputil_ExceptValues_float_6_Mapping x, InlineArray2_fputil_ExceptValues_float_6_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray2_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray2_fputil_ExceptValues_float_6_Mapping x, InlineArray2_fputil_ExceptValues_float_6_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_fputil_ExceptValues_float_6_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_fputil_ExceptValues_float_6_Mapping)
		{
			return Equals((InlineArray2_fputil_ExceptValues_float_6_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_ExceptValues_float_6_Mapping>)this).GetEnumerator();
	}
}
