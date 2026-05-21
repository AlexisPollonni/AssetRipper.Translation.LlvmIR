using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(11)]
public partial struct InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping : IEquatable<InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>, IEqualityOperators<InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>
{
	private Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping __element0;

	public static int Length => 11;

	public static bool operator ==(InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping x, InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping x, InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping)
		{
			return Equals((InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray11_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>)this).GetEnumerator();
	}
}
