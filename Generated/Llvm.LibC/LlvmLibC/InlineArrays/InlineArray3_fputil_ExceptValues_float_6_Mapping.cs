using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_fputil_ExceptValues_float_6_Mapping : IEquatable<InlineArray3_fputil_ExceptValues_float_6_Mapping>, IEqualityOperators<InlineArray3_fputil_ExceptValues_float_6_Mapping, InlineArray3_fputil_ExceptValues_float_6_Mapping, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray3_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
{
	private fputil_ExceptValues_float_6_Mapping __element0;

	public static int Length => 3;

	public static bool operator ==(InlineArray3_fputil_ExceptValues_float_6_Mapping x, InlineArray3_fputil_ExceptValues_float_6_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray3_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray3_fputil_ExceptValues_float_6_Mapping x, InlineArray3_fputil_ExceptValues_float_6_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_fputil_ExceptValues_float_6_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray3_fputil_ExceptValues_float_6_Mapping)
		{
			return Equals((InlineArray3_fputil_ExceptValues_float_6_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_ExceptValues_float_6_Mapping>)this).GetEnumerator();
	}
}
