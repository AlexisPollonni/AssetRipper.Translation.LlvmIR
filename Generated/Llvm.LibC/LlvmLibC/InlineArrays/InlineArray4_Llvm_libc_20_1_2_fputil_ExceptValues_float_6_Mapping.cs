using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(4)]
public partial struct InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping : IEquatable<InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>, IEqualityOperators<InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, bool>, IEnumerable, IInlineArray<InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>
{
	private Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping __element0;

	public static int Length => 4;

	public static bool operator ==(InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping x, InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping x, InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping)
		{
			return Equals((InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>)this).GetEnumerator();
	}
}
