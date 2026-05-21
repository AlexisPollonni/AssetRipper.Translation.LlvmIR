using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair : IEquatable<InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair>, IEqualityOperators<InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair, InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair, InlineArray2_Llvm_libc_20_1_2_NumberPair>, IInlineArray<InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
{
	private InlineArray2_Llvm_libc_20_1_2_NumberPair __element0;

	public static int Length => 3;

	static int IInlineArray<Llvm_libc_20_1_2_NumberPair>.Length => 6;

	public static bool operator ==(InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair x, InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair, InlineArray2_Llvm_libc_20_1_2_NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair x, InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair)
		{
			return Equals((InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_InlineArray2_Llvm_libc_20_1_2_NumberPair, InlineArray2_Llvm_libc_20_1_2_NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<InlineArray2_Llvm_libc_20_1_2_NumberPair>)this).GetEnumerator();
	}
}
