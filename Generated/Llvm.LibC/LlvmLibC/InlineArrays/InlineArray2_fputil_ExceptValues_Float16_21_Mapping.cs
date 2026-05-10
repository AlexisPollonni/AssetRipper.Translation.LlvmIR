using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_fputil_ExceptValues_Float16_21_Mapping : IEquatable<InlineArray2_fputil_ExceptValues_Float16_21_Mapping>, IEqualityOperators<InlineArray2_fputil_ExceptValues_Float16_21_Mapping, InlineArray2_fputil_ExceptValues_Float16_21_Mapping, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
{
	private fputil_ExceptValues_Float16_21_Mapping __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_fputil_ExceptValues_Float16_21_Mapping x, InlineArray2_fputil_ExceptValues_Float16_21_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray2_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray2_fputil_ExceptValues_Float16_21_Mapping x, InlineArray2_fputil_ExceptValues_Float16_21_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_fputil_ExceptValues_Float16_21_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray2_fputil_ExceptValues_Float16_21_Mapping)
		{
			return Equals((InlineArray2_fputil_ExceptValues_Float16_21_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_ExceptValues_Float16_21_Mapping>)this).GetEnumerator();
	}
}
