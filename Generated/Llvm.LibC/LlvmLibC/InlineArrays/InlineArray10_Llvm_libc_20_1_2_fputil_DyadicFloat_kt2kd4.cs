using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(10)]
public partial struct InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 : IEquatable<InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>, IEqualityOperators<InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, bool>, IEnumerable, IInlineArray<InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>
{
	private Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 __element0;

	public static int Length => 10;

	public static bool operator ==(InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 x, InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 y)
	{
		return InlineArrayHelper.Equals<InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>(x, y);
	}

	public static bool operator !=(InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 x, InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4)
		{
			return Equals((InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray10_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>)this).GetEnumerator();
	}
}
