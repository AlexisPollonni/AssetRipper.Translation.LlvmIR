using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(17)]
public partial struct InlineArray17_Llvm_libc_20_1_2_NumberPair : IEquatable<InlineArray17_Llvm_libc_20_1_2_NumberPair>, IEqualityOperators<InlineArray17_Llvm_libc_20_1_2_NumberPair, InlineArray17_Llvm_libc_20_1_2_NumberPair, bool>, IEnumerable, IInlineArray<InlineArray17_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
{
	private Llvm_libc_20_1_2_NumberPair __element0;

	public static int Length => 17;

	public static bool operator ==(InlineArray17_Llvm_libc_20_1_2_NumberPair x, InlineArray17_Llvm_libc_20_1_2_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray17_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray17_Llvm_libc_20_1_2_NumberPair x, InlineArray17_Llvm_libc_20_1_2_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray17_Llvm_libc_20_1_2_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray17_Llvm_libc_20_1_2_NumberPair)
		{
			return Equals((InlineArray17_Llvm_libc_20_1_2_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray17_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_NumberPair>)this).GetEnumerator();
	}
}
