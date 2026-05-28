using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(8)]
public partial struct InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping : IEquatable<InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>, IEqualityOperators<InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, bool>, IEnumerable, IInlineArray<InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>
{
	private Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping __element0;

	public static int Length => 8;

	public static bool operator ==(InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping x, InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping x, InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping)
		{
			return Equals((InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>)this).GetEnumerator();
	}
}
