using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(17)]
public partial struct InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping : IEquatable<InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>, IEqualityOperators<InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, bool>, IEnumerable, IInlineArray<InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>
{
	private Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping __element0;

	public static int Length => 17;

	public static bool operator ==(InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping x, InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping x, InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping)
		{
			return Equals((InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray17_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>)this).GetEnumerator();
	}
}
