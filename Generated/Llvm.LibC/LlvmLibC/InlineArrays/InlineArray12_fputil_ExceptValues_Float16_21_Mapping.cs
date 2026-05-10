using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(12)]
public partial struct InlineArray12_fputil_ExceptValues_Float16_21_Mapping : IEquatable<InlineArray12_fputil_ExceptValues_Float16_21_Mapping>, IEqualityOperators<InlineArray12_fputil_ExceptValues_Float16_21_Mapping, InlineArray12_fputil_ExceptValues_Float16_21_Mapping, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray12_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
{
	private fputil_ExceptValues_Float16_21_Mapping __element0;

	public static int Length => 12;

	public static bool operator ==(InlineArray12_fputil_ExceptValues_Float16_21_Mapping x, InlineArray12_fputil_ExceptValues_Float16_21_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray12_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray12_fputil_ExceptValues_Float16_21_Mapping x, InlineArray12_fputil_ExceptValues_Float16_21_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray12_fputil_ExceptValues_Float16_21_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray12_fputil_ExceptValues_Float16_21_Mapping)
		{
			return Equals((InlineArray12_fputil_ExceptValues_Float16_21_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray12_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_ExceptValues_Float16_21_Mapping>)this).GetEnumerator();
	}
}
