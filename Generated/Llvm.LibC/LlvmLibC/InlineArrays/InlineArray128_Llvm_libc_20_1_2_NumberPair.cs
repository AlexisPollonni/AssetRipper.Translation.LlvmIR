using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_Llvm_libc_20_1_2_NumberPair : IEquatable<InlineArray128_Llvm_libc_20_1_2_NumberPair>, IEqualityOperators<InlineArray128_Llvm_libc_20_1_2_NumberPair, InlineArray128_Llvm_libc_20_1_2_NumberPair, bool>, IEnumerable, IInlineArray<InlineArray128_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
{
	private Llvm_libc_20_1_2_NumberPair __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_Llvm_libc_20_1_2_NumberPair x, InlineArray128_Llvm_libc_20_1_2_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray128_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray128_Llvm_libc_20_1_2_NumberPair x, InlineArray128_Llvm_libc_20_1_2_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_Llvm_libc_20_1_2_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray128_Llvm_libc_20_1_2_NumberPair)
		{
			return Equals((InlineArray128_Llvm_libc_20_1_2_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_NumberPair>)this).GetEnumerator();
	}
}
