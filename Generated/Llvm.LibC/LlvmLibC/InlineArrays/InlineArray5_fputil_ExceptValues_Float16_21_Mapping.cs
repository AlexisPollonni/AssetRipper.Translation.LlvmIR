using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(5)]
public partial struct InlineArray5_fputil_ExceptValues_Float16_21_Mapping : IEquatable<InlineArray5_fputil_ExceptValues_Float16_21_Mapping>, IEqualityOperators<InlineArray5_fputil_ExceptValues_Float16_21_Mapping, InlineArray5_fputil_ExceptValues_Float16_21_Mapping, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray5_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
{
	private fputil_ExceptValues_Float16_21_Mapping __element0;

	public static int Length => 5;

	public static bool operator ==(InlineArray5_fputil_ExceptValues_Float16_21_Mapping x, InlineArray5_fputil_ExceptValues_Float16_21_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray5_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray5_fputil_ExceptValues_Float16_21_Mapping x, InlineArray5_fputil_ExceptValues_Float16_21_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray5_fputil_ExceptValues_Float16_21_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray5_fputil_ExceptValues_Float16_21_Mapping)
		{
			return Equals((InlineArray5_fputil_ExceptValues_Float16_21_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray5_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<fputil_ExceptValues_Float16_21_Mapping>)this).GetEnumerator();
	}
}
