using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(6)]
public partial struct InlineArray6_fputil_ExceptValues_float_6_Mapping : IEquatable<InlineArray6_fputil_ExceptValues_float_6_Mapping>, IEqualityOperators<InlineArray6_fputil_ExceptValues_float_6_Mapping, InlineArray6_fputil_ExceptValues_float_6_Mapping, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray6_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
{
	private fputil_ExceptValues_float_6_Mapping __element0;

	public static int Length => 6;

	public static bool operator ==(InlineArray6_fputil_ExceptValues_float_6_Mapping x, InlineArray6_fputil_ExceptValues_float_6_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray6_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray6_fputil_ExceptValues_float_6_Mapping x, InlineArray6_fputil_ExceptValues_float_6_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray6_fputil_ExceptValues_float_6_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray6_fputil_ExceptValues_float_6_Mapping)
		{
			return Equals((InlineArray6_fputil_ExceptValues_float_6_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray6_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_ExceptValues_float_6_Mapping>)this).GetEnumerator();
	}
}
