using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(7)]
public partial struct InlineArray7_Llvm_libc_20_1_2_NumberPair : IEquatable<InlineArray7_Llvm_libc_20_1_2_NumberPair>, IEqualityOperators<InlineArray7_Llvm_libc_20_1_2_NumberPair, InlineArray7_Llvm_libc_20_1_2_NumberPair, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray7_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
{
	private Llvm_libc_20_1_2_NumberPair __element0;

	public static int Length => 7;

	public static bool operator ==(InlineArray7_Llvm_libc_20_1_2_NumberPair x, InlineArray7_Llvm_libc_20_1_2_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray7_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray7_Llvm_libc_20_1_2_NumberPair x, InlineArray7_Llvm_libc_20_1_2_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray7_Llvm_libc_20_1_2_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray7_Llvm_libc_20_1_2_NumberPair)
		{
			return Equals((InlineArray7_Llvm_libc_20_1_2_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray7_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_NumberPair>)this).GetEnumerator();
	}
}
