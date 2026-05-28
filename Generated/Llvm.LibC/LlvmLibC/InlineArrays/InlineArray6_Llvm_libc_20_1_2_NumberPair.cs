using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(6)]
public partial struct InlineArray6_Llvm_libc_20_1_2_NumberPair : IEquatable<InlineArray6_Llvm_libc_20_1_2_NumberPair>, IEqualityOperators<InlineArray6_Llvm_libc_20_1_2_NumberPair, InlineArray6_Llvm_libc_20_1_2_NumberPair, bool>, IEnumerable, IInlineArray<InlineArray6_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
{
	private Llvm_libc_20_1_2_NumberPair __element0;

	public static int Length => 6;

	public static bool operator ==(InlineArray6_Llvm_libc_20_1_2_NumberPair x, InlineArray6_Llvm_libc_20_1_2_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray6_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray6_Llvm_libc_20_1_2_NumberPair x, InlineArray6_Llvm_libc_20_1_2_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray6_Llvm_libc_20_1_2_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray6_Llvm_libc_20_1_2_NumberPair)
		{
			return Equals((InlineArray6_Llvm_libc_20_1_2_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray6_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_NumberPair>)this).GetEnumerator();
	}
}
