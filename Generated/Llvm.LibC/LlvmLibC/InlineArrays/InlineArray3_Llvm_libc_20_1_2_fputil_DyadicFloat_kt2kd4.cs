using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 : IEquatable<InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>, IEqualityOperators<InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, bool>, IEnumerable, IInlineArray<InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>
{
	private Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 __element0;

	public static int Length => 3;

	public static bool operator ==(InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 x, InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 y)
	{
		return InlineArrayHelper.Equals<InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>(x, y);
	}

	public static bool operator !=(InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 x, InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4)
		{
			return Equals((InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>)this).GetEnumerator();
	}
}
