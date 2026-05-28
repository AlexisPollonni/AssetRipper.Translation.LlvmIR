using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 : IEquatable<InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>, IEqualityOperators<InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, bool>, IEnumerable, IInlineArray<InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>
{
	private Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 x, InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 y)
	{
		return InlineArrayHelper.Equals<InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>(x, y);
	}

	public static bool operator !=(InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 x, InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4)
		{
			return Equals((InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4>)this).GetEnumerator();
	}
}
