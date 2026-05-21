using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(256)]
public partial struct InlineArray256_Llvm_libc_20_1_2_NumberPair : IEquatable<InlineArray256_Llvm_libc_20_1_2_NumberPair>, IEqualityOperators<InlineArray256_Llvm_libc_20_1_2_NumberPair, InlineArray256_Llvm_libc_20_1_2_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray256_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
{
	private Llvm_libc_20_1_2_NumberPair __element0;

	public static int Length => 256;

	public static bool operator ==(InlineArray256_Llvm_libc_20_1_2_NumberPair x, InlineArray256_Llvm_libc_20_1_2_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray256_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray256_Llvm_libc_20_1_2_NumberPair x, InlineArray256_Llvm_libc_20_1_2_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray256_Llvm_libc_20_1_2_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray256_Llvm_libc_20_1_2_NumberPair)
		{
			return Equals((InlineArray256_Llvm_libc_20_1_2_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray256_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_NumberPair>)this).GetEnumerator();
	}
}
