using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(193)]
public partial struct InlineArray193_Llvm_libc_20_1_2_NumberPair : IEquatable<InlineArray193_Llvm_libc_20_1_2_NumberPair>, IEqualityOperators<InlineArray193_Llvm_libc_20_1_2_NumberPair, InlineArray193_Llvm_libc_20_1_2_NumberPair, bool>, IEnumerable, IInlineArray<InlineArray193_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
{
	private Llvm_libc_20_1_2_NumberPair __element0;

	public static int Length => 193;

	public static bool operator ==(InlineArray193_Llvm_libc_20_1_2_NumberPair x, InlineArray193_Llvm_libc_20_1_2_NumberPair y)
	{
		return InlineArrayHelper.Equals<InlineArray193_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>(x, y);
	}

	public static bool operator !=(InlineArray193_Llvm_libc_20_1_2_NumberPair x, InlineArray193_Llvm_libc_20_1_2_NumberPair y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray193_Llvm_libc_20_1_2_NumberPair other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray193_Llvm_libc_20_1_2_NumberPair)
		{
			return Equals((InlineArray193_Llvm_libc_20_1_2_NumberPair)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray193_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_NumberPair>)this).GetEnumerator();
	}
}
