using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc : IEquatable<InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc>, IEqualityOperators<InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc, InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc, bool>, IEnumerable, IInlineArray<InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc, Llvm_libc_20_1_2_printf_core_TypeDesc>
{
	private Llvm_libc_20_1_2_printf_core_TypeDesc __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc x, InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc y)
	{
		return InlineArrayHelper.Equals<InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc, Llvm_libc_20_1_2_printf_core_TypeDesc>(x, y);
	}

	public static bool operator !=(InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc x, InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc)
		{
			return Equals((InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc, Llvm_libc_20_1_2_printf_core_TypeDesc>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_printf_core_TypeDesc>)this).GetEnumerator();
	}
}
