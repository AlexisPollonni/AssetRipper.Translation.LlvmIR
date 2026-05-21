using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(2)]
public partial struct InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping : IEquatable<InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>, IEqualityOperators<InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>
{
	private Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping __element0;

	public static int Length => 2;

	public static bool operator ==(InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping x, InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping x, InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping)
		{
			return Equals((InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>)this).GetEnumerator();
	}
}
